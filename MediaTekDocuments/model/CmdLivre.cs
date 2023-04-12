using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class CmdLivre: Commande
    {
        public string Etape { get; set; }
        public int Quantité { get; set; }
        public string idArticle { get; set; }

        public CmdLivre(string etape, int nbExemplaire, string livre, string id, DateTime dateCommande, int montant) : base(id, dateCommande, montant)
        //base(id,dateCommande,montant)
        {
            Etape = etape;
            Quantité = nbExemplaire;
            idArticle = livre;
        }
    }
}
