using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WF_GestionStock.Enums;
using WF_GestionStock.Services;

namespace WF_GestionStock
{
    public partial class Form1 : Form
    {
        StockEntities context = new StockEntities();
        private CategorieService categorieService;
        private ProduitService produitService;
        private MouvementService mouvementService;

        List<Categorie> Categories = new List<Categorie>();
        List<Mouvement> Mouvements = new List<Mouvement>();

        public Form1()
        {
            InitializeComponent();
            categorieService = new CategorieService(context);
            produitService = new ProduitService(context);
            mouvementService = new MouvementService(context);
            Categories = categorieService.GetCategories();
            Mouvements = mouvementService.GetMouvements();
            ListMvt.FullRowSelect = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var c in Categories)
            {
                AjoutProduitCategorie.Items.Add(String.Format("{0}/ {1}", c.Id, c.Nom));
            }

            DisplayHistoMouvement();
        }

        private void AjoutProduitButton_Click(object sender, EventArgs e)
        {
            Produit produit = new Produit()
            {
                Categorie = Categories.Where(c => c.Id == int.Parse(AjoutProduitCategorie.Text.Substring(0, 1))).First(),
                Quantité = 1,
                Nom = AjoutProduitNom.Text,
                PrixHt = double.Parse(AjoutProduitPrixHT.Text)
            };

            mouvementService.AddMouvement(new Mouvement()
            {
                TypeMouvement = TypeMouvementEnum.TypeMouvement.Entrée.ToString(),
                Produit = produit
            });

            DisplayHistoMouvement();

        }

        private void DisplayHistoMouvement()
        {
            Mouvements = mouvementService.GetMouvements();
            ListMvt.Items.Clear();
            foreach (var m in Mouvements)
            {
                string[] row = {m.Produit.Id.ToString(), m.TypeMouvement, m.Produit.Nom};
                var ListMvtRow = new ListViewItem(row);
                ListMvt.Items.Add(ListMvtRow);
            }
        }

        private void ListMvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListMvt.SelectedItems.Count > 0)
            {
                ListViewItem Item = ListMvt.SelectedItems[0];
                int IdProduct = int.Parse(Item.SubItems[0].Text);

                Item.Selected = false;
                Form2 DetailsPdtForm = new Form2(IdProduct);
                DetailsPdtForm.Show();
            }

        }
    }
}
