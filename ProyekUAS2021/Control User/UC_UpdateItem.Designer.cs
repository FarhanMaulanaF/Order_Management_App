
namespace ProyekUAS2021.Control_User
{
    partial class UC_UpdateItem
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgMenu = new System.Windows.Forms.DataGridView();
            this.tbSearchItem = new System.Windows.Forms.TextBox();
            this.lblItemSearchName = new System.Windows.Forms.Label();
            this.lblUpdateItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(497, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 53);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(466, 376);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(206, 30);
            this.tbPrice.TabIndex = 20;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(462, 339);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Price";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(91, 457);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(206, 30);
            this.tbName.TabIndex = 18;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(87, 420);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(109, 24);
            this.lblItemName.TabIndex = 17;
            this.lblItemName.Text = "Item Name";
            // 
            // tbCategory
            // 
            this.tbCategory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategory.Location = new System.Drawing.Point(91, 376);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(206, 30);
            this.tbCategory.TabIndex = 16;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(87, 339);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(96, 24);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Category";
            // 
            // dgMenu
            // 
            this.dgMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgMenu.GridColor = System.Drawing.Color.Black;
            this.dgMenu.Location = new System.Drawing.Point(44, 144);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.RowHeadersWidth = 62;
            this.dgMenu.RowTemplate.Height = 28;
            this.dgMenu.Size = new System.Drawing.Size(682, 178);
            this.dgMenu.TabIndex = 14;
            this.dgMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMenu_CellClick);
            // 
            // tbSearchItem
            // 
            this.tbSearchItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchItem.Location = new System.Drawing.Point(500, 94);
            this.tbSearchItem.Name = "tbSearchItem";
            this.tbSearchItem.Size = new System.Drawing.Size(206, 30);
            this.tbSearchItem.TabIndex = 13;
            this.tbSearchItem.TextChanged += new System.EventHandler(this.tbSearchItem_TextChanged);
            // 
            // lblItemSearchName
            // 
            this.lblItemSearchName.AutoSize = true;
            this.lblItemSearchName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemSearchName.Location = new System.Drawing.Point(496, 57);
            this.lblItemSearchName.Name = "lblItemSearchName";
            this.lblItemSearchName.Size = new System.Drawing.Size(109, 24);
            this.lblItemSearchName.TabIndex = 12;
            this.lblItemSearchName.Text = "Item Name";
            // 
            // lblUpdateItem
            // 
            this.lblUpdateItem.AutoSize = true;
            this.lblUpdateItem.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateItem.Location = new System.Drawing.Point(36, 22);
            this.lblUpdateItem.Name = "lblUpdateItem";
            this.lblUpdateItem.Size = new System.Drawing.Size(246, 46);
            this.lblUpdateItem.TabIndex = 11;
            this.lblUpdateItem.Text = "Update Item";
            // 
            // UC_UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.tbSearchItem);
            this.Controls.Add(this.lblItemSearchName);
            this.Controls.Add(this.lblUpdateItem);
            this.Name = "UC_UpdateItem";
            this.Size = new System.Drawing.Size(765, 514);
            this.Load += new System.EventHandler(this.UC_UpdateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dgMenu;
        private System.Windows.Forms.TextBox tbSearchItem;
        private System.Windows.Forms.Label lblItemSearchName;
        private System.Windows.Forms.Label lblUpdateItem;
    }
}
