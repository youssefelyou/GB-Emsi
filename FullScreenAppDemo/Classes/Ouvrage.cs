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
        private static int count = 10;

        protected int Id { get => id; set => id = value; }
        protected string Date { get => date; set => date = value; }


        public void setDate(string date)
        {
            this.id =+ count;
            this.date = date;
        }

        public string getDate()
        {
            return date;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public Ouvrage(string date)
        {
            this.id = +count;
            this.date = date;
        }

        public override string ToString()
        {
            return "id" + id + "Date d'emprunt" + date;
        }
    }
}
