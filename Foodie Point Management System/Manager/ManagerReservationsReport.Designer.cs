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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerReservationsReport));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.printReport = new System.Drawing.Printing.PrintDocument();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.gbSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Report";
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
            this.dataGridViewReservations.Location = new System.Drawing.Point(184, 64);
            this.dataGridViewReservations.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewReservations.MultiSelect = false;
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.ReadOnly = true;
            this.dataGridViewReservations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewReservations.RowTemplate.Height = 24;
            this.dataGridViewReservations.ShowCellErrors = false;
            this.dataGridViewReservations.ShowCellToolTips = false;
            this.dataGridViewReservations.ShowEditingIcon = false;
            this.dataGridViewReservations.ShowRowErrors = false;
            this.dataGridViewReservations.Size = new System.Drawing.Size(448, 262);
            this.dataGridViewReservations.TabIndex = 1;
            // 
            // gbSortBy
            // 
            this.gbSortBy.Controls.Add(this.cbPType);
            this.gbSortBy.Controls.Add(this.label3);
            this.gbSortBy.Controls.Add(this.btnReset);
            this.gbSortBy.Controls.Add(this.label2);
            this.gbSortBy.Controls.Add(this.cbYear);
            this.gbSortBy.Location = new System.Drawing.Point(24, 64);
            this.gbSortBy.Margin = new System.Windows.Forms.Padding(2);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Padding = new System.Windows.Forms.Padding(2);
            this.gbSortBy.Size = new System.Drawing.Size(144, 170);
            this.gbSortBy.TabIndex = 7;
            this.gbSortBy.TabStop = false;
            this.gbSortBy.Text = "Sort By :";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(18, 44);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(109, 21);
            this.cbYear.TabIndex = 0;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // printReport
            // 
            this.printReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReport_PrintPage);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(163, 349);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(93, 38);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(294, 349);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(98, 38);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Print Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(425, 349);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 38);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(30, 142);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Filter";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Party Type:";
            // 
            // cbPType
            // 
            this.cbPType.FormattingEnabled = true;
            this.cbPType.Location = new System.Drawing.Point(18, 97);
            this.cbPType.Name = "cbPType";
            this.cbPType.Size = new System.Drawing.Size(109, 21);
            this.cbPType.TabIndex = 4;
            this.cbPType.SelectedIndexChanged += new System.EventHandler(this.cbPType_SelectedIndexChanged);
            // 
            // ManagerReservationsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 399);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbSortBy);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerReservationsReport";
            this.Text = "ManagerReservationsReport";
            this.Load += new System.EventHandler(this.ManagerReservationsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Drawing.Printing.PrintDocument printReport;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbPType;
        private System.Windows.Forms.Label label3;
    }
}