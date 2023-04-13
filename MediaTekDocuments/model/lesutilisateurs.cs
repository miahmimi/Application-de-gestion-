using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class lesutilisateurs: Utilisateur
    {
        string id { get; set; }

        public lesutilisateurs(string id, string login, string pwd  ):base(login,pwd)
        {
            this.id = id;
        }
    }
}
