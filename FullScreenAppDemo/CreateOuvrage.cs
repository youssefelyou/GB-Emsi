using FullScreenAppDemo.Classes;
using Google.Protobuf.WellKnownTypes;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace FullScreenAppDemo
{
    public partial class CreateOuvrage : Form
    {
        
        MySqlConnection connexion = new MySqlConnection($"datasource=localhost;port=3306;username=root;password=root;database=twengo");

        public Cd cd;
        public Periodique per;
        public FullScreenAppDemo.Classes.Client client;
        public FullScreenAppDemo.Classes.Ouvrage ouvrageClass;
        public FullScreenAppDemo.Classes.Livre livre;

        public CreateOuvrage()
        {
            InitializeComponent();
            this.typeOuvrages.Items.Add("CD");
            this.typeOuvrages.Items.Add("Livre");
            this.typeOuvrages.Items.Add("Periodique");
            this.hideAll();
        }

        private void hideAll()
        {
            this.auteur.Text = null;
            this.titre.Text = null;
            this.editeur.Text = null;
            this.nom.Text = null;
            this.numero.Text = null;
            this.periodicite.Text = null;

            if (cd != null)
            {
                this.auteur.Show();
                this.titre.Show();
                typeOuvrages.SelectedValue = "CD";
            } else if(livre != null)
            {
                this.auteur.Show();
                this.titre.Show();
                this.editeur.Show();
            } else if(per != null)
            {
                this.nom.Show();
                this.numero.Show();
                this.periodicite.Show();
            } else
            {
                this.auteur.Hide();
                this.titre.Hide();
                this.editeur.Hide();
                this.nom.Hide();
                this.numero.Hide();
                this.periodicite.Hide();
            }

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void typeOuvrages_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hideAll();
            if (this.typeOuvrages.SelectedItem.Equals("CD"))
            {
                this.auteur.Show();
                this.titre.Show();
            } else if (this.typeOuvrages.SelectedItem.Equals("Periodique"))
            {
                this.numero.Show();
                this.nom.Show();
                this.periodicite.Show();
            } else
            {
                this.auteur.Show();
                this.titre.Show();
                this.editeur.Show();

            }

        }

        private void auteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (this.typeOuvrages.SelectedItem.Equals("CD"))
            {
               Cd cd = new Cd(auteur.Text, this.titre.Text, this.dateBox.Text);
                connexion.Open();
                MySqlCommand cmd = connexion.CreateCommand();

                cmd.CommandText = "INSERT INTO `ouvrage`(`id`,`date`, `auteur`, `titre`,  `detype`)" +
                    "VALUES(@id, @date,@auteur,@titre,'CD')";
                cmd.Parameters.AddWithValue("@id", cd.getId());
                cmd.Parameters.AddWithValue("@date",cd.getDate());
                cmd.Parameters.AddWithValue("@auteur", cd.getAuteur());
                cmd.Parameters.AddWithValue("@titre", cd.getTitre());
                cmd.ExecuteNonQuery();
                connexion.Close();
            }
            else if (this.typeOuvrages.SelectedItem.Equals("Periodique"))
            {
                Periodique periodique = new Periodique(this.nom.Text,int.Parse(this.numero.Text), this.periodicite.Text, this.dateBox.Text);

                if (connexion.State != ConnectionState.Open) connexion.Open();
                MySqlCommand cmd = connexion.CreateCommand();
                cmd.CommandText = "INSERT INTO `ouvrage`(`id`,`date`,`nom`, `numero`, `periodicite`,  `detype`)" +
                    "VALUES(@id, @date,@nom, @numero,@periodicite,'PERIODIQUE')";
                cmd.Parameters.AddWithValue("@id", periodique.getId());
                cmd.Parameters.AddWithValue("@date", periodique.getDate());
                cmd.Parameters.AddWithValue("@nom", periodique.getNom());
                cmd.Parameters.AddWithValue("@numero", periodique.getNumero());
                cmd.Parameters.AddWithValue("@periodicite", periodique.getPeriodicite());
                cmd.ExecuteNonQuery();
                connexion.Close();
            }
            else
            {
                this.auteur.Show();
                this.titre.Show();
                this.editeur.Show();
                Livre livre = new Livre(auteur.Text, this.titre.Text,this.editeur.Text, this.dateBox.Text);
                connexion.Open();
                MySqlCommand cmd = connexion.CreateCommand();

                cmd.CommandText = "INSERT INTO `ouvrage`(`id`,`date`, `auteur`, `titre`, `editeur`,  `detype`)" +
                    "VALUES(@id, @date,@auteur,@titre,@editeur,'LIVRE')";
                cmd.Parameters.AddWithValue("@id", livre.getId());
                cmd.Parameters.AddWithValue("@date", livre.getDate());
                cmd.Parameters.AddWithValue("@auteur", livre.getAuteur());
                cmd.Parameters.AddWithValue("@titre", livre.getTitre());
                cmd.Parameters.AddWithValue("@editeur", livre.getEditeur());
                cmd.ExecuteNonQuery();
                connexion.Close();

            }

            this.hideAll();
            this.Close();
        }


    }
}
