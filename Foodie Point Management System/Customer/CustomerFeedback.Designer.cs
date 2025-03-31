namespace Foodie_Point_Management_System.Customer
{
    partial class CustomerFeedback
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(321, 472);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 47);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(548, 472);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 47);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Feedback";
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(100, 183);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(794, 251);
            this.txtContent.TabIndex = 3;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // cbRating
            // 
            this.cbRating.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbRating.Location = new System.Drawing.Point(218, 130);
            this.cbRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(160, 33);
            this.cbRating.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rating:";
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
            // CustomerFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback Submission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExit;
    }
}