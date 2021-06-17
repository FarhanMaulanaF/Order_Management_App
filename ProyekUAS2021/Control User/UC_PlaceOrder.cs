using DGVPrinterHelper;
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
    public partial class UC_PlaceOrder : UserControl
    {
        function connect = new function();
        String query;

        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = cbCategory.Text;
            query = "select name from managementorder where category = '"+category+"' ";
            showItemList(query);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            String category = cbCategory.Text;
            query = "select name from managementorder where category = '" + category + "' and name like '"+tbSearch.Text+"%' ";
            showItemList(query);
        }

        private void showItemList(String query)
        {
            listBox.Items.Clear();
            DataSet ds = connect.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numQuantity.ResetText();
            tbTotal.Clear();

            String text = listBox.GetItemText(listBox.SelectedItem);
            tbItemName.Text = text;
            query = "select price from managementorder where name = '"+text+"' ";
            DataSet ds = connect.getData(query);

            try
            {
                tbPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(numQuantity.Value.ToString());
            Int64 price = Int64.Parse(tbPrice.Text);
            tbTotal.Text = (quan * price).ToString();
        }

        int amount;
        private void dgMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dgMenu.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        protected int n, total = 0;

        private void btnRemoveRed_Click(object sender, EventArgs e)
        {
            try
            { 
                dgMenu.Rows.RemoveAt(this.dgMenu.SelectedRows[0].Index);
            }
            catch {  }
            total -= amount;
            lblTotalAmount.Text = "Rp." + total;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + lblTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgMenu);

            total = 0;
            dgMenu.Rows.Clear();
            lblTotalAmount.Text = "Rp. " + total;
        }

        private void btnAddtoChart_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text != "0" && tbTotal.Text != "")
            {
                n = dgMenu.Rows.Add();
                dgMenu.Rows[n].Cells[0].Value = tbItemName.Text;
                dgMenu.Rows[n].Cells[1].Value = tbPrice.Text;
                dgMenu.Rows[n].Cells[2].Value = numQuantity.Value;
                dgMenu.Rows[n].Cells[3].Value = tbTotal.Text;

                total += int.Parse(tbTotal.Text);
                lblTotalAmount.Text = "Rp." + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
