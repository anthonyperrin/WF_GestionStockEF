using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_GestionStock.Services
{
    class MouvementService
    {
        StockEntities Context;

        public MouvementService(StockEntities context)
        {
            Context = context;
        }

        public List<Mouvement> GetMouvements()
        {
            return Context.Mouvement.ToList();
        }

        public Mouvement GetMouvement(int Id)
        {
            return Context.Mouvement.Where(p => p.Id == Id).Single();
        }

        public int AddMouvement(Mouvement Mouvement)
        {
            Context.Mouvement.Add(Mouvement);
            Context.SaveChanges();
            return Context.Mouvement.Add(Mouvement).Id;
        }
    }
}

