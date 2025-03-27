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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
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
            this.dataGridViewReservations.Location = new System.Drawing.Point(41, 64);
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
            this.dataGridViewReservations.Size = new System.Drawing.Size(591, 262);
            this.dataGridViewReservations.TabIndex = 1;

            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(302, 353);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(56, 19);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnLoadReports_Click);
            // 
            // ManagerReservationsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 399);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerReservationsReport";
            this.Text = "ManagerReservationsReport";
            this.Load += new System.EventHandler(this.ManagerReservationsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.Button btnView;
    }
}