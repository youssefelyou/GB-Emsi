using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.Classes
{
    internal class Emprunt
    {
        private int id;
        private DateTime dateemprunt; 
        private DateTime daterendre;
        private Ouvrage ouvrage;
        private Client client;
        private bool retour;

        public Emprunt(int id,DateTime dateemprunt, DateTime daterendre, Ouvrage ouvrage, bool retour, Client client)
        {
            this.Dateemprunt = dateemprunt;
            this.Daterendre = daterendre;
            this.Ouvrage = ouvrage;
            this.Retour = retour;
            this.client = client;
        }

        public DateTime Dateemprunt { get => dateemprunt; set => dateemprunt = value; }
        public DateTime Daterendre { get => daterendre; set => daterendre = value; }
        public bool Retour { get => retour; set => retour = value; }
        internal Ouvrage Ouvrage { get => ouvrage; set => ouvrage = value; }

        internal Client Client { get => client; set => client = value; }
    }
}
