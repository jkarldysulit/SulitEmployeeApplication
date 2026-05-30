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

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                string empId = GetValue(txtEmpId, "e.g. EMP-001");
                string first = GetValue(txtFirst, "Juan");
                string last = GetValue(txtLast, "dela Cruz");
                string pos = GetValue(txtPos, "e.g. Software Engineer");

                if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(first) ||
                    string.IsNullOrEmpty(last) || string.IsNullOrEmpty(pos))
                    throw new ArgumentException("Please fill in all employee details.");

                Payroll employee;

                if (rdoFullTime.Checked)
                {
                    string monthlyStr = GetValue(txtMonthly, "e.g. 25000");
                    if (string.IsNullOrEmpty(monthlyStr))
                        throw new ArgumentException("Monthly rate is required for Full-Time employees.");

                    if (!double.TryParse(monthlyStr, out double monthly) || monthly <= 0)
                        throw new FormatException("Monthly rate must be a valid positive number.");

                    int ovtHrs = 0;
                    double ovtRate = 0;

                    string ovtHrsStr = GetValue(txtOvtHrs, "e.g. 8");
                    string ovtRateStr = GetValue(txtOvtRate, "e.g. 150");

                    if (!string.IsNullOrEmpty(ovtHrsStr))
                        if (!int.TryParse(ovtHrsStr, out ovtHrs) || ovtHrs < 0)
                            throw new FormatException("Overtime hours must be a valid non-negative integer.");

                    if (!string.IsNullOrEmpty(ovtRateStr))
                        if (!double.TryParse(ovtRateStr, out ovtRate) || ovtRate < 0)
                            throw new FormatException("Overtime rate must be a valid non-negative number.");

                    employee = new FullTime(empId, first, last, pos, monthly, ovtHrs, ovtRate);
                }
                else
                {
                    string hourlyStr = GetValue(txtHourly, "e.g. 75");
                    string hoursStr = GetValue(txtHours, "e.g. 80");

                    if (string.IsNullOrEmpty(hourlyStr) || string.IsNullOrEmpty(hoursStr))
                        throw new ArgumentException("Hourly rate and hours worked are required for Part-Time employees.");

                    if (!double.TryParse(hourlyStr, out double hourly) || hourly <= 0)
                        throw new FormatException("Hourly rate must be a valid positive number.");

                    if (!int.TryParse(hoursStr, out int hours) || hours < 0)
                        throw new FormatException("Hours worked must be a valid non-negative integer.");

                    employee = new PartTime(empId, first, last, pos, hourly, hours);
                }

                var outputForm = new PayrollOutputForm(employee);
                outputForm.ShowDialog(this);
            }
            catch (ArgumentException ex) { lblError.Text = "" + ex.Message; }
            catch (FormatException ex) { lblError.Text = "" + ex.Message; }
            catch (OverflowException) { lblError.Text = "The value entered is too large."; }
            catch (Exception ex) { lblError.Text = "Unexpected error: " + ex.Message; }
        }
    }
}
