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
    public partial class Login : Form
    {
        private string admin = "admin";
        private string pass = "admin";
       
        public Login()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.errorMessage.Visible = false;
            this.guna2TextBox2.BorderColor = Color.FromArgb(234, 153, 149);
            this.guna2TextBox1.BorderColor = Color.FromArgb(234, 153, 149);

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            this.errorMessage.Visible = false;
            this.guna2TextBox2.BorderColor = Color.FromArgb(234, 153, 149);
            this.guna2TextBox1.BorderColor = Color.FromArgb(234, 153, 149);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(this.guna2TextBox1.Text.Equals(this.admin) && this.guna2TextBox2.Text.Equals(this.pass))
            {
                Form1 form1 = new Form1();
                form1.admin = this.admin;
                form1.Show();
                this.Hide();
            } else
            {
                this.errorMessage.Visible = true;
                this.guna2TextBox2.BorderColor = Color.Red;
                this.guna2TextBox1.BorderColor = Color.Red;
            }

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
