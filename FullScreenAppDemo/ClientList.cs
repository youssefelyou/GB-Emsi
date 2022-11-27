using FullScreenAppDemo.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullScreenAppDemo
{
    public partial class ClientList : UserControl
    {
        DataTable dataTable = new DataTable();
        MySqlConnection connexion = new MySqlConnection($"datasource=localhost;port=3306;username=root;password=root;database=twengo");
  
        
        public ClientList()
        {
            InitializeComponent();
            this.getListOfClients();
        }

        public void getListOfClients()
        {
            dataTable  = new DataTable();
            listOfClient.Refresh();
            if (connexion.State != ConnectionState.Open) connexion.Open();
            string request = "SELECT `id`, `fullname`, `cin`, `active` FROM `client`";
            MySqlCommand cmd = new MySqlCommand(request, connexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            listOfClient.DataSource = dataTable;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.FormClosing += new FormClosingEventHandler(this.CreateLivre_FormClosing);
            client.ShowDialog();
        
        }

        private void CreateLivre_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.getListOfClients();
        }
    }
}
