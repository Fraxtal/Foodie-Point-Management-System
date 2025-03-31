namespace Foodie_Point_Management_System.Customer
{
    partial class CustomerLogin
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtInputs = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblInputs = new System.Windows.Forms.Label();
            this.cbSPassword = new System.Windows.Forms.CheckBox();
            this.rbUsername = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(454, 251);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(226, 30);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Visible = false;
            // 
            // txtInputs
            // 
            this.txtInputs.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputs.Location = new System.Drawing.Point(454, 200);
            this.txtInputs.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputs.Name = "txtInputs";
            this.txtInputs.Size = new System.Drawing.Size(226, 30);
            this.txtInputs.TabIndex = 12;
            this.txtInputs.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(212)))), ((int)(((byte)(194)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(471, 346);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 46);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Enabled = false;
            this.lblPass.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(354, 254);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(89, 23);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Password:";
            // 
            // lblInputs
            // 
            this.lblInputs.AutoSize = true;
            this.lblInputs.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputs.Location = new System.Drawing.Point(354, 200);
            this.lblInputs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputs.Name = "lblInputs";
            this.lblInputs.Size = new System.Drawing.Size(232, 23);
            this.lblInputs.TabIndex = 8;
            this.lblInputs.Text = "Please Pick a Login Method";
            // 
            // cbSPassword
            // 
            this.cbSPassword.AutoSize = true;
            this.cbSPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSPassword.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSPassword.Location = new System.Drawing.Point(454, 301);
            this.cbSPassword.Margin = new System.Windows.Forms.Padding(4);
            this.cbSPassword.Name = "cbSPassword";
            this.cbSPassword.Size = new System.Drawing.Size(118, 21);
            this.cbSPassword.TabIndex = 17;
            this.cbSPassword.Text = "Show Password";
            this.cbSPassword.UseVisualStyleBackColor = true;
            this.cbSPassword.CheckedChanged += new System.EventHandler(this.cbSPassword_CheckedChanged);
            // 
            // rbUsername
            // 
            this.rbUsername.AutoSize = true;
            this.rbUsername.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsername.Location = new System.Drawing.Point(407, 147);
            this.rbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsername.Name = "rbUsername";
            this.rbUsername.Size = new System.Drawing.Size(113, 27);
            this.rbUsername.TabIndex = 16;
            this.rbUsername.Text = "Username";
            this.rbUsername.UseVisualStyleBackColor = true;
            this.rbUsername.CheckedChanged += new System.EventHandler(this.rbUsername_CheckedChanged);
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmail.Location = new System.Drawing.Point(602, 147);
            this.rbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(78, 27);
            this.rbEmail.TabIndex = 15;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            this.rbEmail.CheckedChanged += new System.EventHandler(this.rbEmail_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(60, 410);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(203, 28);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register Now";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(212)))), ((int)(((byte)(194)))));
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(682, 401);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(105, 46);
            this.btnEmployee.TabIndex = 17;
            this.btnEmployee.Text = "Employee Login";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(769, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 20);
            this.lblExit.TabIndex = 25;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(177)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 454);
            this.panel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Dont have an account?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 162);
            this.label4.TabIndex = 23;
            this.label4.Text = "🍵";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 40);
            this.label2.TabIndex = 21;
            this.label2.Text = "Foodie Point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "SIGN IN";
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.cbSPassword);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.lblInputs);
            this.Controls.Add(this.rbUsername);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.txtInputs);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.CustomerLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtInputs;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblInputs;
        private System.Windows.Forms.RadioButton rbUsername;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox cbSPassword;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}