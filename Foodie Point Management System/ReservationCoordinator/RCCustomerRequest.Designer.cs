namespace Foodie_Point_Management_System.ReservationCoordinator
{
    partial class CustomerRequest
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReply = new System.Windows.Forms.Button();
            this.txtresID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DGVcusMSG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcusMSG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(6, 9);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(263, 34);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Customer Requests";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(177, 289);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(205, 29);
            this.txtName.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Message ID :";
            // 
            // txtResponse
            // 
            this.txtResponse.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.Location = new System.Drawing.Point(12, 421);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(687, 29);
            this.txtResponse.TabIndex = 39;
            this.txtResponse.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Response";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnReply
            // 
            this.btnReply.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReply.Location = new System.Drawing.Point(708, 416);
            this.btnReply.Margin = new System.Windows.Forms.Padding(2);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(112, 34);
            this.btnReply.TabIndex = 41;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // txtresID
            // 
            this.txtresID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresID.Location = new System.Drawing.Point(177, 337);
            this.txtresID.Name = "txtresID";
            this.txtresID.ReadOnly = true;
            this.txtresID.Size = new System.Drawing.Size(205, 29);
            this.txtresID.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "Reservation ID :";
            // 
            // DGVcusMSG
            // 
            this.DGVcusMSG.AllowUserToAddRows = false;
            this.DGVcusMSG.AllowUserToDeleteRows = false;
            this.DGVcusMSG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcusMSG.Location = new System.Drawing.Point(12, 71);
            this.DGVcusMSG.Name = "DGVcusMSG";
            this.DGVcusMSG.ReadOnly = true;
            this.DGVcusMSG.RowHeadersWidth = 51;
            this.DGVcusMSG.RowTemplate.Height = 24;
            this.DGVcusMSG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVcusMSG.Size = new System.Drawing.Size(808, 182);
            this.DGVcusMSG.TabIndex = 44;
            this.DGVcusMSG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcusMSG_CellClick);
            // 
            // CustomerRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 465);
            this.Controls.Add(this.DGVcusMSG);
            this.Controls.Add(this.txtresID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltitle);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerRequest";
            this.Text = "CustomerRequest";
            this.Load += new System.EventHandler(this.CustomerRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcusMSG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.TextBox txtresID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGVcusMSG;
    }
}