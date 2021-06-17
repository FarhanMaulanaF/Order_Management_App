
namespace ProyekUAS2021
{
    partial class Form_Dasboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.linkLogOut = new System.Windows.Forms.LinkLabel();
            this.pl_Navigation = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnUpdateItems = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.pl_View = new System.Windows.Forms.Panel();
            this.guna2Connector = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_UpdateItem1 = new ProyekUAS2021.Control_User.UC_UpdateItem();
            this.uC_PlaceOrder1 = new ProyekUAS2021.Control_User.UC_PlaceOrder();
            this.uC_AddItems1 = new ProyekUAS2021.Control_User.UC_AddItems();
            this.uC_Welcome1 = new ProyekUAS2021.Control_User.UC_Welcome();
            this.uC_RemoveItems1 = new ProyekUAS2021.Control_User.UC_RemoveItems();
            this.pl_Navigation.SuspendLayout();
            this.pl_View.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLogOut
            // 
            this.linkLogOut.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLogOut.AutoSize = true;
            this.linkLogOut.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLogOut.LinkColor = System.Drawing.Color.Red;
            this.linkLogOut.Location = new System.Drawing.Point(59, 480);
            this.linkLogOut.Name = "linkLogOut";
            this.linkLogOut.Size = new System.Drawing.Size(81, 24);
            this.linkLogOut.TabIndex = 4;
            this.linkLogOut.TabStop = true;
            this.linkLogOut.Text = "LogOut";
            this.linkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogOut_LinkClicked);
            // 
            // pl_Navigation
            // 
            this.pl_Navigation.BackColor = System.Drawing.Color.Gold;
            this.pl_Navigation.Controls.Add(this.linkLogOut);
            this.pl_Navigation.Controls.Add(this.btnExit);
            this.pl_Navigation.Controls.Add(this.btnRemoveItems);
            this.pl_Navigation.Controls.Add(this.btnUpdateItems);
            this.pl_Navigation.Controls.Add(this.btnAddItems);
            this.pl_Navigation.Controls.Add(this.btnPlaceOrder);
            this.pl_Navigation.Location = new System.Drawing.Point(9, 12);
            this.pl_Navigation.Name = "pl_Navigation";
            this.pl_Navigation.Size = new System.Drawing.Size(200, 514);
            this.pl_Navigation.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(10, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BackColor = System.Drawing.Color.Gold;
            this.btnRemoveItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveItems.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItems.Location = new System.Drawing.Point(10, 254);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(181, 41);
            this.btnRemoveItems.TabIndex = 3;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.UseVisualStyleBackColor = false;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.BackColor = System.Drawing.Color.Gold;
            this.btnUpdateItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateItems.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItems.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItems.Location = new System.Drawing.Point(10, 188);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.Size = new System.Drawing.Size(181, 41);
            this.btnUpdateItems.TabIndex = 2;
            this.btnUpdateItems.Text = "Update Items";
            this.btnUpdateItems.UseVisualStyleBackColor = false;
            this.btnUpdateItems.Click += new System.EventHandler(this.btnUpdateItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.Gold;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItems.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Location = new System.Drawing.Point(10, 122);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(181, 41);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Gold;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(10, 59);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(181, 41);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // pl_View
            // 
            this.pl_View.BackColor = System.Drawing.Color.White;
            this.pl_View.Controls.Add(this.uC_RemoveItems1);
            this.pl_View.Controls.Add(this.uC_UpdateItem1);
            this.pl_View.Controls.Add(this.uC_PlaceOrder1);
            this.pl_View.Controls.Add(this.uC_AddItems1);
            this.pl_View.Controls.Add(this.uC_Welcome1);
            this.pl_View.Location = new System.Drawing.Point(227, 12);
            this.pl_View.Name = "pl_View";
            this.pl_View.Size = new System.Drawing.Size(765, 514);
            this.pl_View.TabIndex = 3;
            // 
            // guna2Connector
            // 
            this.guna2Connector.BorderRadius = 0;
            this.guna2Connector.TargetControl = this.pl_View;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this.pl_View;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 0;
            this.guna2Elipse2.TargetControl = this.pl_View;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 0;
            this.guna2Elipse3.TargetControl = this.pl_View;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 0;
            this.guna2Elipse4.TargetControl = this.pl_View;
            // 
            // uC_UpdateItem1
            // 
            this.uC_UpdateItem1.BackColor = System.Drawing.Color.White;
            this.uC_UpdateItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItem1.Name = "uC_UpdateItem1";
            this.uC_UpdateItem1.Size = new System.Drawing.Size(765, 514);
            this.uC_UpdateItem1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(765, 514);
            this.uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_AddItems1
            // 
            this.uC_AddItems1.BackColor = System.Drawing.Color.White;
            this.uC_AddItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddItems1.Name = "uC_AddItems1";
            this.uC_AddItems1.Size = new System.Drawing.Size(765, 514);
            this.uC_AddItems1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.uC_Welcome1.Location = new System.Drawing.Point(0, 0);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(765, 514);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // uC_RemoveItems1
            // 
            this.uC_RemoveItems1.BackColor = System.Drawing.Color.White;
            this.uC_RemoveItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_RemoveItems1.Name = "uC_RemoveItems1";
            this.uC_RemoveItems1.Size = new System.Drawing.Size(765, 514);
            this.uC_RemoveItems1.TabIndex = 4;
            // 
            // Form_Dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.pl_View);
            this.Controls.Add(this.pl_Navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dasboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form_Dasboard_Load);
            this.pl_Navigation.ResumeLayout(false);
            this.pl_Navigation.PerformLayout();
            this.pl_View.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLogOut;
        private System.Windows.Forms.Panel pl_Navigation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnUpdateItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Panel pl_View;
        private Guna.UI2.WinForms.Guna2Elipse guna2Connector;
        private Control_User.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Control_User.UC_AddItems uC_AddItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Control_User.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Control_User.UC_UpdateItem uC_UpdateItem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Control_User.UC_RemoveItems uC_RemoveItems1;
    }
}