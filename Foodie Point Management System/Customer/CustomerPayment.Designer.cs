namespace Foodie_Point_Management_System.Customer
{
    partial class CustomerPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCCard
            // 
            this.btnCCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCard.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCard.Location = new System.Drawing.Point(291, 211);
            this.btnCCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCCard.Name = "btnCCard";
            this.btnCCard.Size = new System.Drawing.Size(183, 100);
            this.btnCCard.TabIndex = 1;
            this.btnCCard.Text = "Credit Card";
            this.btnCCard.UseVisualStyleBackColor = true;
            this.btnCCard.Click += new System.EventHandler(this.btnCCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(538, 211);
            this.btnCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(196, 100);
            this.btnCash.TabIndex = 2;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(479, 387);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(227, 36);
            this.txtTotal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total: ";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(969, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 20);
            this.lblExit.TabIndex = 30;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // CustomerPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnCCard);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerPayment";
            this.Load += new System.EventHandler(this.CustomerPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExit;
    }
}