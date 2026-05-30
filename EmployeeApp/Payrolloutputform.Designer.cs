namespace EmployeeApp
{
    partial class PayrollOutputForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTypeBadge = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSlip = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 43, 60);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.lblTypeBadge);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(640, 70);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHeader_Paint);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.lblTitle.Location = new System.Drawing.Point(30, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "📄  Payroll Slip";

            this.lblTypeBadge.AutoSize = false;
            this.lblTypeBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTypeBadge.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTypeBadge.Location = new System.Drawing.Point(32, 42);
            this.lblTypeBadge.Name = "lblTypeBadge";
            this.lblTypeBadge.Size = new System.Drawing.Size(80, 22);
            this.lblTypeBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTypeBadge.Text = "";

            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(160, 174, 192);
            this.lblDate.Location = new System.Drawing.Point(380, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Text = "";

            // ── pnlSlip ───────────────────────────────────────────
            this.pnlSlip.BackColor = System.Drawing.Color.FromArgb(20, 38, 56);
            this.pnlSlip.Location = new System.Drawing.Point(30, 85);
            this.pnlSlip.Name = "pnlSlip";
            this.pnlSlip.Size = new System.Drawing.Size(580, 510);
            this.pnlSlip.TabIndex = 1;
            this.pnlSlip.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSlip_Paint);

            // btnPrint
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(244, 162, 97);
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnPrint.Location = new System.Drawing.Point(30, 610);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(180, 44);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "🖨  PRINT SLIP";
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);

            // btnNew
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(50, 80, 120);
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.btnNew.Location = new System.Drawing.Point(240, 610);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(180, 44);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "➕  NEW ENTRY";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(50, 30, 30);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(255, 99, 99);
            this.btnClose.Location = new System.Drawing.Point(430, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 44);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "✖  CLOSE";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            // ── PayrollOutputForm ─────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.ClientSize = new System.Drawing.Size(640, 670);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlSlip);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PayrollOutputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PayRoll Pro — Payroll Slip";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTypeBadge;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlSlip;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
    }
}