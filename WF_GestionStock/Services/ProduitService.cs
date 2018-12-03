using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_GestionStock.Services
{
    class ProduitService
    {
        StockEntities Context;

        public ProduitService(StockEntities context)
        {
            Context = context;
        }

        public List<Produit> GetProduits()
        { 
            return Context.Produit.ToList();
        }

        public Produit GetProduit(int Id)
        {
            return Context.Produit.Where(p => p.Id == Id).Single();
        }

        public int AddProduit(Produit Produit)
        {
            Context.Produit.Add(Produit);
            try
            {
                Context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            return Context.Produit.Add(Produit).Id;

        }

        public Produit UpdateProduit(Produit Produit)
        {
            var pro = Context.Produit.Where(p => p.Id == Produit.Id).Single();
            pro.Nom = Produit.Nom;
            pro.PrixHt = Produit.PrixHt;
            Context.SaveChanges();
            return pro;
        }

        public void DeleteProduit(Produit Produit)
        {
            Context.Produit.Remove(Produit);
            Context.SaveChanges();
        }

        
    }
}
