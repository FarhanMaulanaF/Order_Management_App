
namespace ProyekUAS2021.Control_User
{
    partial class UC_RemoveItems
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
            this.lblTutorial = new System.Windows.Forms.Label();
            this.dgMenu = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblRemoveItem2 = new System.Windows.Forms.Label();
            this.lblRemoveItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblTutorial
            // 
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial.Location = new System.Drawing.Point(568, 474);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(51, 19);
            this.lblTutorial.TabIndex = 10;
            this.lblTutorial.Text = "Label";
            this.lblTutorial.Click += new System.EventHandler(this.lblTutorial_Click);
            // 
            // dgMenu
            // 
            this.dgMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgMenu.GridColor = System.Drawing.Color.Black;
            this.dgMenu.Location = new System.Drawing.Point(48, 160);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.RowHeadersWidth = 62;
            this.dgMenu.RowTemplate.Height = 28;
            this.dgMenu.Size = new System.Drawing.Size(677, 302);
            this.dgMenu.TabIndex = 9;
            this.dgMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMenu_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(268, 117);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(238, 26);
            this.tbSearch.TabIndex = 8;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblRemoveItem2
            // 
            this.lblRemoveItem2.AutoSize = true;
            this.lblRemoveItem2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveItem2.Location = new System.Drawing.Point(315, 81);
            this.lblRemoveItem2.Name = "lblRemoveItem2";
            this.lblRemoveItem2.Size = new System.Drawing.Size(132, 24);
            this.lblRemoveItem2.TabIndex = 7;
            this.lblRemoveItem2.Text = "Remove Item";
            // 
            // lblRemoveItem
            // 
            this.lblRemoveItem.AutoSize = true;
            this.lblRemoveItem.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveItem.Location = new System.Drawing.Point(40, 22);
            this.lblRemoveItem.Name = "lblRemoveItem";
            this.lblRemoveItem.Size = new System.Drawing.Size(266, 46);
            this.lblRemoveItem.TabIndex = 6;
            this.lblRemoveItem.Text = "Remove Item";
            // 
            // UC_RemoveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTutorial);
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblRemoveItem2);
            this.Controls.Add(this.lblRemoveItem);
            this.Name = "UC_RemoveItems";
            this.Size = new System.Drawing.Size(765, 514);
            this.Load += new System.EventHandler(this.UC_RemoveItems_Load);
            this.Enter += new System.EventHandler(this.UC_RemoveItems_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.DataGridView dgMenu;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblRemoveItem2;
        private System.Windows.Forms.Label lblRemoveItem;
    }
}
