using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_GestionStock.Services;
using WF_GestionStock.Enums;

namespace WF_GestionStock
{
    public partial class Form2 : Form
    {
        StockEntities context = new StockEntities();
        private ProduitService produitService;
        private CategorieService categorieService;
        private MouvementService mouvementService;
        private Produit Produit;
        private int Qty;
        List<Mouvement> Mouvements = new List<Mouvement>();
        List<Categorie> Categories = new List<Categorie>();


        public Form2(int ProduitId)
        {
            InitializeComponent();
            produitService = new ProduitService(context);
            mouvementService = new MouvementService(context);
            categorieService = new CategorieService(context);
            Produit = produitService.GetProduit(ProduitId);
            Mouvements = mouvementService.GetMouvements();
            Categories = categorieService.GetCategories();
            Qty = GetQuantity(ProduitId);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NameBox.Text = Produit.Nom;
            foreach (var c in Categories)
            {
                CatComboBox.Items.Add(String.Format("{0}/ {1}", c.Id, c.Nom));
            }
            CatComboBox.SelectedIndex = Produit.Categorie.Id - 1;
            CatComboBox.SelectedItem = 1;
            QtyBox.Text = Qty.ToString();
        }

        private int GetQuantity(int Id)
        {
            int In = 0;
            int Out = 0;
            int Qty;
            foreach(var m in Mouvements)
            {
                if (Id == m.Produit.Id)
                {
                    if (m.TypeMouvement == TypeMouvementEnum.TypeMouvement.Entrée.ToString())
                    {
                        In += 1;
                    } else
                    {
                        Out += 1;
                    }
                }
            }
            return Qty = In - Out;

        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Produit.Nom = NameBox.Text;
            Produit.Categorie = Categories.Where(c => c.Id == int.Parse(CatComboBox.Text.Substring(0, 1))).First();
            produitService.UpdateProduit(Produit);
        }
    }
}
