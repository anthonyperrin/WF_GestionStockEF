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
        private MouvementService mouvementService;
        private Produit Produit;
        private int Qty;
        List<Mouvement> Mouvements = new List<Mouvement>();


        public Form2(int Id)
        {
            InitializeComponent();
            produitService = new ProduitService(context);
            mouvementService = new MouvementService(context);
            Produit = produitService.GetProduit(Id);
            Mouvements = mouvementService.GetMouvements();
            Qty = GetQuantity(Id);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NameBox.Text = Produit.Nom;
            CatBox.Text = Produit.Categorie.Nom;
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
            this.Close();
        }
    }
}
