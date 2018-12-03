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
    public partial class Form1 : Form
    {
        StockEntities context = new StockEntities();
        private CategorieService categorieService;
        private ProduitService produitService;
        private MouvementService mouvementService;

        List<Categorie> Categories = new List<Categorie>();

        public Form1()
        {
            InitializeComponent();
            categorieService = new CategorieService(context);
            produitService = new ProduitService(context);
            mouvementService = new MouvementService(context);
            Categories = categorieService.GetCategories();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var c in Categories)
            { 
                AjoutProduitCategorie.Items.Add(String.Format("{0}/ {1}", c.Id, c.Nom));
            }
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

        }
    }
}
