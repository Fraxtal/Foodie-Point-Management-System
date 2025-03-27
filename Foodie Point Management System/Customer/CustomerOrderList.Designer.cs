namespace Foodie_Point_Management_System.Customer
{
    partial class CustomerOrderList
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOID = new System.Windows.Forms.TextBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.OrderListGrid = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Food:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // txtOID
            // 
            this.txtOID.Location = new System.Drawing.Point(126, 118);
            this.txtOID.Name = "txtOID";
            this.txtOID.ReadOnly = true;
            this.txtOID.Size = new System.Drawing.Size(100, 20);
            this.txtOID.TabIndex = 4;
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(126, 168);
            this.txtFood.Name = "txtFood";
            this.txtFood.ReadOnly = true;
            this.txtFood.Size = new System.Drawing.Size(100, 20);
            this.txtFood.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(126, 204);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(111, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // OrderListGrid
            // 
            this.OrderListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OrderListGrid.Location = new System.Drawing.Point(248, 87);
            this.OrderListGrid.MultiSelect = false;
            this.OrderListGrid.Name = "OrderListGrid";
            this.OrderListGrid.ReadOnly = true;
            this.OrderListGrid.Size = new System.Drawing.Size(492, 249);
            this.OrderListGrid.TabIndex = 8;
            this.OrderListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderListGrid_CellClick);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(287, 345);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(147, 51);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(27, 40);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Remarks: ";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(126, 238);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(100, 57);
            this.txtRemarks.TabIndex = 12;
            // 
            // CustomerOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.OrderListGrid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.txtOID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerOrderList";
            this.Text = "Customer Order List";
            this.Load += new System.EventHandler(this.CustomerOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOID;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView OrderListGrid;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
    }
}