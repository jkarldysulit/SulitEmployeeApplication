namespace EmployeeApp
{

    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lineAccent = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnlLeft.Controls.Add(this.lineAccent);
            this.pnlLeft.Controls.Add(this.lblTagline);
            this.pnlLeft.Controls.Add(this.lblBrand);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(340, 520);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLeft_Paint);
            // 
            // lineAccent
            // 
            this.lineAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.lineAccent.Location = new System.Drawing.Point(40, 290);
            this.lineAccent.Name = "lineAccent";
            this.lineAccent.Size = new System.Drawing.Size(260, 3);
            this.lineAccent.TabIndex = 1;
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.lblTagline.Location = new System.Drawing.Point(40, 215);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(151, 20);
            this.lblTagline.TabIndex = 2;
            this.lblTagline.Text = "Smart Payroll  System";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.lblBrand.Location = new System.Drawing.Point(40, 160);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(228, 41);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "💼 PayRoll Pro";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.lblError);
            this.pnlRight.Controls.Add(this.chkShow);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.lblPass);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblUser);
            this.pnlRight.Controls.Add(this.lblSubtitle);
            this.pnlRight.Controls.Add(this.lblTitle);
            this.pnlRight.Location = new System.Drawing.Point(340, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(480, 520);
            this.pnlRight.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnLogin.Location = new System.Drawing.Point(60, 360);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(360, 46);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "SIGN IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblError.Location = new System.Drawing.Point(62, 335);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 4;
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.BackColor = System.Drawing.Color.Transparent;
            this.chkShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.chkShow.Location = new System.Drawing.Point(62, 308);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(108, 19);
            this.chkShow.TabIndex = 2;
            this.chkShow.Text = "Show password";
            this.chkShow.UseVisualStyleBackColor = false;
            this.chkShow.CheckedChanged += new System.EventHandler(this.ChkShow_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtPassword.Location = new System.Drawing.Point(60, 263);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(360, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblPass.Location = new System.Drawing.Point(60, 240);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(66, 17);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtUsername.Location = new System.Drawing.Point(60, 188);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(360, 27);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(60, 165);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 17);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Username";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblSubtitle.Location = new System.Drawing.Point(63, 118);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(151, 19);
            this.lblSubtitle.TabIndex = 7;
            this.lblSubtitle.Text = "Sign in to your account";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.lblTitle.Location = new System.Drawing.Point(60, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 37);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Welcome";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(820, 520);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayRoll Pro — Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lineAccent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

