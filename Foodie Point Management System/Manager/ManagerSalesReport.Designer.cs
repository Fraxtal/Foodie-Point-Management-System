namespace Foodie_Point_Management_System.Manager
{
    partial class ManagerSalesReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReserD = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSalesReportD = new System.Windows.Forms.Button();
            this.btnHallsD = new System.Windows.Forms.Button();
            this.btnMenuD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srdw)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbPaymentMethod
            // 
            this.rbPaymentMethod.AutoSize = true;
            this.rbPaymentMethod.Location = new System.Drawing.Point(36, 158);
            this.rbPaymentMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPaymentMethod.Name = "rbPaymentMethod";
            this.rbPaymentMethod.Size = new System.Drawing.Size(168, 26);
            this.rbPaymentMethod.TabIndex = 2;
            this.rbPaymentMethod.Text = "Payment Method";
            this.rbPaymentMethod.UseVisualStyleBackColor = true;
            this.rbPaymentMethod.CheckedChanged += new System.EventHandler(this.rbPaymentMethod_CheckedChanged);
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Checked = true;
            this.rbMonthly.Location = new System.Drawing.Point(36, 53);
            this.rbMonthly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(100, 26);
            this.rbMonthly.TabIndex = 3;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbMonthly_CheckedChanged);
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(36, 106);
            this.rbEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(110, 26);
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
            this.gbSortBy.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSortBy.Location = new System.Drawing.Point(278, 83);
            this.gbSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSortBy.Size = new System.Drawing.Size(215, 295);
            this.gbSortBy.TabIndex = 6;
            this.gbSortBy.TabStop = false;
            this.gbSortBy.Text = "Sort By :";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(39, 212);
            this.cbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(165, 30);
            this.cbYear.TabIndex = 8;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // srdw
            // 
            this.srdw.AllowUserToAddRows = false;
            this.srdw.AllowUserToDeleteRows = false;
            this.srdw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.srdw.Location = new System.Drawing.Point(518, 45);
            this.srdw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.srdw.Name = "srdw";
            this.srdw.ReadOnly = true;
            this.srdw.RowHeadersWidth = 62;
            this.srdw.Size = new System.Drawing.Size(453, 500);
            this.srdw.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(323, 416);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(159, 47);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(177)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.btnReserD);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnSalesReportD);
            this.panel1.Controls.Add(this.btnHallsD);
            this.panel1.Controls.Add(this.btnMenuD);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 600);
            this.panel1.TabIndex = 29;
            // 
            // btnReserD
            // 
            this.btnReserD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserD.Location = new System.Drawing.Point(0, 388);
            this.btnReserD.Name = "btnReserD";
            this.btnReserD.Size = new System.Drawing.Size(255, 54);
            this.btnReserD.TabIndex = 34;
            this.btnReserD.Text = "Reservation Report";
            this.btnReserD.UseVisualStyleBackColor = true;
            this.btnReserD.Click += new System.EventHandler(this.btnReserD_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.pnlNav.Location = new System.Drawing.Point(1, 174);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 100);
            this.pnlNav.TabIndex = 33;
            // 
            // btnDash
            // 
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.Location = new System.Drawing.Point(0, 172);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(255, 54);
            this.btnDash.TabIndex = 32;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 546);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(255, 54);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Log Out";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(0, 440);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(255, 54);
            this.btnSettings.TabIndex = 31;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSalesReportD
            // 
            this.btnSalesReportD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReportD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReportD.Location = new System.Drawing.Point(0, 334);
            this.btnSalesReportD.Name = "btnSalesReportD";
            this.btnSalesReportD.Size = new System.Drawing.Size(255, 54);
            this.btnSalesReportD.TabIndex = 30;
            this.btnSalesReportD.Text = "Sales Report";
            this.btnSalesReportD.UseVisualStyleBackColor = true;
            this.btnSalesReportD.Click += new System.EventHandler(this.btnSalesReportD_Click);
            // 
            // btnHallsD
            // 
            this.btnHallsD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHallsD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHallsD.Location = new System.Drawing.Point(0, 280);
            this.btnHallsD.Name = "btnHallsD";
            this.btnHallsD.Size = new System.Drawing.Size(255, 54);
            this.btnHallsD.TabIndex = 29;
            this.btnHallsD.Text = "Halls";
            this.btnHallsD.UseVisualStyleBackColor = true;
            this.btnHallsD.Click += new System.EventHandler(this.btnHallsD_Click);
            // 
            // btnMenuD
            // 
            this.btnMenuD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuD.Location = new System.Drawing.Point(0, 226);
            this.btnMenuD.Name = "btnMenuD";
            this.btnMenuD.Size = new System.Drawing.Size(255, 54);
            this.btnMenuD.TabIndex = 28;
            this.btnMenuD.Text = "Menu";
            this.btnMenuD.UseVisualStyleBackColor = true;
            this.btnMenuD.Click += new System.EventHandler(this.btnMenuD_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 172);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Management System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Foodie Point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 91);
            this.label6.TabIndex = 0;
            this.label6.Text = "🍵";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(969, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 20);
            this.lblExit.TabIndex = 72;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Sales Report";
            // 
            // ManagerSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.srdw);
            this.Controls.Add(this.gbSortBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Sales Report";
            this.Load += new System.EventHandler(this.frmAdminSalesReport_Load);
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srdw)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbPaymentMethod;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.DataGridView srdw;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReserD;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSalesReportD;
        private System.Windows.Forms.Button btnHallsD;
        private System.Windows.Forms.Button btnMenuD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label1;
    }
}