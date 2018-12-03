using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_GestionStock.Services
{
    class CategorieService
    {
        StockEntities Context;

        public CategorieService(StockEntities context)
        {
            Context = context;
        }

        public List<Categorie> GetCategories()
        {
            return Context.Categorie.ToList();
        }
    }
}
