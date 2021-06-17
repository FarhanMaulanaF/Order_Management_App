
namespace ProyekUAS2021.Control_User
{
    partial class UC_PlaceOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.PanelExecution = new System.Windows.Forms.Panel();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemoveRed = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddtoChart = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.txtQuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.PanelExecution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(49, 427);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(159, 49);
            this.lblTotalAmount.TabIndex = 33;
            this.lblTotalAmount.Text = "Rp. 00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(53, 393);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(139, 28);
            this.lblGrandTotal.TabIndex = 32;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemName.Location = new System.Drawing.Point(248, 144);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(201, 26);
            this.tbItemName.TabIndex = 28;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(244, 120);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(89, 19);
            this.lblItemName.TabIndex = 27;
            this.lblItemName.Text = "Item Name";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(54, 196);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(143, 184);
            this.listBox.TabIndex = 25;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(54, 156);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(123, 26);
            this.tbSearch.TabIndex = 24;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Cake",
            "Pastry",
            "Soft Drink",
            "Hot Beverage"});
            this.cbCategory.Location = new System.Drawing.Point(54, 111);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(143, 26);
            this.cbCategory.TabIndex = 23;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(50, 87);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 19);
            this.lblCategory.TabIndex = 22;
            this.lblCategory.Text = "Category";
            // 
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.AutoSize = true;
            this.lblPlaceOrder.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOrder.Location = new System.Drawing.Point(37, 25);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(244, 46);
            this.lblPlaceOrder.TabIndex = 21;
            this.lblPlaceOrder.Text = "Place Order";
            // 
            // PanelExecution
            // 
            this.PanelExecution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelExecution.Controls.Add(this.btnPrint);
            this.PanelExecution.Controls.Add(this.numQuantity);
            this.PanelExecution.Controls.Add(this.lblPrice);
            this.PanelExecution.Controls.Add(this.tbTotal);
            this.PanelExecution.Controls.Add(this.lblTotal);
            this.PanelExecution.Controls.Add(this.btnRemoveRed);
            this.PanelExecution.Controls.Add(this.lblQuantity);
            this.PanelExecution.Controls.Add(this.btnAddtoChart);
            this.PanelExecution.Controls.Add(this.tbPrice);
            this.PanelExecution.Location = new System.Drawing.Point(228, 111);
            this.PanelExecution.Name = "PanelExecution";
            this.PanelExecution.Size = new System.Drawing.Size(489, 167);
            this.PanelExecution.TabIndex = 31;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(19, 89);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(201, 26);
            this.numQuantity.TabIndex = 39;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(264, 8);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 19);
            this.lblPrice.TabIndex = 35;
            this.lblPrice.Text = "Price";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(268, 89);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(201, 26);
            this.tbTotal.TabIndex = 38;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(264, 64);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 19);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "Total";
            // 
            // btnRemoveRed
            // 
            this.btnRemoveRed.BackColor = System.Drawing.Color.Red;
            this.btnRemoveRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveRed.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRed.ForeColor = System.Drawing.Color.White;
            this.btnRemoveRed.Location = new System.Drawing.Point(185, 123);
            this.btnRemoveRed.Name = "btnRemoveRed";
            this.btnRemoveRed.Size = new System.Drawing.Size(123, 36);
            this.btnRemoveRed.TabIndex = 20;
            this.btnRemoveRed.Text = "Remove";
            this.btnRemoveRed.UseVisualStyleBackColor = false;
            this.btnRemoveRed.Click += new System.EventHandler(this.btnRemoveRed_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(15, 64);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 19);
            this.lblQuantity.TabIndex = 34;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnAddtoChart
            // 
            this.btnAddtoChart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddtoChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddtoChart.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoChart.ForeColor = System.Drawing.Color.White;
            this.btnAddtoChart.Location = new System.Drawing.Point(56, 123);
            this.btnAddtoChart.Name = "btnAddtoChart";
            this.btnAddtoChart.Size = new System.Drawing.Size(123, 36);
            this.btnAddtoChart.TabIndex = 16;
            this.btnAddtoChart.Text = "Add to Chart";
            this.btnAddtoChart.UseVisualStyleBackColor = false;
            this.btnAddtoChart.Click += new System.EventHandler(this.btnAddtoChart_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(268, 32);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(201, 26);
            this.tbPrice.TabIndex = 12;
            // 
            // txtQuantityUpDown
            // 
            this.txtQuantityUpDown.Location = new System.Drawing.Point(248, 201);
            this.txtQuantityUpDown.Name = "txtQuantityUpDown";
            this.txtQuantityUpDown.Size = new System.Drawing.Size(201, 26);
            this.txtQuantityUpDown.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quantity";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(497, 201);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(201, 26);
            this.txtTotal.TabIndex = 29;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // dgMenu
            // 
            this.dgMenu.ColumnHeadersHeight = 35;
            this.dgMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgMenu.Location = new System.Drawing.Point(228, 296);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.RowHeadersWidth = 62;
            this.dgMenu.RowTemplate.Height = 28;
            this.dgMenu.Size = new System.Drawing.Size(489, 180);
            this.dgMenu.TabIndex = 34;
            this.dgMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMenu_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Lime;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(314, 123);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(123, 36);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // UC_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPlaceOrder);
            this.Controls.Add(this.PanelExecution);
            this.Controls.Add(this.txtQuantityUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Name = "UC_PlaceOrder";
            this.Size = new System.Drawing.Size(765, 514);
            this.PanelExecution.ResumeLayout(false);
            this.PanelExecution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.Panel PanelExecution;
        private System.Windows.Forms.Button btnRemoveRed;
        private System.Windows.Forms.Button btnAddtoChart;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.NumericUpDown txtQuantityUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView dgMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnPrint;
    }
}
