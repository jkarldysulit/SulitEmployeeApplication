namespace EmployeeApp
{
        partial class frmComputeSalary
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
            this.lblSub = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlPartTime = new System.Windows.Forms.Panel();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtHourly = new System.Windows.Forms.TextBox();
            this.lblHourly = new System.Windows.Forms.Label();
            this.lblPTTitle = new System.Windows.Forms.Label();
            this.pnlFullTime = new System.Windows.Forms.Panel();
            this.txtOvtRate = new System.Windows.Forms.TextBox();
            this.lblOvtRate = new System.Windows.Forms.Label();
            this.txtOvtHrs = new System.Windows.Forms.TextBox();
            this.lblOvtHrs = new System.Windows.Forms.Label();
            this.txtMonthly = new System.Windows.Forms.TextBox();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblFTTitle = new System.Windows.Forms.Label();
            this.pnlTypeCard = new System.Windows.Forms.Panel();
            this.rdoPartTime = new System.Windows.Forms.RadioButton();
            this.rdoFullTime = new System.Windows.Forms.RadioButton();
            this.lblTypeHeader = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.lblPos = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblEmpHeader = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlPartTime.SuspendLayout();
            this.pnlFullTime.SuspendLayout();
            this.pnlTypeCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pnlHeader.Controls.Add(this.lblSub);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(720, 80);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHeader_Paint);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblSub.Location = new System.Drawing.Point(34, 50);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(280, 15);
            this.lblSub.TabIndex = 100;
            this.lblSub.Text = "Fill in employee details and select employment type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 30);
            this.lblTitle.TabIndex = 101;
            this.lblTitle.Text = "👤  Employee Information";
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnlBody.Controls.Add(this.btnClear);
            this.pnlBody.Controls.Add(this.btnCompute);
            this.pnlBody.Controls.Add(this.lblError);
            this.pnlBody.Controls.Add(this.pnlPartTime);
            this.pnlBody.Controls.Add(this.pnlFullTime);
            this.pnlBody.Controls.Add(this.pnlTypeCard);
            this.pnlBody.Controls.Add(this.lblTypeHeader);
            this.pnlBody.Controls.Add(this.txtLast);
            this.pnlBody.Controls.Add(this.lblLast);
            this.pnlBody.Controls.Add(this.txtFirst);
            this.pnlBody.Controls.Add(this.lblFirst);
            this.pnlBody.Controls.Add(this.txtPos);
            this.pnlBody.Controls.Add(this.lblPos);
            this.pnlBody.Controls.Add(this.txtEmpId);
            this.pnlBody.Controls.Add(this.lblEmpId);
            this.pnlBody.Controls.Add(this.lblEmpHeader);
            this.pnlBody.Location = new System.Drawing.Point(0, 80);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(720, 560);
            this.pnlBody.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(350, 476);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 46);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "  CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.btnCompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompute.FlatAppearance.BorderSize = 0;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCompute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCompute.Location = new System.Drawing.Point(30, 476);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(300, 46);
            this.btnCompute.TabIndex = 20;
            this.btnCompute.Text = "  COMPUTE PAYROLL";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblError.Location = new System.Drawing.Point(32, 448);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 22;
            // 
            // pnlPartTime
            // 
            this.pnlPartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.pnlPartTime.Controls.Add(this.txtHours);
            this.pnlPartTime.Controls.Add(this.lblHours);
            this.pnlPartTime.Controls.Add(this.txtHourly);
            this.pnlPartTime.Controls.Add(this.lblHourly);
            this.pnlPartTime.Controls.Add(this.lblPTTitle);
            this.pnlPartTime.Location = new System.Drawing.Point(30, 300);
            this.pnlPartTime.Name = "pnlPartTime";
            this.pnlPartTime.Size = new System.Drawing.Size(660, 130);
            this.pnlPartTime.TabIndex = 12;
            this.pnlPartTime.Visible = false;
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHours.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtHours.Location = new System.Drawing.Point(335, 60);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(305, 26);
            this.txtHours.TabIndex = 1;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.Transparent;
            this.lblHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblHours.Location = new System.Drawing.Point(335, 38);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(118, 15);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Total Hours Worked";
            // 
            // txtHourly
            // 
            this.txtHourly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtHourly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHourly.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtHourly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtHourly.Location = new System.Drawing.Point(15, 60);
            this.txtHourly.Name = "txtHourly";
            this.txtHourly.Size = new System.Drawing.Size(300, 26);
            this.txtHourly.TabIndex = 0;
            // 
            // lblHourly
            // 
            this.lblHourly.AutoSize = true;
            this.lblHourly.BackColor = System.Drawing.Color.Transparent;
            this.lblHourly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHourly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblHourly.Location = new System.Drawing.Point(15, 38);
            this.lblHourly.Name = "lblHourly";
            this.lblHourly.Size = new System.Drawing.Size(92, 15);
            this.lblHourly.TabIndex = 3;
            this.lblHourly.Text = "Hourly Rate (₱)";
            // 
            // lblPTTitle
            // 
            this.lblPTTitle.AutoSize = true;
            this.lblPTTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPTTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPTTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(199)))), ((int)(((byte)(142)))));
            this.lblPTTitle.Location = new System.Drawing.Point(15, 12);
            this.lblPTTitle.Name = "lblPTTitle";
            this.lblPTTitle.Size = new System.Drawing.Size(141, 17);
            this.lblPTTitle.TabIndex = 4;
            this.lblPTTitle.Text = "Part-Time Pay Details";
            // 
            // pnlFullTime
            // 
            this.pnlFullTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.pnlFullTime.Controls.Add(this.txtOvtRate);
            this.pnlFullTime.Controls.Add(this.lblOvtRate);
            this.pnlFullTime.Controls.Add(this.txtOvtHrs);
            this.pnlFullTime.Controls.Add(this.lblOvtHrs);
            this.pnlFullTime.Controls.Add(this.txtMonthly);
            this.pnlFullTime.Controls.Add(this.lblMonthly);
            this.pnlFullTime.Controls.Add(this.lblFTTitle);
            this.pnlFullTime.Location = new System.Drawing.Point(30, 300);
            this.pnlFullTime.Name = "pnlFullTime";
            this.pnlFullTime.Size = new System.Drawing.Size(660, 130);
            this.pnlFullTime.TabIndex = 11;
            // 
            // txtOvtRate
            // 
            this.txtOvtRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtOvtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOvtRate.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtOvtRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtOvtRate.Location = new System.Drawing.Point(435, 60);
            this.txtOvtRate.Name = "txtOvtRate";
            this.txtOvtRate.Size = new System.Drawing.Size(205, 26);
            this.txtOvtRate.TabIndex = 2;
            // 
            // lblOvtRate
            // 
            this.lblOvtRate.AutoSize = true;
            this.lblOvtRate.BackColor = System.Drawing.Color.Transparent;
            this.lblOvtRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOvtRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblOvtRate.Location = new System.Drawing.Point(435, 38);
            this.lblOvtRate.Name = "lblOvtRate";
            this.lblOvtRate.Size = new System.Drawing.Size(126, 15);
            this.lblOvtRate.TabIndex = 3;
            this.lblOvtRate.Text = "Overtime Rate/hr (₱)";
            // 
            // txtOvtHrs
            // 
            this.txtOvtHrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtOvtHrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOvtHrs.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtOvtHrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtOvtHrs.Location = new System.Drawing.Point(225, 60);
            this.txtOvtHrs.Name = "txtOvtHrs";
            this.txtOvtHrs.Size = new System.Drawing.Size(190, 26);
            this.txtOvtHrs.TabIndex = 1;
            // 
            // lblOvtHrs
            // 
            this.lblOvtHrs.AutoSize = true;
            this.lblOvtHrs.BackColor = System.Drawing.Color.Transparent;
            this.lblOvtHrs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOvtHrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblOvtHrs.Location = new System.Drawing.Point(225, 38);
            this.lblOvtHrs.Name = "lblOvtHrs";
            this.lblOvtHrs.Size = new System.Drawing.Size(97, 15);
            this.lblOvtHrs.TabIndex = 4;
            this.lblOvtHrs.Text = "Overtime Hours";
            // 
            // txtMonthly
            // 
            this.txtMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtMonthly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonthly.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtMonthly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtMonthly.Location = new System.Drawing.Point(15, 60);
            this.txtMonthly.Name = "txtMonthly";
            this.txtMonthly.Size = new System.Drawing.Size(190, 26);
            this.txtMonthly.TabIndex = 0;
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMonthly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblMonthly.Location = new System.Drawing.Point(15, 38);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(101, 15);
            this.lblMonthly.TabIndex = 5;
            this.lblMonthly.Text = "Monthly Rate (₱)";
            // 
            // lblFTTitle
            // 
            this.lblFTTitle.AutoSize = true;
            this.lblFTTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFTTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFTTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.lblFTTitle.Location = new System.Drawing.Point(15, 12);
            this.lblFTTitle.Name = "lblFTTitle";
            this.lblFTTitle.Size = new System.Drawing.Size(140, 17);
            this.lblFTTitle.TabIndex = 6;
            this.lblFTTitle.Text = "Full-Time Pay Details";
            // 
            // pnlTypeCard
            // 
            this.pnlTypeCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.pnlTypeCard.Controls.Add(this.rdoPartTime);
            this.pnlTypeCard.Controls.Add(this.rdoFullTime);
            this.pnlTypeCard.Location = new System.Drawing.Point(30, 224);
            this.pnlTypeCard.Name = "pnlTypeCard";
            this.pnlTypeCard.Size = new System.Drawing.Size(660, 60);
            this.pnlTypeCard.TabIndex = 10;
            // 
            // rdoPartTime
            // 
            this.rdoPartTime.AutoSize = true;
            this.rdoPartTime.BackColor = System.Drawing.Color.Transparent;
            this.rdoPartTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPartTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rdoPartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(199)))), ((int)(((byte)(142)))));
            this.rdoPartTime.Location = new System.Drawing.Point(340, 18);
            this.rdoPartTime.Name = "rdoPartTime";
            this.rdoPartTime.Size = new System.Drawing.Size(198, 24);
            this.rdoPartTime.TabIndex = 1;
            this.rdoPartTime.Text = "📋  Part-Time Employee";
            this.rdoPartTime.UseVisualStyleBackColor = false;
            this.rdoPartTime.CheckedChanged += new System.EventHandler(this.RdoType_Changed);
            // 
            // rdoFullTime
            // 
            this.rdoFullTime.AutoSize = true;
            this.rdoFullTime.BackColor = System.Drawing.Color.Transparent;
            this.rdoFullTime.Checked = true;
            this.rdoFullTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoFullTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rdoFullTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.rdoFullTime.Location = new System.Drawing.Point(20, 18);
            this.rdoFullTime.Name = "rdoFullTime";
            this.rdoFullTime.Size = new System.Drawing.Size(195, 24);
            this.rdoFullTime.TabIndex = 0;
            this.rdoFullTime.TabStop = true;
            this.rdoFullTime.Text = "⏱  Full-Time Employee";
            this.rdoFullTime.UseVisualStyleBackColor = false;
            this.rdoFullTime.CheckedChanged += new System.EventHandler(this.RdoType_Changed);
            // 
            // lblTypeHeader
            // 
            this.lblTypeHeader.AutoSize = true;
            this.lblTypeHeader.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTypeHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.lblTypeHeader.Location = new System.Drawing.Point(30, 202);
            this.lblTypeHeader.Name = "lblTypeHeader";
            this.lblTypeHeader.Size = new System.Drawing.Size(116, 15);
            this.lblTypeHeader.TabIndex = 23;
            this.lblTypeHeader.Text = "EMPLOYMENT TYPE";
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLast.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtLast.Location = new System.Drawing.Point(370, 146);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(310, 26);
            this.txtLast.TabIndex = 3;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblLast.Location = new System.Drawing.Point(370, 124);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(65, 15);
            this.lblLast.TabIndex = 24;
            this.lblLast.Text = "Last Name";
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirst.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtFirst.Location = new System.Drawing.Point(30, 146);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(320, 26);
            this.txtFirst.TabIndex = 2;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblFirst.Location = new System.Drawing.Point(30, 124);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(67, 15);
            this.lblFirst.TabIndex = 25;
            this.lblFirst.Text = "First Name";
            // 
            // txtPos
            // 
            this.txtPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.txtPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPos.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtPos.Location = new System.Drawing.Point(260, 74);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(420, 26);
            this.txtPos.TabIndex = 1;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblPos.Location = new System.Drawing.Point(260, 52);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(109, 15);
            this.lblPos.TabIndex = 26;
            this.lblPos.Text = "Position / Job Title";
            // 
            // txtEmpId
            // 
            this.txtEmpId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpId.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEmpId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtEmpId.Location = new System.Drawing.Point(30, 74);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(200, 26);
            this.txtEmpId.TabIndex = 0;
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmpId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.lblEmpId.Location = new System.Drawing.Point(30, 52);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(77, 15);
            this.lblEmpId.TabIndex = 27;
            this.lblEmpId.Text = "Employee ID";
            // 
            // lblEmpHeader
            // 
            this.lblEmpHeader.AutoSize = true;
            this.lblEmpHeader.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEmpHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.lblEmpHeader.Location = new System.Drawing.Point(30, 20);
            this.lblEmpHeader.Name = "lblEmpHeader";
            this.lblEmpHeader.Size = new System.Drawing.Size(114, 15);
            this.lblEmpHeader.TabIndex = 28;
            this.lblEmpHeader.Text = "EMPLOYEE DETAILS";
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(720, 640);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmComputeSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayRoll Pro — Employee Input";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlPartTime.ResumeLayout(false);
            this.pnlPartTime.PerformLayout();
            this.pnlFullTime.ResumeLayout(false);
            this.pnlFullTime.PerformLayout();
            this.pnlTypeCard.ResumeLayout(false);
            this.pnlTypeCard.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Panel pnlHeader;
            private System.Windows.Forms.Panel pnlBody;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblSub;
            private System.Windows.Forms.Label lblEmpHeader;
            private System.Windows.Forms.Label lblEmpId;
            private System.Windows.Forms.TextBox txtEmpId;
            private System.Windows.Forms.Label lblPos;
            private System.Windows.Forms.TextBox txtPos;
            private System.Windows.Forms.Label lblFirst;
            private System.Windows.Forms.TextBox txtFirst;
            private System.Windows.Forms.Label lblLast;
            private System.Windows.Forms.TextBox txtLast;
            private System.Windows.Forms.Label lblTypeHeader;
            private System.Windows.Forms.Panel pnlTypeCard;
            private System.Windows.Forms.RadioButton rdoFullTime;
            private System.Windows.Forms.RadioButton rdoPartTime;
            private System.Windows.Forms.Panel pnlFullTime;
            private System.Windows.Forms.Label lblFTTitle;
            private System.Windows.Forms.Label lblMonthly;
            private System.Windows.Forms.TextBox txtMonthly;
            private System.Windows.Forms.Label lblOvtHrs;
            private System.Windows.Forms.TextBox txtOvtHrs;
            private System.Windows.Forms.Label lblOvtRate;
            private System.Windows.Forms.TextBox txtOvtRate;
            private System.Windows.Forms.Panel pnlPartTime;
            private System.Windows.Forms.Label lblPTTitle;
            private System.Windows.Forms.Label lblHourly;
            private System.Windows.Forms.TextBox txtHourly;
            private System.Windows.Forms.Label lblHours;
            private System.Windows.Forms.TextBox txtHours;
            private System.Windows.Forms.Label lblError;
            private System.Windows.Forms.Button btnCompute;
            private System.Windows.Forms.Button btnClear;
        }
    }
