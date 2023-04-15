namespace Oracle_FinalProj
{
    partial class form_ProfileAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_backMenu = new System.Windows.Forms.Button();
            this.btn_updateProf = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtBox_passwordAgain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBox_newPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBox_usernameDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBox_usernameID = new System.Windows.Forms.TextBox();
            this.Label_Username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_backMenu);
            this.panel1.Controls.Add(this.btn_updateProf);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 319);
            this.panel1.TabIndex = 0;
            // 
            // btn_backMenu
            // 
            this.btn_backMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_backMenu.Location = new System.Drawing.Point(419, 258);
            this.btn_backMenu.Name = "btn_backMenu";
            this.btn_backMenu.Size = new System.Drawing.Size(112, 33);
            this.btn_backMenu.TabIndex = 6;
            this.btn_backMenu.TabStop = false;
            this.btn_backMenu.Text = "Quay lại";
            this.btn_backMenu.UseVisualStyleBackColor = true;
            // 
            // btn_updateProf
            // 
            this.btn_updateProf.Enabled = false;
            this.btn_updateProf.Location = new System.Drawing.Point(283, 258);
            this.btn_updateProf.Name = "btn_updateProf";
            this.btn_updateProf.Size = new System.Drawing.Size(112, 33);
            this.btn_updateProf.TabIndex = 5;
            this.btn_updateProf.TabStop = false;
            this.btn_updateProf.Text = "Cập nhật";
            this.btn_updateProf.UseVisualStyleBackColor = true;
            this.btn_updateProf.Click += new System.EventHandler(this.btn_updateProf_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtBox_passwordAgain);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(554, 45);
            this.panel6.TabIndex = 5;
            // 
            // txtBox_passwordAgain
            // 
            this.txtBox_passwordAgain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_passwordAgain.Location = new System.Drawing.Point(150, 12);
            this.txtBox_passwordAgain.Name = "txtBox_passwordAgain";
            this.txtBox_passwordAgain.Size = new System.Drawing.Size(378, 25);
            this.txtBox_passwordAgain.TabIndex = 4;
            this.txtBox_passwordAgain.UseSystemPasswordChar = true;
            this.txtBox_passwordAgain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_passwordAgain_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtBox_newPassword);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 156);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(554, 45);
            this.panel5.TabIndex = 4;
            // 
            // txtBox_newPassword
            // 
            this.txtBox_newPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_newPassword.Location = new System.Drawing.Point(150, 12);
            this.txtBox_newPassword.Name = "txtBox_newPassword";
            this.txtBox_newPassword.Size = new System.Drawing.Size(378, 25);
            this.txtBox_newPassword.TabIndex = 3;
            this.txtBox_newPassword.UseSystemPasswordChar = true;
            this.txtBox_newPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_newPassword_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu mới:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtBox_password);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(554, 45);
            this.panel4.TabIndex = 3;
            // 
            // txtBox_password
            // 
            this.txtBox_password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_password.Location = new System.Drawing.Point(150, 12);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(378, 25);
            this.txtBox_password.TabIndex = 2;
            this.txtBox_password.UseSystemPasswordChar = true;
            this.txtBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_password_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBox_usernameDisplay);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 45);
            this.panel3.TabIndex = 2;
            // 
            // txtBox_usernameDisplay
            // 
            this.txtBox_usernameDisplay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_usernameDisplay.Location = new System.Drawing.Point(150, 12);
            this.txtBox_usernameDisplay.Name = "txtBox_usernameDisplay";
            this.txtBox_usernameDisplay.Size = new System.Drawing.Size(378, 25);
            this.txtBox_usernameDisplay.TabIndex = 1;
            this.txtBox_usernameDisplay.TextChanged += new System.EventHandler(this.txtBox_usernameDisplay_TextChanged);
            this.txtBox_usernameDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_usernameDisplay_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hiển thị:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBox_usernameID);
            this.panel2.Controls.Add(this.Label_Username);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 45);
            this.panel2.TabIndex = 1;
            // 
            // txtBox_usernameID
            // 
            this.txtBox_usernameID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_usernameID.Location = new System.Drawing.Point(150, 12);
            this.txtBox_usernameID.Name = "txtBox_usernameID";
            this.txtBox_usernameID.ReadOnly = true;
            this.txtBox_usernameID.Size = new System.Drawing.Size(378, 25);
            this.txtBox_usernameID.TabIndex = 0;
            this.txtBox_usernameID.TabStop = false;
            this.txtBox_usernameID.TextChanged += new System.EventHandler(this.txtBox_Username_TextChanged);
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.Location = new System.Drawing.Point(10, 15);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(118, 18);
            this.Label_Username.TabIndex = 0;
            this.Label_Username.Text = "Tên đăng nhập:";
            this.Label_Username.Click += new System.EventHandler(this.Label_Username_Click);
            // 
            // form_ProfileAccount
            // 
            this.AcceptButton = this.btn_updateProf;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_backMenu;
            this.ClientSize = new System.Drawing.Size(584, 344);
            this.Controls.Add(this.panel1);
            this.Name = "form_ProfileAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.form_ProfileAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBox_usernameID;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtBox_passwordAgain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBox_newPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBox_usernameDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_backMenu;
        private System.Windows.Forms.Button btn_updateProf;
    }
}