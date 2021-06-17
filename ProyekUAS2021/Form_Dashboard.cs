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
    public partial class Form_Dasboard : Form
    {
        public Form_Dasboard()
        {
            InitializeComponent();
        }
        public Form_Dasboard(string user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdateItems.Hide();
                btnRemoveItems.Hide();
            }
            else if (user == "Admin")
            {
                btnAddItems.Show();
                btnUpdateItems.Show();
                btnRemoveItems.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Hide();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
        }

        private void Form_Dasboard_Load(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItem1.Visible = false;
            uC_RemoveItems1.Visible = false;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            uC_UpdateItem1.Visible = true;
            uC_UpdateItem1.BringToFront();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            uC_RemoveItems1.Visible = true;
            uC_RemoveItems1.BringToFront();
        }
    }
}
