namespace Foodie_Point_Management_System.Customer
{
    partial class CustomerReservationRequest
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPax = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pax: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "DateTime: ";
            // 
            // txtPax
            // 
            this.txtPax.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPax.Location = new System.Drawing.Point(440, 204);
            this.txtPax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPax.Name = "txtPax";
            this.txtPax.Size = new System.Drawing.Size(264, 36);
            this.txtPax.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(398, 432);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(186, 72);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reservation Request";
            // 
            // dtPicker
            // 
            this.dtPicker.Checked = false;
            this.dtPicker.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(440, 297);
            this.dtPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtPicker.MinDate = new System.DateTime(2025, 3, 7, 0, 0, 0, 0);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(265, 36);
            this.dtPicker.TabIndex = 10;
            this.dtPicker.Value = new System.DateTime(2025, 3, 15, 22, 48, 5, 0);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(969, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 20);
            this.lblExit.TabIndex = 31;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // CustomerReservationRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerReservationRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Request";
            this.Load += new System.EventHandler(this.CustomerReservationRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPax;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label lblExit;
    }
}