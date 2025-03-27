namespace Foodie_Point_Management_System.Customer
{
    partial class CustomerReservationStatus
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
            this.btnBack = new System.Windows.Forms.Button();
            this.RStatusGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RStatusGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(361, 357);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RStatusGrid
            // 
            this.RStatusGrid.AllowUserToResizeColumns = false;
            this.RStatusGrid.AllowUserToResizeRows = false;
            this.RStatusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RStatusGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RStatusGrid.Location = new System.Drawing.Point(164, 85);
            this.RStatusGrid.Name = "RStatusGrid";
            this.RStatusGrid.Size = new System.Drawing.Size(493, 248);
            this.RStatusGrid.TabIndex = 1;
            this.RStatusGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RStatusGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservations";
            // 
            // CustomerReservationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RStatusGrid);
            this.Controls.Add(this.btnBack);
            this.Name = "CustomerReservationStatus";
            this.Text = "Reservation Status";
            this.Load += new System.EventHandler(this.CustomerReservationStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RStatusGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView RStatusGrid;
        private System.Windows.Forms.Label label1;
    }
}