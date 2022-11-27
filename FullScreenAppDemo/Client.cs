using Guna.UI2.WinForms;
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
    public partial class Client : Form
    {

        MySqlConnection connexion = new MySqlConnection($"datasource=localhost;port=3306;username=root;password=root;database=twengo");


        public Client()
        {
            InitializeComponent();
        }

       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                NomComplet.Text = listView1.SelectedItems[0].SubItems[1].Text;
                guna2TextBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }


        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            if (NomComplet.Text == "" || guna2TextBox3.Text == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (connexion.State != ConnectionState.Open)
                    {
                        connexion.Open();
                    }
                        
                    FullScreenAppDemo.Classes.Client client = new FullScreenAppDemo.Classes.Client(NomComplet.Text, guna2TextBox3.Text, userActive.Checked);
                  
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO client (id, fullname, cin, active)" + " VALUES (@id, @fullname, @cin, 1)", connexion);
                    cmd.Parameters.AddWithValue("@id", client.Id);
                    cmd.Parameters.AddWithValue("@fullname", client.Fullname);
                    cmd.Parameters.AddWithValue("@cin", client.Cin);
                    cmd.ExecuteNonQuery();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void NomComplet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
