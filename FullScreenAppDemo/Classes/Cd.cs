using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.Classes
{
     class Cd : Ouvrage
    {
        private string auteur, titre;

        public Cd(string auteur, string titre ,string date) : base(date)
        {
            this.auteur = auteur;
            this.titre = titre;
        }

        public string getAuteur()
        {
            return this.auteur;
        }
        public string getTitre()
        {
            return this.titre;
        }
        public void setAuteur(string auteur)
        {
            this.auteur = auteur;
        }
        
        public void setTitre(string titre)
        {
            this.titre = titre;
        }
       

    }
}
