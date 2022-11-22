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
            this.Auteur = auteur;
            this.Titre = titre;
            this.Editeur = editeur;
        }

        public string Auteur { get => auteur; set => auteur = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Editeur { get => editeur; set => editeur = value; }
    }
}
