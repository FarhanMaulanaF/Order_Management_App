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
    public partial class UC_AddItems : UserControl
    {
        function connect = new function();
        string query;

        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into managementorder (name, category, price) values ('" + tbItemName.Text + "','" + tbCategory.Text + "', " + tbPrice.Text + ")";
            connect.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            tbCategory.SelectedIndex = -1;
            tbItemName.Clear();
            tbPrice.Clear();
        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
