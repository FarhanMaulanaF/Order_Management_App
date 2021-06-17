using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekUAS2021.Control_User
{
    public partial class UC_RemoveItems : UserControl
    {
        function connect = new function();
        String query;
        
        public UC_RemoveItems()
        {
            InitializeComponent();
        }

        private void UC_RemoveItems_Load(object sender, EventArgs e)
        {
            lblTutorial.Text = "How to DELETE?";
            lblTutorial.ForeColor = Color.Blue;
            loadData();
        }
        public void loadData()
        {
            query = "select * from managementorder";
            DataSet ds = connect.getData(query);
            dgMenu.DataSource = ds.Tables[0];
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from managementorder where name like '" + tbSearch.Text + "%' ";
            DataSet ds = connect.getData(query);
            dgMenu.DataSource = ds.Tables[0];
        }

        private void dgMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete item?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dgMenu.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from managementorder where iid = " + id + " ";
                connect.setData(query);
                loadData();
            }
        }

        private void lblTutorial_Click(object sender, EventArgs e)
        {
            lblTutorial.ForeColor = Color.Red;
            lblTutorial.Text = "*Click on Row to Delete the Item";
        }

        private void UC_RemoveItems_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
