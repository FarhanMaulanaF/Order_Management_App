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
    public partial class UC_UpdateItem : UserControl
    {
        function connect = new function();
        String query;
        
        public UC_UpdateItem()
        {
            InitializeComponent();
        }

        private void UC_UpdateItem_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "select * from managementorder";
            DataSet ds = connect.getData(query);
            dgMenu.DataSource = ds.Tables[0];
        }

        private void tbSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from managementorder where name like '" + tbSearchItem.Text + "%' ";
            DataSet ds = connect.getData(query);
            dgMenu.DataSource = ds.Tables[0]; 
        }

        int id;
        private void dgMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgMenu.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = dgMenu.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = dgMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dgMenu.Rows[e.RowIndex].Cells[3].Value.ToString());

            tbCategory.Text = category;
            tbName.Text = name;
            tbPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update managementorder set name = '" + tbName.Text + "', category = '" + tbCategory.Text + "', price = " + tbPrice.Text + " where iid = " + id + " ";
            connect.setData(query);
            loadData();

            tbName.Clear();
            tbCategory.Clear();
            tbPrice.Clear();
        }
    }
}
