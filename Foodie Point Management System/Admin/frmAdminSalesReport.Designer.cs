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
            this.rbPaymentMethod = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.srdw = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printPreview = new System.Windows.Forms.PrintDialog();
            this.printReport = new System.Drawing.Printing.PrintDocument();
            this.gbSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srdw)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPaymentMethod
            // 
            this.rbPaymentMethod.AutoSize = true;
            this.rbPaymentMethod.Location = new System.Drawing.Point(27, 128);
            this.rbPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPaymentMethod.Name = "rbPaymentMethod";
            this.rbPaymentMethod.Size = new System.Drawing.Size(105, 17);
            this.rbPaymentMethod.TabIndex = 2;
            this.rbPaymentMethod.Text = "Payment Method";
            this.rbPaymentMethod.UseVisualStyleBackColor = true;
            this.rbPaymentMethod.CheckedChanged += new System.EventHandler(this.rbPaymentMethod_CheckedChanged);
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Checked = true;
            this.rbMonthly.Location = new System.Drawing.Point(41, 46);
            this.rbMonthly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 3;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbMonthly_CheckedChanged);
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(41, 88);
            this.rbEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(71, 17);
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
            this.gbSortBy.Location = new System.Drawing.Point(21, 54);
            this.gbSortBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSortBy.Size = new System.Drawing.Size(144, 230);
            this.gbSortBy.TabIndex = 6;
            this.gbSortBy.TabStop = false;
            this.gbSortBy.Text = "Sort By :";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(29, 172);
            this.cbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(82, 21);
            this.cbYear.TabIndex = 8;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // srdw
            // 
            this.srdw.AllowUserToAddRows = false;
            this.srdw.AllowUserToDeleteRows = false;
            this.srdw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.srdw.Location = new System.Drawing.Point(193, 36);
            this.srdw.Name = "srdw";
            this.srdw.ReadOnly = true;
            this.srdw.RowHeadersWidth = 62;
            this.srdw.Size = new System.Drawing.Size(485, 248);
            this.srdw.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(433, 314);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 38);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(302, 314);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(98, 38);
            this.btnPreview.TabIndex = 15;
            this.btnPreview.Text = "Print Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(171, 314);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(93, 38);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printPreview
            // 
            this.printPreview.UseEXDialog = true;
            // 
            // printReport
            // 
            this.printReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReport_PrintPage);
            // 
            // frmAdminSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 383);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.srdw);
            this.Controls.Add(this.gbSortBy);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PrintDialog printPreview;
        private System.Drawing.Printing.PrintDocument printReport;
    }
}