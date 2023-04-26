namespace ThuThuy.App.QuanLyTab
{
    partial class TaiLieu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.HD = new System.Windows.Forms.TabPage();
            this.dtCTView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TC = new System.Windows.Forms.TabPage();
            this.dtThuChi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bPrint = new Guna.UI2.WinForms.Guna2Button();
            this.bRes = new Guna.UI2.WinForms.Guna2Button();
            this.txtDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bSpend = new Guna.UI2.WinForms.Guna2Button();
            this.bErn = new Guna.UI2.WinForms.Guna2Button();
            this.bYear = new Guna.UI2.WinForms.Guna2Button();
            this.bMonth = new Guna.UI2.WinForms.Guna2Button();
            this.bDay = new Guna.UI2.WinForms.Guna2Button();
            this.dtView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tControl.SuspendLayout();
            this.HD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCTView)).BeginInit();
            this.TC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThuChi)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).BeginInit();
            this.SuspendLayout();
            // 
            // tControl
            // 
            this.tControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tControl.Controls.Add(this.HD);
            this.tControl.Controls.Add(this.TC);
            this.tControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tControl.ItemSize = new System.Drawing.Size(180, 40);
            this.tControl.Location = new System.Drawing.Point(0, 444);
            this.tControl.Name = "tControl";
            this.tControl.SelectedIndex = 0;
            this.tControl.Size = new System.Drawing.Size(1545, 206);
            this.tControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tControl.TabIndex = 0;
            this.tControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tControl.SelectedIndexChanged += new System.EventHandler(this.tControl_SelectedIndexChanged);
            // 
            // HD
            // 
            this.HD.Controls.Add(this.dtCTView);
            this.HD.Location = new System.Drawing.Point(184, 4);
            this.HD.Name = "HD";
            this.HD.Padding = new System.Windows.Forms.Padding(3);
            this.HD.Size = new System.Drawing.Size(1357, 198);
            this.HD.TabIndex = 0;
            this.HD.Text = "Hóa Đơn";
            this.HD.UseVisualStyleBackColor = true;
            // 
            // dtCTView
            // 
            this.dtCTView.AllowUserToAddRows = false;
            this.dtCTView.AllowUserToDeleteRows = false;
            this.dtCTView.AllowUserToResizeColumns = false;
            this.dtCTView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtCTView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCTView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtCTView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtCTView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtCTView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtCTView.Enabled = false;
            this.dtCTView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtCTView.Location = new System.Drawing.Point(3, 3);
            this.dtCTView.Name = "dtCTView";
            this.dtCTView.ReadOnly = true;
            this.dtCTView.RowHeadersVisible = false;
            this.dtCTView.RowHeadersWidth = 51;
            this.dtCTView.RowTemplate.Height = 24;
            this.dtCTView.Size = new System.Drawing.Size(1351, 192);
            this.dtCTView.TabIndex = 0;
            this.dtCTView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtCTView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtCTView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtCTView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtCTView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtCTView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtCTView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtCTView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtCTView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtCTView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCTView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtCTView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtCTView.ThemeStyle.HeaderStyle.Height = 30;
            this.dtCTView.ThemeStyle.ReadOnly = true;
            this.dtCTView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtCTView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtCTView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCTView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtCTView.ThemeStyle.RowsStyle.Height = 24;
            this.dtCTView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtCTView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TC
            // 
            this.TC.Controls.Add(this.dtThuChi);
            this.TC.Controls.Add(this.guna2Panel1);
            this.TC.Location = new System.Drawing.Point(184, 4);
            this.TC.Name = "TC";
            this.TC.Padding = new System.Windows.Forms.Padding(3);
            this.TC.Size = new System.Drawing.Size(1357, 198);
            this.TC.TabIndex = 1;
            this.TC.Text = "Thu Chi";
            this.TC.UseVisualStyleBackColor = true;
            // 
            // dtThuChi
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtThuChi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtThuChi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtThuChi.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtThuChi.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtThuChi.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtThuChi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtThuChi.Location = new System.Drawing.Point(3, 3);
            this.dtThuChi.Name = "dtThuChi";
            this.dtThuChi.RowHeadersVisible = false;
            this.dtThuChi.RowHeadersWidth = 51;
            this.dtThuChi.RowTemplate.Height = 24;
            this.dtThuChi.Size = new System.Drawing.Size(878, 192);
            this.dtThuChi.TabIndex = 1;
            this.dtThuChi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtThuChi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtThuChi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtThuChi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtThuChi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtThuChi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtThuChi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtThuChi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtThuChi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtThuChi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThuChi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtThuChi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtThuChi.ThemeStyle.HeaderStyle.Height = 30;
            this.dtThuChi.ThemeStyle.ReadOnly = false;
            this.dtThuChi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtThuChi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtThuChi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThuChi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtThuChi.ThemeStyle.RowsStyle.Height = 24;
            this.dtThuChi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtThuChi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.bPrint);
            this.guna2Panel1.Controls.Add(this.bRes);
            this.guna2Panel1.Controls.Add(this.txtDate);
            this.guna2Panel1.Controls.Add(this.bSpend);
            this.guna2Panel1.Controls.Add(this.bErn);
            this.guna2Panel1.Controls.Add(this.bYear);
            this.guna2Panel1.Controls.Add(this.bMonth);
            this.guna2Panel1.Controls.Add(this.bDay);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(887, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(467, 192);
            this.guna2Panel1.TabIndex = 0;
            // 
            // bPrint
            // 
            this.bPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bPrint.ForeColor = System.Drawing.Color.White;
            this.bPrint.Location = new System.Drawing.Point(341, 116);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(120, 45);
            this.bPrint.TabIndex = 10;
            this.bPrint.Text = "In Danh Sách";
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bRes
            // 
            this.bRes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bRes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bRes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bRes.ForeColor = System.Drawing.Color.White;
            this.bRes.Location = new System.Drawing.Point(213, 116);
            this.bRes.Name = "bRes";
            this.bRes.Size = new System.Drawing.Size(122, 45);
            this.bRes.TabIndex = 9;
            this.bRes.Text = "Làm mới";
            this.bRes.Click += new System.EventHandler(this.bRes_Click);
            // 
            // txtDate
            // 
            this.txtDate.Checked = true;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDate.Location = new System.Drawing.Point(213, 15);
            this.txtDate.MaxDate = new System.DateTime(2023, 4, 22, 5, 21, 53, 0);
            this.txtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(248, 45);
            this.txtDate.TabIndex = 8;
            this.txtDate.Value = new System.DateTime(2023, 4, 22, 0, 0, 0, 0);
            // 
            // bSpend
            // 
            this.bSpend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bSpend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bSpend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bSpend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bSpend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bSpend.ForeColor = System.Drawing.Color.White;
            this.bSpend.Location = new System.Drawing.Point(341, 65);
            this.bSpend.Name = "bSpend";
            this.bSpend.Size = new System.Drawing.Size(120, 45);
            this.bSpend.TabIndex = 7;
            this.bSpend.Text = "Chi";
            this.bSpend.Click += new System.EventHandler(this.bSpend_Click);
            // 
            // bErn
            // 
            this.bErn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bErn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bErn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bErn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bErn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bErn.ForeColor = System.Drawing.Color.White;
            this.bErn.Location = new System.Drawing.Point(213, 65);
            this.bErn.Name = "bErn";
            this.bErn.Size = new System.Drawing.Size(122, 45);
            this.bErn.TabIndex = 6;
            this.bErn.Text = "Thu";
            this.bErn.Click += new System.EventHandler(this.bErn_Click);
            // 
            // bYear
            // 
            this.bYear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bYear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bYear.ForeColor = System.Drawing.Color.White;
            this.bYear.Location = new System.Drawing.Point(27, 116);
            this.bYear.Name = "bYear";
            this.bYear.Size = new System.Drawing.Size(180, 45);
            this.bYear.TabIndex = 2;
            this.bYear.Text = "Theo Năm";
            this.bYear.Click += new System.EventHandler(this.bYear_Click);
            // 
            // bMonth
            // 
            this.bMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bMonth.ForeColor = System.Drawing.Color.White;
            this.bMonth.Location = new System.Drawing.Point(27, 65);
            this.bMonth.Name = "bMonth";
            this.bMonth.Size = new System.Drawing.Size(180, 45);
            this.bMonth.TabIndex = 1;
            this.bMonth.Text = "Theo Tháng";
            this.bMonth.Click += new System.EventHandler(this.bMonth_Click);
            // 
            // bDay
            // 
            this.bDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bDay.ForeColor = System.Drawing.Color.White;
            this.bDay.Location = new System.Drawing.Point(27, 15);
            this.bDay.Name = "bDay";
            this.bDay.Size = new System.Drawing.Size(180, 44);
            this.bDay.TabIndex = 0;
            this.bDay.Text = "Theo Ngày";
            this.bDay.Click += new System.EventHandler(this.bDay_Click);
            // 
            // dtView
            // 
            this.dtView.AllowUserToAddRows = false;
            this.dtView.AllowUserToDeleteRows = false;
            this.dtView.AllowUserToResizeColumns = false;
            this.dtView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtView.BackgroundColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtView.GridColor = System.Drawing.Color.SkyBlue;
            this.dtView.Location = new System.Drawing.Point(0, 0);
            this.dtView.Name = "dtView";
            this.dtView.ReadOnly = true;
            this.dtView.RowHeadersVisible = false;
            this.dtView.RowHeadersWidth = 51;
            this.dtView.RowTemplate.Height = 24;
            this.dtView.Size = new System.Drawing.Size(1545, 438);
            this.dtView.TabIndex = 1;
            this.dtView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtView.ThemeStyle.BackColor = System.Drawing.Color.Blue;
            this.dtView.ThemeStyle.GridColor = System.Drawing.Color.SkyBlue;
            this.dtView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtView.ThemeStyle.HeaderStyle.Height = 30;
            this.dtView.ThemeStyle.ReadOnly = true;
            this.dtView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtView.ThemeStyle.RowsStyle.Height = 24;
            this.dtView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtView_CellClick);
            // 
            // TaiLieu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.tControl);
            this.Name = "TaiLieu";
            this.Size = new System.Drawing.Size(1545, 650);
            this.tControl.ResumeLayout(false);
            this.HD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtCTView)).EndInit();
            this.TC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtThuChi)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tControl;
        private System.Windows.Forms.TabPage HD;
        private Guna.UI2.WinForms.Guna2DataGridView dtCTView;
        private System.Windows.Forms.TabPage TC;
        private Guna.UI2.WinForms.Guna2DataGridView dtView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2DataGridView dtThuChi;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button bYear;
        private Guna.UI2.WinForms.Guna2Button bMonth;
        private Guna.UI2.WinForms.Guna2Button bDay;
        private Guna.UI2.WinForms.Guna2Button bSpend;
        private Guna.UI2.WinForms.Guna2Button bErn;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDate;
        private Guna.UI2.WinForms.Guna2Button bRes;
        private Guna.UI2.WinForms.Guna2Button bPrint;
    }
}
