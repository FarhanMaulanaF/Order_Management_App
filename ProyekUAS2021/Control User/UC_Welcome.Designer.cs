
namespace ProyekUAS2021.Control_User
{
    partial class UC_Welcome
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
            this.lblNiceDays = new System.Windows.Forms.Label();
            this.guna2Connector = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // lblNiceDays
            // 
            this.lblNiceDays.AutoSize = true;
            this.lblNiceDays.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiceDays.Location = new System.Drawing.Point(124, 204);
            this.lblNiceDays.Name = "lblNiceDays";
            this.lblNiceDays.Size = new System.Drawing.Size(523, 70);
            this.lblNiceDays.TabIndex = 1;
            this.lblNiceDays.Text = "Have a Nice Days";
            // 
            // guna2Connector
            // 
            this.guna2Connector.BorderRadius = 0;
            this.guna2Connector.TargetControl = this;
            // 
            // UC_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNiceDays);
            this.Name = "UC_Welcome";
            this.Size = new System.Drawing.Size(765, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNiceDays;
        private Guna.UI2.WinForms.Guna2Elipse guna2Connector;
    }
}
