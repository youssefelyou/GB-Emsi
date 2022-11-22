using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.Classes
{
    internal class Periodique :Ouvrage
    {
        private string nom;
        private int numero;
        private string periodicite;

        public Periodique(string nom, int numero, string periodicite, string date) : base(date)
        {
            this.Nom = nom;
            this.Numero = numero;
            this.Periodicite = periodicite;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Periodicite { get => periodicite; set => periodicite = value; }
    }
}
