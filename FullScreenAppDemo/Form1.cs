using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
    public partial class Form1 : Form
    {
        public string admin;
        public Form1()
        {
            InitializeComponent();
          

            this.label1.Text = "Bonjour admin " ;// TODO

            this.init_data();
        }

        private void init_data()
        {


        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Guna2Button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.guna2Button1.BackColor = Color.AliceBlue;
            this.dashboard1.Show();
            this.clientList1.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.guna2Button1.BackColor = Color.AliceBlue;
            this.dashboard1.Show();
            this.clientList1.Hide();
            this.ouvrage1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.guna2Button3.BackColor = Color.LightSkyBlue;
            this.dashboard1.Hide();
            this.clientList1.Hide();
            this.ouvrage1.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.guna2Button1.BackColor = Color.White;
            this.guna2Button2.BackColor = Color.AliceBlue;
            this.dashboard1.Hide();
            this.clientList1.Show();
        }



        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
