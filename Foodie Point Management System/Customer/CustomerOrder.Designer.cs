namespace Foodie_Point_Management_System.Customer
{
    partial class CustomerOrder
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
            this.btnOrderList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbIn = new System.Windows.Forms.RadioButton();
            this.rbMalay = new System.Windows.Forms.RadioButton();
            this.rbChi = new System.Windows.Forms.RadioButton();
            this.OrderMenuGrid = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.Label();
            this.rbBeverage = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderMenuGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(474, 338);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(88, 40);
            this.btnOrderList.TabIndex = 0;
            this.btnOrderList.Text = "Proceed To View Order List";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBeverage);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.rbIn);
            this.groupBox1.Controls.Add(this.rbMalay);
            this.groupBox1.Controls.Add(this.rbChi);
            this.groupBox1.Location = new System.Drawing.Point(65, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(36, 167);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Filter";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbIn
            // 
            this.rbIn.AutoSize = true;
            this.rbIn.Location = new System.Drawing.Point(20, 100);
            this.rbIn.Name = "rbIn";
            this.rbIn.Size = new System.Drawing.Size(91, 17);
            this.rbIn.TabIndex = 2;
            this.rbIn.TabStop = true;
            this.rbIn.Text = "Indian Cuisine";
            this.rbIn.UseVisualStyleBackColor = true;
            this.rbIn.CheckedChanged += new System.EventHandler(this.rbIn_CheckedChanged);
            // 
            // rbMalay
            // 
            this.rbMalay.AutoSize = true;
            this.rbMalay.Location = new System.Drawing.Point(21, 66);
            this.rbMalay.Name = "rbMalay";
            this.rbMalay.Size = new System.Drawing.Size(90, 17);
            this.rbMalay.TabIndex = 1;
            this.rbMalay.TabStop = true;
            this.rbMalay.Text = "Malay Cuisine";
            this.rbMalay.UseVisualStyleBackColor = true;
            this.rbMalay.CheckedChanged += new System.EventHandler(this.rbMalay_CheckedChanged);
            // 
            // rbChi
            // 
            this.rbChi.AutoSize = true;
            this.rbChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbChi.Location = new System.Drawing.Point(21, 33);
            this.rbChi.Name = "rbChi";
            this.rbChi.Size = new System.Drawing.Size(100, 17);
            this.rbChi.TabIndex = 0;
            this.rbChi.TabStop = true;
            this.rbChi.Text = "Chinese Cuisine";
            this.rbChi.UseVisualStyleBackColor = true;
            this.rbChi.CheckedChanged += new System.EventHandler(this.rbChi_CheckedChanged);
            // 
            // OrderMenuGrid
            // 
            this.OrderMenuGrid.AllowUserToAddRows = false;
            this.OrderMenuGrid.AllowUserToDeleteRows = false;
            this.OrderMenuGrid.AllowUserToResizeColumns = false;
            this.OrderMenuGrid.AllowUserToResizeRows = false;
            this.OrderMenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderMenuGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OrderMenuGrid.Location = new System.Drawing.Point(224, 87);
            this.OrderMenuGrid.MultiSelect = false;
            this.OrderMenuGrid.Name = "OrderMenuGrid";
            this.OrderMenuGrid.ReadOnly = true;
            this.OrderMenuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderMenuGrid.Size = new System.Drawing.Size(443, 192);
            this.OrderMenuGrid.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(269, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(224, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(133, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 312);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "1";
            this.textBox1.WordWrap = false;
            // 
            // txtQuant
            // 
            this.txtQuant.AutoSize = true;
            this.txtQuant.Location = new System.Drawing.Point(199, 315);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(52, 13);
            this.txtQuant.TabIndex = 7;
            this.txtQuant.Text = "Quantity: ";
            // 
            // rbBeverage
            // 
            this.rbBeverage.AutoSize = true;
            this.rbBeverage.Location = new System.Drawing.Point(20, 132);
            this.rbBeverage.Name = "rbBeverage";
            this.rbBeverage.Size = new System.Drawing.Size(76, 17);
            this.rbBeverage.TabIndex = 8;
            this.rbBeverage.TabStop = true;
            this.rbBeverage.Text = "Beverages";
            this.rbBeverage.UseVisualStyleBackColor = true;
            this.rbBeverage.CheckedChanged += new System.EventHandler(this.rbBeverage_CheckedChanged);
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.OrderMenuGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrderList);
            this.Name = "CustomerOrder";
            this.Text = "Order Menu";
            this.Load += new System.EventHandler(this.CustomerOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderMenuGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView OrderMenuGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbIn;
        private System.Windows.Forms.RadioButton rbMalay;
        private System.Windows.Forms.RadioButton rbChi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtQuant;
        private System.Windows.Forms.RadioButton rbBeverage;
    }
}