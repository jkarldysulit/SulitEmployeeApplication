using EmployeeApplication;
using EmployeeInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();

            SetPlaceholder(txtEmpId, "e.g. EMP-001");
            SetPlaceholder(txtPos, "e.g. Software Engineer");
            SetPlaceholder(txtFirst, "Juan");
            SetPlaceholder(txtLast, "dela Cruz");
            SetPlaceholder(txtMonthly, "e.g. 25000");
            SetPlaceholder(txtOvtHrs, "e.g. 8");
            SetPlaceholder(txtOvtRate, "e.g. 150");
            SetPlaceholder(txtHourly, "e.g. 75");
            SetPlaceholder(txtHours, "e.g. 80");
        }

        private void SetPlaceholder(TextBox tb, string placeholder)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.FromArgb(240, 244, 248);
                }
            };
            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                }
            };
        }

        private string GetValue(TextBox tb, string placeholder)
        {
            string val = tb.Text.Trim();
            return val == placeholder ? "" : val;
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(244, 162, 97), 3))
                e.Graphics.DrawLine(pen, 0, 77, 720, 77);
        }

        private void RdoType_Changed(object sender, EventArgs e)
        {
            pnlFullTime.Visible = rdoFullTime.Checked;
            pnlPartTime.Visible = rdoPartTime.Checked;
            lblError.Text = "";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            SetPlaceholder(txtEmpId, "e.g. EMP-001");
            SetPlaceholder(txtPos, "e.g. Software Engineer");
            SetPlaceholder(txtFirst, "Juan");
            SetPlaceholder(txtLast, "dela Cruz");
            SetPlaceholder(txtMonthly, "e.g. 25000");
            SetPlaceholder(txtOvtHrs, "e.g. 8");
            SetPlaceholder(txtOvtRate, "e.g. 150");
            SetPlaceholder(txtHourly, "e.g. 75");
            SetPlaceholder(txtHours, "e.g. 80");
            rdoFullTime.Checked = true;
            lblError.Text = "";
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f is LoginForm login)
                    {
                        login.IsLogoutRequested = true;
                        break;
                    }
                }
                this.Close();
            }
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
  
                string empId = GetValue(txtEmpId, "e.g. EMP-001");
                string first = GetValue(txtFirst, "Juan");
                string last = GetValue(txtLast, "dela Cruz");
                string pos = GetValue(txtPos, "e.g. Software Engineer");

                if (string.IsNullOrWhiteSpace(empId))
                    throw new ArgumentException("Employee ID is required.");
                if (string.IsNullOrWhiteSpace(first))
                    throw new ArgumentException("First name is required.");
                if (string.IsNullOrWhiteSpace(last))
                    throw new ArgumentException("Last name is required.");
                if (string.IsNullOrWhiteSpace(pos))
                    throw new ArgumentException("Position / Job title is required.");

                if (!System.Text.RegularExpressions.Regex.IsMatch(first, @"^[a-zA-Z\s]+$"))
                    throw new ArgumentException("First name must contain letters only.");
                if (!System.Text.RegularExpressions.Regex.IsMatch(last, @"^[a-zA-Z\s]+$"))
                    throw new ArgumentException("Last name must contain letters only.");

                if (rdoPartTime.Checked)
                {
                    string hourlyStr = GetValue(txtHourly, "e.g. 75");
                    string hoursStr = GetValue(txtHours, "e.g. 80");

                    if (string.IsNullOrWhiteSpace(hourlyStr))
                        throw new ArgumentException("Rate per hour is required for Part-Time employees.");
                    if (string.IsNullOrWhiteSpace(hoursStr))
                        throw new ArgumentException("Total hours worked is required for Part-Time employees.");

                    if (!double.TryParse(hourlyStr, out double hourly))
                        throw new FormatException("Rate per hour must be a valid number.");
                    if (hourly <= 0)
                        throw new ArgumentException("Rate per hour must be greater than zero.");

                    if (!int.TryParse(hoursStr, out int hours))
                        throw new FormatException("Total hours worked must be a whole number.");
                    if (hours < 0)
                        throw new ArgumentException("Hours worked cannot be negative.");
                    if (hours > 744)
                        throw new ArgumentException("Hours worked cannot exceed 744 hours per month.");

                    IEmployee employee = new PartTimeEmployee(first, last, pos, empId);
                    employee.ComputeSalary(hours, hourly);

                    string displayFirst = employee.FirstName;
                    string displayLast = employee.LastName;
                    double displaySalary = employee.BasicSalary;

                    var outputForm = new PayrollOutputForm(
                        new PartTime(empId, first, last, pos, hourly, hours));
                    outputForm.ShowDialog(this);
                }
                else
                {

                    string monthlyStr = GetValue(txtMonthly, "e.g. 25000");

                    if (string.IsNullOrWhiteSpace(monthlyStr))
                        throw new ArgumentException("Monthly rate is required for Full-Time employees.");
                    if (!double.TryParse(monthlyStr, out double monthly))
                        throw new FormatException("Monthly rate must be a valid number.");
                    if (monthly <= 0)
                        throw new ArgumentException("Monthly rate must be greater than zero.");

                    int ovtHrs = 0;
                    double ovtRate = 0;

                    string ovtHrsStr = GetValue(txtOvtHrs, "e.g. 8");
                    string ovtRateStr = GetValue(txtOvtRate, "e.g. 150");

                    if (!string.IsNullOrWhiteSpace(ovtHrsStr))
                    {
                        if (!int.TryParse(ovtHrsStr, out ovtHrs))
                            throw new FormatException("Overtime hours must be a whole number.");
                        if (ovtHrs < 0)
                            throw new ArgumentException("Overtime hours cannot be negative.");
                    }

                    if (!string.IsNullOrWhiteSpace(ovtRateStr))
                    {
                        if (!double.TryParse(ovtRateStr, out ovtRate))
                            throw new FormatException("Overtime rate must be a valid number.");
                        if (ovtRate < 0)
                            throw new ArgumentException("Overtime rate cannot be negative.");
                    }

                    if (ovtHrs > 0 && ovtRate == 0)
                        throw new ArgumentException("Please enter an overtime rate per hour.");
                    if (ovtRate > 0 && ovtHrs == 0)
                        throw new ArgumentException("Please enter the number of overtime hours.");

                    var outputForm = new PayrollOutputForm(
                        new FullTime(empId, first, last, pos, monthly, ovtHrs, ovtRate));
                    outputForm.ShowDialog(this);
                }
            }
            catch (ArgumentException ex) { lblError.Text = "" + ex.Message; }
            catch (FormatException ex) { lblError.Text = "" + ex.Message; }
            catch (OverflowException) { lblError.Text = "The value entered is too large."; }
            catch (Exception ex) { lblError.Text = "Unexpected error: " + ex.Message; }
        }
    }
}