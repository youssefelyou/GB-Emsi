using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.Classes
{
    internal class Livre : Ouvrage
    {
        private String auteur, titre, editeur;

        public Livre(string auteur, string titre, string editeur, string date) : base(date)
        {
            this.auteur = auteur;
            this.titre = titre;
            this.editeur = editeur;
        }

        public string getEditeur()
        {
            return this.editeur;
        }

        public string setEditeur(string ed)
        {
            return this.editeur = ed;
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
