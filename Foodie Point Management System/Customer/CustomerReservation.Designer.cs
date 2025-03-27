namespace Foodie_Point_Management_System.Customer
{
    partial class CustomerReservation
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
            this.btnRStatus = new System.Windows.Forms.Button();
            this.btnRReservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRStatus
            // 
            this.btnRStatus.Location = new System.Drawing.Point(449, 156);
            this.btnRStatus.Name = "btnRStatus";
            this.btnRStatus.Size = new System.Drawing.Size(260, 153);
            this.btnRStatus.TabIndex = 0;
            this.btnRStatus.Text = "Reservation Status";
            this.btnRStatus.UseVisualStyleBackColor = true;
            this.btnRStatus.Click += new System.EventHandler(this.btnRStatus_Click);
            // 
            // btnRReservation
            // 
            this.btnRReservation.Location = new System.Drawing.Point(119, 156);
            this.btnRReservation.Name = "btnRReservation";
            this.btnRReservation.Size = new System.Drawing.Size(268, 153);
            this.btnRReservation.TabIndex = 1;
            this.btnRReservation.Text = "Request Reservation";
            this.btnRReservation.UseVisualStyleBackColor = true;
            this.btnRReservation.Click += new System.EventHandler(this.btnRReservation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservation";
            // 
            // CustomerReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRReservation);
            this.Controls.Add(this.btnRStatus);
            this.Name = "CustomerReservation";
            this.Text = "Reservation Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRStatus;
        private System.Windows.Forms.Button btnRReservation;
        private System.Windows.Forms.Label label1;
    }
}