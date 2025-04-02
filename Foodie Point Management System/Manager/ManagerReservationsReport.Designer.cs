namespace Foodie_Point_Management_System.Manager
{
    partial class ManagerReservationsReport
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
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.cbPType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnReserD = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.gbSortBy.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(574, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.AllowUserToAddRows = false;
            this.dataGridViewReservations.AllowUserToDeleteRows = false;
            this.dataGridViewReservations.AllowUserToResizeColumns = false;
            this.dataGridViewReservations.AllowUserToResizeRows = false;
            this.dataGridViewReservations.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewReservations.Location = new System.Drawing.Point(566, 110);
            this.dataGridViewReservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReservations.MultiSelect = false;
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.ReadOnly = true;
            this.dataGridViewReservations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewReservations.RowTemplate.Height = 24;
            this.dataGridViewReservations.ShowCellErrors = false;
            this.dataGridViewReservations.ShowCellToolTips = false;
            this.dataGridViewReservations.ShowEditingIcon = false;
            this.dataGridViewReservations.ShowRowErrors = false;
            this.dataGridViewReservations.Size = new System.Drawing.Size(520, 588);
            this.dataGridViewReservations.TabIndex = 1;
            // 
            // gbSortBy
            // 
            this.gbSortBy.Controls.Add(this.cbPType);
            this.gbSortBy.Controls.Add(this.label3);
            this.gbSortBy.Controls.Add(this.btnReset);
            this.gbSortBy.Controls.Add(this.label2);
            this.gbSortBy.Controls.Add(this.cbYear);
            this.gbSortBy.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbSortBy.Location = new System.Drawing.Point(318, 110);
            this.gbSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSortBy.Size = new System.Drawing.Size(241, 346);
            this.gbSortBy.TabIndex = 7;
            this.gbSortBy.TabStop = false;
            this.gbSortBy.Text = "Sort By :";
            this.gbSortBy.Enter += new System.EventHandler(this.gbSortBy_Enter);
            // 
            // cbPType
            // 
            this.cbPType.FormattingEnabled = true;
            this.cbPType.Location = new System.Drawing.Point(27, 194);
            this.cbPType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPType.Name = "cbPType";
            this.cbPType.Size = new System.Drawing.Size(178, 33);
            this.cbPType.TabIndex = 4;
            this.cbPType.SelectedIndexChanged += new System.EventHandler(this.cbPType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Party Type:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(212)))), ((int)(((byte)(194)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(63, 269);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 46);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Filter";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year:";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(27, 89);
            this.cbYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(178, 33);
            this.cbYear.TabIndex = 0;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(345, 639);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(179, 59);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(177)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnReserD);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnSalesReportD);
            this.panel1.Controls.Add(this.btnHallsD);
            this.panel1.Controls.Add(this.btnMenuD);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 750);
            this.panel1.TabIndex = 28;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.pnlNav.Location = new System.Drawing.Point(1, 218);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(6, 125);
            this.pnlNav.TabIndex = 33;
            // 
            // btnReserD
            // 
            this.btnReserD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReserD.Location = new System.Drawing.Point(0, 485);
            this.btnReserD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReserD.Name = "btnReserD";
            this.btnReserD.Size = new System.Drawing.Size(287, 68);
            this.btnReserD.TabIndex = 34;
            this.btnReserD.Text = "Reservation Report";
            this.btnReserD.UseVisualStyleBackColor = true;
            this.btnReserD.Click += new System.EventHandler(this.btnReserD_Click);
            // 
            // btnDash
            // 
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDash.Location = new System.Drawing.Point(0, 215);
            this.btnDash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(287, 68);
            this.btnDash.TabIndex = 32;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(0, 682);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(287, 68);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Log Out";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSettings.Location = new System.Drawing.Point(0, 550);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(287, 68);
            this.btnSettings.TabIndex = 31;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSalesReportD
            // 
            this.btnSalesReportD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReportD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReportD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalesReportD.Location = new System.Drawing.Point(0, 418);
            this.btnSalesReportD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalesReportD.Name = "btnSalesReportD";
            this.btnSalesReportD.Size = new System.Drawing.Size(287, 68);
            this.btnSalesReportD.TabIndex = 30;
            this.btnSalesReportD.Text = "Sales Report";
            this.btnSalesReportD.UseVisualStyleBackColor = true;
            this.btnSalesReportD.Click += new System.EventHandler(this.btnSalesReportD_Click);
            // 
            // btnHallsD
            // 
            this.btnHallsD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHallsD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHallsD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHallsD.Location = new System.Drawing.Point(0, 350);
            this.btnHallsD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHallsD.Name = "btnHallsD";
            this.btnHallsD.Size = new System.Drawing.Size(287, 68);
            this.btnHallsD.TabIndex = 29;
            this.btnHallsD.Text = "Halls";
            this.btnHallsD.UseVisualStyleBackColor = true;
            this.btnHallsD.Click += new System.EventHandler(this.btnHallsD_Click);
            // 
            // btnMenuD
            // 
            this.btnMenuD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenuD.Location = new System.Drawing.Point(0, 282);
            this.btnMenuD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenuD.Name = "btnMenuD";
            this.btnMenuD.Size = new System.Drawing.Size(287, 68);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 215);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(29, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Management System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(72, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 32);
            this.label5.TabIndex = 35;
            this.label5.Text = "Foodie Point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(71, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 108);
            this.label6.TabIndex = 34;
            this.label6.Text = "🍵";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(1090, 11);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 24);
            this.lblExit.TabIndex = 71;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // ManagerReservationsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1125, 750);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbSortBy);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerReservationsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerReservationsReport";
            this.Load += new System.EventHandler(this.ManagerReservationsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbPType;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}