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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method";
            // 
            // btnCCard
            // 
            this.btnCCard.Location = new System.Drawing.Point(178, 183);
            this.btnCCard.Name = "btnCCard";
            this.btnCCard.Size = new System.Drawing.Size(117, 56);
            this.btnCCard.TabIndex = 1;
            this.btnCCard.Text = "Credit Card";
            this.btnCCard.UseVisualStyleBackColor = true;
            this.btnCCard.Click += new System.EventHandler(this.btnCCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(363, 183);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(127, 56);
            this.btnCash.TabIndex = 2;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(264, 316);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(151, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total: ";
            // 
            // CustomerPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnCCard);
            this.Controls.Add(this.label1);
            this.Name = "CustomerPayment";
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
    }
}