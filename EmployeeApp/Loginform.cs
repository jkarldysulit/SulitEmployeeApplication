using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class LoginForm : Form
    {
        private const string VALID_USER = "user";
        private const string VALID_PASS = "user123";

        private readonly Color Navy = Color.FromArgb(13, 27, 42);
        private readonly Color Gold = Color.FromArgb(244, 162, 97);
        private readonly Color GoldDark = Color.FromArgb(210, 120, 50);

        private const string UserPlaceholder = "Enter username";
        private const string PassPlaceholder = "Enter password";

        public LoginForm()
        {
            InitializeComponent();
            SetPlaceholder(txtUsername, UserPlaceholder, false);
            SetPlaceholder(txtPassword, PassPlaceholder, true);
        }

        private void SetPlaceholder(TextBox tb, string placeholder, bool isPassword)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;
            if (isPassword) tb.UseSystemPasswordChar = false;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.FromArgb(240, 244, 248);
                    if (isPassword) tb.UseSystemPasswordChar = true;
                }
            };
            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                    if (isPassword) tb.UseSystemPasswordChar = false;
                }
            };
        }
        public bool IsLogoutRequested { get; set; } = false;

        private string GetValue(TextBox tb, string placeholder)
        {
            string val = tb.Text.Trim();
            return val == placeholder ? "" : val;
        }

        private void PnlLeft_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(
                pnlLeft.ClientRectangle,
                Color.FromArgb(13, 27, 42),
                Color.FromArgb(30, 60, 90),
                LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, pnlLeft.ClientRectangle);
            }
            using (var pen = new Pen(Gold, 3))
                e.Graphics.DrawLine(pen, 337, 0, 337, 520);
        }

        private void ChkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != PassPlaceholder)
                txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLogin_Click(sender, e);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = GetValue(txtUsername, UserPlaceholder);
                string pass = txtPassword.Text == PassPlaceholder ? "" : txtPassword.Text;

                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
                    throw new ArgumentException("Please fill in all fields.");

                if (user != VALID_USER || pass != VALID_PASS)
                    throw new UnauthorizedAccessException("Invalid username or password.");

                lblError.Text = "";
                var empForm = new frmComputeSalary();
                this.Hide();
                empForm.Show();
                empForm.FormClosed += (s2, e2) =>
                {
                    if (!IsLogoutRequested)
                        this.Close();
                    else
                    {
                        IsLogoutRequested = false;
                        this.Show();
                    }
                };
            }
            catch (ArgumentException ex)
            {
                lblError.Text = "" + ex.Message;
            }
            catch (UnauthorizedAccessException ex)
            {
                lblError.Text = "" + ex.Message;
                SetPlaceholder(txtPassword, PassPlaceholder, true);
                txtPassword.Focus();
            }
            catch (Exception ex)
            {
                lblError.Text = "Unexpected error: " + ex.Message;
            }
        }


    }
}
