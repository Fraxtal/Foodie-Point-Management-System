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
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRStatus
            // 
            this.btnRStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRStatus.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRStatus.Location = new System.Drawing.Point(556, 216);
            this.btnRStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRStatus.Name = "btnRStatus";
            this.btnRStatus.Size = new System.Drawing.Size(347, 188);
            this.btnRStatus.TabIndex = 0;
            this.btnRStatus.Text = "Reservation Status";
            this.btnRStatus.UseVisualStyleBackColor = true;
            this.btnRStatus.Click += new System.EventHandler(this.btnRStatus_Click);
            // 
            // btnRReservation
            // 
            this.btnRReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRReservation.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRReservation.Location = new System.Drawing.Point(116, 216);
            this.btnRReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRReservation.Name = "btnRReservation";
            this.btnRReservation.Size = new System.Drawing.Size(357, 188);
            this.btnRReservation.TabIndex = 1;
            this.btnRReservation.Text = "Request Reservation";
            this.btnRReservation.UseVisualStyleBackColor = true;
            this.btnRReservation.Click += new System.EventHandler(this.btnRReservation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservation";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(969, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 20);
            this.lblExit.TabIndex = 28;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // CustomerReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRReservation);
            this.Controls.Add(this.btnRStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Dashboard";
            this.Load += new System.EventHandler(this.CustomerReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRStatus;
        private System.Windows.Forms.Button btnRReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExit;
    }
}