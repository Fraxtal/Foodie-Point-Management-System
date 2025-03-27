namespace Foodie_Point_Management_System.Manager
{
    partial class ManagerHall
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbPartyType = new System.Windows.Forms.ComboBox();
            this.txtHallID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPax = new System.Windows.Forms.TextBox();
            this.lblPax = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.dataGridViewHalls = new System.Windows.Forms.DataGridView();
            this.lblHall = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHalls)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(-29, -28);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 84;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // cmbPartyType
            // 
            this.cmbPartyType.FormattingEnabled = true;
            this.cmbPartyType.Items.AddRange(new object[] {
            "Small Table",
            "Medium Table",
            "Large Table",
            "Joined Table",
            "Entire Hall"});
            this.cmbPartyType.Location = new System.Drawing.Point(229, 192);
            this.cmbPartyType.Name = "cmbPartyType";
            this.cmbPartyType.Size = new System.Drawing.Size(205, 24);
            this.cmbPartyType.TabIndex = 83;
            // 
            // txtHallID
            // 
            this.txtHallID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHallID.Location = new System.Drawing.Point(229, 74);
            this.txtHallID.Name = "txtHallID";
            this.txtHallID.Size = new System.Drawing.Size(205, 30);
            this.txtHallID.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "Hall ID :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(540, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 30);
            this.txtSearch.TabIndex = 79;
            // 
            // txtPax
            // 
            this.txtPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPax.Location = new System.Drawing.Point(229, 127);
            this.txtPax.Name = "txtPax";
            this.txtPax.Size = new System.Drawing.Size(205, 30);
            this.txtPax.TabIndex = 76;
            // 
            // lblPax
            // 
            this.lblPax.AutoSize = true;
            this.lblPax.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPax.Location = new System.Drawing.Point(99, 127);
            this.lblPax.Name = "lblPax";
            this.lblPax.Size = new System.Drawing.Size(60, 25);
            this.lblPax.TabIndex = 77;
            this.lblPax.Text = "Pax :";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(699, 275);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 37);
            this.btnEdit.TabIndex = 75;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(540, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 37);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(390, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 37);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(769, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 37);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(34, 188);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(125, 25);
            this.lbl.TabIndex = 71;
            this.lbl.Text = "Party Type :";
            // 
            // dataGridViewHalls
            // 
            this.dataGridViewHalls.AllowUserToAddRows = false;
            this.dataGridViewHalls.AllowUserToDeleteRows = false;
            this.dataGridViewHalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHalls.Location = new System.Drawing.Point(33, 352);
            this.dataGridViewHalls.Name = "dataGridViewHalls";
            this.dataGridViewHalls.ReadOnly = true;
            this.dataGridViewHalls.RowHeadersWidth = 51;
            this.dataGridViewHalls.RowTemplate.Height = 24;
            this.dataGridViewHalls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHalls.Size = new System.Drawing.Size(808, 182);
            this.dataGridViewHalls.TabIndex = 70;
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHall.Location = new System.Drawing.Point(28, 319);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(67, 30);
            this.lblHall.TabIndex = 69;
            this.lblHall.Text = "Hall";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 85;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cmbPartyType);
            this.Controls.Add(this.txtHallID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPax);
            this.Controls.Add(this.lblPax);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dataGridViewHalls);
            this.Controls.Add(this.lblHall);
            this.Name = "ManagerHall";
            this.Text = "ManagerHall";
            this.Load += new System.EventHandler(this.ManagerHall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbPartyType;
        private System.Windows.Forms.TextBox txtHallID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPax;
        private System.Windows.Forms.Label lblPax;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView dataGridViewHalls;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Button button1;
    }
}