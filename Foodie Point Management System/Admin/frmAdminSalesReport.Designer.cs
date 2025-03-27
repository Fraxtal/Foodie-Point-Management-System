namespace Foodie_Point_Management_System.Admin
{
    partial class frmAdminSalesReport
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
            this.rbPaymentMethod = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.srdw = new System.Windows.Forms.DataGridView();
            this.gbSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srdw)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPaymentMethod
            // 
            this.rbPaymentMethod.AutoSize = true;
            this.rbPaymentMethod.Location = new System.Drawing.Point(40, 197);
            this.rbPaymentMethod.Name = "rbPaymentMethod";
            this.rbPaymentMethod.Size = new System.Drawing.Size(154, 24);
            this.rbPaymentMethod.TabIndex = 2;
            this.rbPaymentMethod.Text = "Payment Method";
            this.rbPaymentMethod.UseVisualStyleBackColor = true;
            this.rbPaymentMethod.CheckedChanged += new System.EventHandler(this.rbPaymentMethod_CheckedChanged);
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Checked = true;
            this.rbMonthly.Location = new System.Drawing.Point(61, 71);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(89, 24);
            this.rbMonthly.TabIndex = 3;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbMonthly_CheckedChanged);
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(61, 136);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(104, 24);
            this.rbEmployee.TabIndex = 4;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            this.rbEmployee.CheckedChanged += new System.EventHandler(this.rbEmployee_CheckedChanged);
            // 
            // gbSortBy
            // 
            this.gbSortBy.Controls.Add(this.cbYear);
            this.gbSortBy.Controls.Add(this.rbMonthly);
            this.gbSortBy.Controls.Add(this.rbEmployee);
            this.gbSortBy.Controls.Add(this.rbPaymentMethod);
            this.gbSortBy.Location = new System.Drawing.Point(32, 83);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(216, 399);
            this.gbSortBy.TabIndex = 6;
            this.gbSortBy.TabStop = false;
            this.gbSortBy.Text = "Sort By :";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(44, 264);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 28);
            this.cbYear.TabIndex = 8;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // srdw
            // 
            this.srdw.AllowUserToAddRows = false;
            this.srdw.AllowUserToDeleteRows = false;
            this.srdw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.srdw.Location = new System.Drawing.Point(289, 56);
            this.srdw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.srdw.Name = "srdw";
            this.srdw.ReadOnly = true;
            this.srdw.RowHeadersWidth = 62;
            this.srdw.Size = new System.Drawing.Size(728, 462);
            this.srdw.TabIndex = 7;
            // 
            // frmAdminSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 589);
            this.Controls.Add(this.srdw);
            this.Controls.Add(this.gbSortBy);
            this.Name = "frmAdminSalesReport";
            this.Text = "frmAdminSalesReport";
            this.Load += new System.EventHandler(this.frmAdminSalesReport_Load);
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srdw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbPaymentMethod;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.DataGridView srdw;
        private System.Windows.Forms.ComboBox cbYear;
    }
}