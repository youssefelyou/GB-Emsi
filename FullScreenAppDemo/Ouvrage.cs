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
            if(connexion.State != ConnectionState.Open)connexion.Open();
            string request = "SELECT id, auteur, titre, editeur, nom, numero, periodicite, date FROM ouvrage";
            MySqlCommand cmd = new MySqlCommand(request, connexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            List<string> myArray;
            listOfOuvrage.DataSource = null;
            listOfOuvrage.Rows.Clear();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                myArray = new List<string>();
                foreach (var item in dataRow.ItemArray)
                {
                    myArray.Add(item.ToString());
                }
                listOfOuvrage.Rows.Add(myArray[0], myArray[1], myArray[2], myArray[3], myArray[4], myArray[5], myArray[6], myArray[7]);
            }
        }

        private void findByTypeOf(string type)
        {
            if (connexion.State != ConnectionState.Open) connexion.Open();
            listOfOuvrage.DataSource = null;
            listOfOuvrage.Rows.Clear();
            listOfOuvrage.Refresh();
            string request;
            if (type == "CD")
            {
                 request = "SELECT id, auteur, titre, editeur, nom, numero, periodicite, date FROM ouvrage WHERE detype='CD'";

            } else if(type == "LIVRE")
            {
                request = "SELECT id, auteur, titre, editeur, nom, numero, periodicite, date FROM ouvrage WHERE detype='LIVRE'";

            } else
            {
                request = "SELECT id, auteur, titre, editeur, nom, numero, periodicite, date FROM ouvrage WHERE detype='PERIODIQUE'";
            }

            MySqlCommand cmd = new MySqlCommand(request, connexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            List<string> myArray;
         
            foreach (DataRow dataRow in dataTable.Rows)
            {
                myArray = new List<string>();
                foreach (var item in dataRow.ItemArray)
                {
                    myArray.Add(item.ToString());
                }
                listOfOuvrage.Rows.Add(myArray[0], myArray[1], myArray[2], myArray[3], myArray[4], myArray[5], myArray[6], myArray[7]);
            }

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
            DataGridViewRow row = this.listOfOuvrage.Rows[e.RowIndex];
            string id = row.Cells[0].Value.ToString();

            if (connexion.State != ConnectionState.Open)
            {
                connexion.Open();
            }
            MySqlCommand cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT detype, id, auteur, titre, editeur, nom, numero, periodicite, date FROM ouvrage WHERE id=" + id;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            
            List<string> myArray = new List<string>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    myArray.Add(item.ToString());
                }
                listOfOuvrage.Rows.Add(myArray[0], myArray[1], myArray[2], myArray[3], myArray[4], myArray[5], myArray[6], myArray[7], myArray[8]);


                if (myArray[7] == "CD")
                {
                    label1.Text = myArray[8];

                } else if(myArray[7] == "LIVRE")
                {
                    label1.Text = myArray[8];
                } else
                {
                    label1.Text = myArray[8];
                }
            }
        }
    }
}
