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

        public string Auteur { get => auteur; set => auteur = value; }
        public string Titre { get => titre; set => titre = value; }
    }
}
