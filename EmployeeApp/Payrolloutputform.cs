using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class PayrollOutputForm : Form
    {
        private readonly Payroll _employee;

        private readonly Color Navy = Color.FromArgb(13, 27, 42);
        private readonly Color Gold = Color.FromArgb(244, 162, 97);
        private readonly Color White = Color.FromArgb(240, 244, 248);
        private readonly Color Gray = Color.FromArgb(160, 174, 192);
        private readonly Color Green = Color.FromArgb(72, 199, 142);
        private readonly Color Red = Color.FromArgb(255, 99, 99);

        public PayrollOutputForm(Payroll employee)
        {
            _employee = employee ?? throw new ArgumentNullException(nameof(employee), "Employee data cannot be null.");
            InitializeComponent();
            SetupDynamicContent();
            BuildSlipContent();
        }

        private void SetupDynamicContent()
        {
            bool isFullTime = _employee is FullTime;
            lblTypeBadge.Text = isFullTime ? "Full-Time" : "Part-Time";
            lblTypeBadge.BackColor = isFullTime ? Gold : Green;
            lblDate.Text = "Generated: " + DateTime.Now.ToString("MMMM dd, yyyy  hh:mm tt");
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Gold, 3))
                e.Graphics.DrawLine(pen, 0, 67, 640, 67);
        }

        private void PnlSlip_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Gold, 2))
                e.Graphics.DrawRectangle(pen, 0, 0, pnlSlip.Width - 1, pnlSlip.Height - 1);
        }

        private void BuildSlipContent()
        {
            int x1 = 20, x2 = 310, y = 20;

            AddSlipLabel("💼 PAYROLL PRO SYSTEM", new Point(150, y), new Font("Segoe UI", 13f, FontStyle.Bold), Gold); y += 28;
            AddSlipLabel("Payroll Slip", new Point(110, y), new Font("Segoe UI", 8.5f), Gray); y += 16;
            AddDivider(y, Gold); y += 12;

            AddSlipPair("Employee ID", _employee.EmployeeId, x1, x2, y); y += 26;
            AddSlipPair("Full Name", _employee.FullName, x1, x2, y); y += 26;
            AddSlipPair("Position", _employee.Position, x1, x2, y); y += 26;
            AddSlipPair("Employee Type", _employee is FullTime ? "Full-Time" : "Part-Time", x1, x2, y); y += 10;
            AddDivider(y + 10, Gray); y += 24;

            AddSlipLabel("EARNINGS", new Point(x1, y), new Font("Segoe UI", 8.5f, FontStyle.Bold), Gold); y += 22;

            if (_employee is FullTime ft)
            {
                AddSlipPair("Monthly Rate", Fmt(ft.MonthlyRate), x1, x2, y); y += 24;
                if (ft.OvertimeHours > 0)
                { AddSlipPair($"Overtime ({ft.OvertimeHours} hrs × ₱{ft.OvertimeRatePerHour:N2})", Fmt(ft.OvertimePay), x1, x2, y); y += 24; }
            }
            else if (_employee is PartTime pt)
            { AddSlipPair($"Hourly Rate × Hours Worked ({pt.HoursWorked} hrs)", Fmt(pt.ComputeGrossPay()), x1, x2, y); y += 24; }

            AddDivider(y, Color.FromArgb(60, 80, 100)); y += 8;
            AddSlipPair("GROSS PAY", Fmt(_employee.ComputeGrossPay()), x1, x2, y, true, White); y += 14;
            AddDivider(y, Gray); y += 14;

            AddSlipLabel("DEDUCTIONS", new Point(x1, y), new Font("Segoe UI", 8.5f, FontStyle.Bold), Red); y += 22;
            AddSlipPair("Withholding Tax", $"- {Fmt(_employee.ComputeTax())}", x1, x2, y, false, Red); y += 24;
            AddSlipPair("SSS Contribution", $"- {Fmt(_employee.ComputeSSS())}", x1, x2, y, false, Red); y += 24;
            AddSlipPair("PhilHealth Contribution", $"- {Fmt(_employee.ComputePhilHealth())}", x1, x2, y, false, Red); y += 24;
            AddSlipPair("Pag-IBIG Contribution", $"- {Fmt(_employee.ComputePagIbig())}", x1, x2, y, false, Red); y += 10;
            AddDivider(y, Color.FromArgb(60, 80, 100)); y += 8;
            AddSlipPair("TOTAL DEDUCTIONS", $"- {Fmt(_employee.ComputeTotalDeductions())}", x1, x2, y, true, Red); y += 16;
            AddDivider(y, Gold); y += 10;

            AddSlipLabel("NET PAY", new Point(x1, y), new Font("Segoe UI", 11f, FontStyle.Bold), White);
            var lblNet = new Label
            {
                Text = Fmt(_employee.ComputeNetPay()),
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = Green,
                AutoSize = true,
                Location = new Point(x2, y - 4),
                BackColor = Color.Transparent
            };
            pnlSlip.Controls.Add(lblNet);
        }

        private void AddSlipLabel(string text, Point loc, Font font, Color color)
        {
            pnlSlip.Controls.Add(new Label { Text = text, Font = font, ForeColor = color, AutoSize = true, Location = loc, BackColor = Color.Transparent });
        }

        private void AddSlipPair(string left, string right, int x1, int x2, int y, bool bold = false, Color? rightColor = null)
        {
            pnlSlip.Controls.Add(new Label { Text = left, Font = new Font("Segoe UI", 9.5f), ForeColor = Gray, AutoSize = true, Location = new Point(x1, y), BackColor = Color.Transparent });
            pnlSlip.Controls.Add(new Label { Text = right, Font = bold ? new Font("Segoe UI", 10f, FontStyle.Bold) : new Font("Segoe UI", 9.5f), ForeColor = rightColor ?? White, AutoSize = true, Location = new Point(x2, y), BackColor = Color.Transparent });
        }

        private void AddDivider(int y, Color color)
        {
            pnlSlip.Controls.Add(new Label { Size = new Size(540, 1), Location = new Point(20, y), BackColor = color });
        }

        private string Fmt(double v) => $"₱{v:N2}";

        private void BtnNew_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e) => this.Close();

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var pd = new PrintDocument();
                pd.PrintPage += PrintPage;
                var preview = new PrintPreviewDialog { Document = pd, Width = 700, Height = 800 };
                preview.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Print error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float px = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Font bold = new Font("Segoe UI", 11f, FontStyle.Bold);
            Font norm = new Font("Segoe UI", 10f);
            Font small = new Font("Segoe UI", 9f);
            float col2 = px + 300;

            void Row(string l, string r, Font f = null, Brush b = null)
            { g.DrawString(l, f ?? norm, Brushes.Black, px, y); g.DrawString(r, f ?? norm, b ?? Brushes.Black, col2, y); y += 22; }
            void Line() { g.DrawLine(Pens.Gray, px, y, px + 500, y); y += 6; }

            g.DrawString("PAYROLL PRO SYSTEM", new Font("Segoe UI", 16f, FontStyle.Bold), Brushes.Black, px + 120, y); y += 30;
            Line();
            Row("Employee ID:", _employee.EmployeeId);
            Row("Full Name:", _employee.FullName);
            Row("Position:", _employee.Position);
            Row("Type:", _employee is FullTime ? "Full-Time" : "Part-Time");
            Line();
            g.DrawString("EARNINGS", bold, Brushes.Black, px, y); y += 24;
            if (_employee is FullTime ft) { Row("Monthly Rate:", Fmt(ft.MonthlyRate)); if (ft.OvertimeHours > 0) Row($"Overtime ({ft.OvertimeHours} hrs):", Fmt(ft.OvertimePay)); }
            else if (_employee is PartTime pt) Row($"Hourly × Hours ({pt.HoursWorked} hrs):", Fmt(pt.ComputeGrossPay()));
            Line(); Row("Gross Pay:", Fmt(_employee.ComputeGrossPay()), bold); Line();
            g.DrawString("DEDUCTIONS", bold, Brushes.Black, px, y); y += 24;
            Row("Withholding Tax:", $"- {Fmt(_employee.ComputeTax())}");
            Row("SSS:", $"- {Fmt(_employee.ComputeSSS())}");
            Row("PhilHealth:", $"- {Fmt(_employee.ComputePhilHealth())}");
            Row("Pag-IBIG:", $"- {Fmt(_employee.ComputePagIbig())}");
            Line(); Row("Total Deductions:", $"- {Fmt(_employee.ComputeTotalDeductions())}", bold); Line();
            g.DrawString("NET PAY:", new Font("Segoe UI", 13f, FontStyle.Bold), Brushes.Black, px, y);
            g.DrawString(Fmt(_employee.ComputeNetPay()), new Font("Segoe UI", 13f, FontStyle.Bold), new SolidBrush(Color.FromArgb(0, 140, 80)), col2, y);
        }
    }
}
