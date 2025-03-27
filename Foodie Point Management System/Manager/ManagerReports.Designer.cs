namespace Foodie_Point_Management_System.Manager
{
    partial class ManagerReports
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
            this.btnsales = new System.Windows.Forms.Button();
            this.btnreservations = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsales
            // 
            this.btnsales.Location = new System.Drawing.Point(273, 120);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(245, 77);
            this.btnsales.TabIndex = 0;
            this.btnsales.Text = "Sales Reports";
            this.btnsales.UseVisualStyleBackColor = true;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnreservations
            // 
            this.btnreservations.Location = new System.Drawing.Point(273, 242);
            this.btnreservations.Name = "btnreservations";
            this.btnreservations.Size = new System.Drawing.Size(245, 77);
            this.btnreservations.TabIndex = 1;
            this.btnreservations.Text = "Reservation Reports";
            this.btnreservations.UseVisualStyleBackColor = true;
            this.btnreservations.Click += new System.EventHandler(this.btnreservations_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 69;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ManagerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnreservations);
            this.Controls.Add(this.btnsales);
            this.Name = "ManagerReports";
            this.Text = "ManagerReports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btnreservations;
        private System.Windows.Forms.Button btnReturn;
    }
}