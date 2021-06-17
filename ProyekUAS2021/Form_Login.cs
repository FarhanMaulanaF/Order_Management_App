using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekUAS2021
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "farhan" && tbPassword.Text == "460544")
            {
                Form_Dasboard dasboard = new Form_Dasboard("Admin");
                dasboard.Show();
                this.Hide();
            }
        }

        private void linkGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Dasboard dasboard = new Form_Dasboard("Guest");
            dasboard.Show();
            this.Hide(); 
        }
    }
}
