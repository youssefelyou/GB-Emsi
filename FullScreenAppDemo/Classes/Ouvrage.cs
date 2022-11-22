using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.Classes
{
     class Ouvrage
    {
        private int id;
        private string date;
        //private static int count = 0;

        protected int Id { get => id; set => id = value; }
        protected string Date { get => date; set => date = value; }



        public Ouvrage(string date)
        {
            this.date = date;
        }

        public override string ToString()
        {
            return "id" + id + "Date d'emprunt" + date;
        }
    }
}
