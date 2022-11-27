using FullScreenAppDemo.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Ouvrage : UserControl
    {
        DataTable dataTable = new DataTable();
        MySqlConnection connexion = new MySqlConnection($"datasource=localhost;port=3306;username=root;password=root;database=twengo");
        Cd cd;
        Periodique per;
        FullScreenAppDemo.Classes.Client client;
        FullScreenAppDemo.Classes.Ouvrage ouvrageClass;
        FullScreenAppDemo.Classes.Livre livre;

        public Ouvrage()
        {
            InitializeComponent();
           
            this.filterOuvrages.Items.Add("CD");
            this.filterOuvrages.Items.Add("Livre");
            this.filterOuvrages.Items.Add("Periodique");

            this.getListOfOuvrages();
        }

        public void getListOfOuvrages()
        {
            dataTable = new DataTable();
            if (connexion.State != ConnectionState.Open)connexion.Open();
            string request = "SELECT id, auteur, titre, editeur, nom, numero, periodicite, date FROM ouvrage";
            MySqlCommand cmd = new MySqlCommand(request, connexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            listOfOuvrage.DataSource = dataTable;
        }

        private void findByTypeOf(string type)
        {
            if (connexion.State != ConnectionState.Open) connexion.Open();
            dataTable = new DataTable();
            string request;
            if (type == "CD")
            {
                 request = "SELECT id, auteur, titre, date FROM ouvrage WHERE detype='CD'";

            } else if(type == "LIVRE")
            {
                request = "SELECT id, auteur, titre, editeur, date FROM ouvrage WHERE detype='LIVRE'";

            } else
            {
                request = "SELECT id, numero, periodicite, date FROM ouvrage WHERE detype='PERIODIQUE'";
            }

            MySqlCommand cmd = new MySqlCommand(request, connexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            listOfOuvrage.DataSource = dataTable;
        }



        private void newOuvrageButton_Click(object sender, EventArgs e)
        {
            CreateOuvrage createOuvrage = new CreateOuvrage();
            createOuvrage.FormClosing += new FormClosingEventHandler(this.CreateOuvrage_FormClosing);
            createOuvrage.ShowDialog();
        }
        private void CreateOuvrage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.getListOfOuvrages();
        }

        private void chercherOuvrage_TextChanged(object sender, EventArgs e)
        {

        }

        private void listOfOuvrage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void filterOuvrages_SelectedIndexChanged(object sender, EventArgs e)
        {
                this.findByTypeOf(this.filterOuvrages.SelectedItem.ToString().ToUpper());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listOfOuvrage_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void listOfOuvrage_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.listOfOuvrage.Rows[e.RowIndex];
            string id = row.Cells[0].Value.ToString();
            

            if (connexion.State != ConnectionState.Open)
            {
                connexion.Open();
            }
            MySqlCommand cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT id, auteur, titre, editeur, nom, numero, periodicite, date, detype FROM ouvrage WHERE id=" + id;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            List<string> myArray = new List<string>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                CreateOuvrage createOuvrage = new CreateOuvrage();
                foreach (var item in dataRow.ItemArray)
                {
                    myArray.Add(item.ToString());
                }

                label1.Text = myArray[8];

                if (myArray[8] == "CD")
                {
                    cd = new Cd(myArray[1], myArray[2], myArray[7]);
                    createOuvrage.cd = cd;
                    createOuvrage.FormClosing += new FormClosingEventHandler(this.CreateOuvrage_FormClosing);
                    createOuvrage.ShowDialog();

                }
                else if (myArray[8] == "LIVRE")
                {

                }
                else
                {

                }
            }

        }
    }
}
