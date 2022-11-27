using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.Classes
{
    internal class Client
    {
        private int id;
        private static int count =3;
        private string fullname;
        private string cin;
        private bool active = true;

        public Client(string fullname, string cin, bool active)
        {
            this.id = count;
            this.Fullname = fullname;
            this.Cin = cin;
            this.Active = active;
            count++;
        }

        public int Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Cin { get => cin; set => cin = value; }
        public bool Active { get => active; set => active = value; }
    }
}
