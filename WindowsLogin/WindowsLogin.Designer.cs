namespace WindowsLogin
{
    partial class frmWindowsLogin
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.mtbPassword = new System.Windows.Forms.MaskedTextBox();
            this.cbxDomain = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(84, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(135, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // mtbPassword
            // 
            this.mtbPassword.Location = new System.Drawing.Point(84, 48);
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.PasswordChar = '*';
            this.mtbPassword.Size = new System.Drawing.Size(135, 20);
            this.mtbPassword.TabIndex = 1;
            // 
            // cbxDomain
            // 
            this.cbxDomain.FormattingEnabled = true;
            this.cbxDomain.Location = new System.Drawing.Point(84, 82);
            this.cbxDomain.Name = "cbxDomain";
            this.cbxDomain.Size = new System.Drawing.Size(135, 21);
            this.cbxDomain.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(111, 114);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Domain:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // frmWindowsLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbxDomain);
            this.Controls.Add(this.mtbPassword);
            this.Controls.Add(this.tbUsername);
            this.MaximizeBox = false;
            this.Name = "frmWindowsLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmWindowsLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.MaskedTextBox mtbPassword;
        private System.Windows.Forms.ComboBox cbxDomain;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

