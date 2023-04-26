namespace ThuThuy.App.QuanLyTab
{
    partial class ReqLIst
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtViewUnCheck = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtViewCheck = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bAct = new Guna.UI2.WinForms.Guna2Button();
            this.bDel = new Guna.UI2.WinForms.Guna2Button();
            this.bAllA = new Guna.UI2.WinForms.Guna2Button();
            this.bAllD = new Guna.UI2.WinForms.Guna2Button();
            this.bRes = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewUnCheck)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dtViewUnCheck);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Azure;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(700, 500);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Danh Sách Yêu Cầu";
            // 
            // dtViewUnCheck
            // 
            this.dtViewUnCheck.AllowUserToAddRows = false;
            this.dtViewUnCheck.AllowUserToDeleteRows = false;
            this.dtViewUnCheck.AllowUserToResizeColumns = false;
            this.dtViewUnCheck.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtViewUnCheck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtViewUnCheck.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtViewUnCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtViewUnCheck.ColumnHeadersHeight = 20;
            this.dtViewUnCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtViewUnCheck.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtViewUnCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtViewUnCheck.GridColor = System.Drawing.Color.Silver;
            this.dtViewUnCheck.Location = new System.Drawing.Point(0, 40);
            this.dtViewUnCheck.Name = "dtViewUnCheck";
            this.dtViewUnCheck.ReadOnly = true;
            this.dtViewUnCheck.RowHeadersVisible = false;
            this.dtViewUnCheck.RowHeadersWidth = 51;
            this.dtViewUnCheck.RowTemplate.Height = 24;
            this.dtViewUnCheck.Size = new System.Drawing.Size(700, 460);
            this.dtViewUnCheck.TabIndex = 0;
            this.dtViewUnCheck.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtViewUnCheck.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtViewUnCheck.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtViewUnCheck.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtViewUnCheck.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtViewUnCheck.ThemeStyle.BackColor = System.Drawing.Color.Snow;
            this.dtViewUnCheck.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dtViewUnCheck.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtViewUnCheck.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtViewUnCheck.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtViewUnCheck.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtViewUnCheck.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtViewUnCheck.ThemeStyle.HeaderStyle.Height = 20;
            this.dtViewUnCheck.ThemeStyle.ReadOnly = true;
            this.dtViewUnCheck.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtViewUnCheck.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtViewUnCheck.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtViewUnCheck.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Azure;
            this.dtViewUnCheck.ThemeStyle.RowsStyle.Height = 24;
            this.dtViewUnCheck.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtViewUnCheck.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtViewUnCheck.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtViewUnCheck_CellContentDoubleClick);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.BorderThickness = 5;
            this.guna2GroupBox2.Controls.Add(this.dtViewCheck);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.AliceBlue;
            this.guna2GroupBox2.Location = new System.Drawing.Point(700, 0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(700, 500);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Danh Sách Xác Nhận";
            // 
            // dtViewCheck
            // 
            this.dtViewCheck.AllowUserToAddRows = false;
            this.dtViewCheck.AllowUserToDeleteRows = false;
            this.dtViewCheck.AllowUserToResizeColumns = false;
            this.dtViewCheck.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtViewCheck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtViewCheck.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtViewCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtViewCheck.ColumnHeadersHeight = 20;
            this.dtViewCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtViewCheck.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtViewCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtViewCheck.GridColor = System.Drawing.Color.Silver;
            this.dtViewCheck.Location = new System.Drawing.Point(0, 40);
            this.dtViewCheck.Name = "dtViewCheck";
            this.dtViewCheck.ReadOnly = true;
            this.dtViewCheck.RowHeadersVisible = false;
            this.dtViewCheck.RowHeadersWidth = 40;
            this.dtViewCheck.RowTemplate.Height = 24;
            this.dtViewCheck.ShowCellErrors = false;
            this.dtViewCheck.ShowCellToolTips = false;
            this.dtViewCheck.ShowEditingIcon = false;
            this.dtViewCheck.ShowRowErrors = false;
            this.dtViewCheck.Size = new System.Drawing.Size(700, 460);
            this.dtViewCheck.TabIndex = 0;
            this.dtViewCheck.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtViewCheck.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtViewCheck.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtViewCheck.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtViewCheck.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtViewCheck.ThemeStyle.BackColor = System.Drawing.Color.Snow;
            this.dtViewCheck.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dtViewCheck.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtViewCheck.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtViewCheck.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtViewCheck.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtViewCheck.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtViewCheck.ThemeStyle.HeaderStyle.Height = 20;
            this.dtViewCheck.ThemeStyle.ReadOnly = true;
            this.dtViewCheck.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtViewCheck.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtViewCheck.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtViewCheck.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dtViewCheck.ThemeStyle.RowsStyle.Height = 24;
            this.dtViewCheck.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtViewCheck.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtViewCheck.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtViewCheck_CellContentDoubleClick);
            // 
            // bAct
            // 
            this.bAct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bAct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bAct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bAct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bAct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bAct.ForeColor = System.Drawing.Color.White;
            this.bAct.Location = new System.Drawing.Point(1402, 141);
            this.bAct.Name = "bAct";
            this.bAct.Size = new System.Drawing.Size(143, 66);
            this.bAct.TabIndex = 2;
            this.bAct.Text = "Xác Nhận";
            this.bAct.Click += new System.EventHandler(this.bAct_Click);
            // 
            // bDel
            // 
            this.bDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bDel.ForeColor = System.Drawing.Color.White;
            this.bDel.Location = new System.Drawing.Point(1402, 283);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(143, 63);
            this.bDel.TabIndex = 3;
            this.bDel.Text = "Hủy";
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bAllA
            // 
            this.bAllA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bAllA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bAllA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bAllA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bAllA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bAllA.ForeColor = System.Drawing.Color.White;
            this.bAllA.Location = new System.Drawing.Point(1402, 213);
            this.bAllA.Name = "bAllA";
            this.bAllA.Size = new System.Drawing.Size(143, 64);
            this.bAllA.TabIndex = 4;
            this.bAllA.Text = "Xác Nhận Tất Cả";
            this.bAllA.Click += new System.EventHandler(this.bAllA_Click);
            // 
            // bAllD
            // 
            this.bAllD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bAllD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bAllD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bAllD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bAllD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bAllD.ForeColor = System.Drawing.Color.White;
            this.bAllD.Location = new System.Drawing.Point(1402, 352);
            this.bAllD.Name = "bAllD";
            this.bAllD.Size = new System.Drawing.Size(143, 65);
            this.bAllD.TabIndex = 5;
            this.bAllD.Text = "Hủy Tất Cả";
            this.bAllD.Click += new System.EventHandler(this.bAllD_Click);
            // 
            // bRes
            // 
            this.bRes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bRes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bRes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bRes.ForeColor = System.Drawing.Color.White;
            this.bRes.Location = new System.Drawing.Point(1402, 423);
            this.bRes.Name = "bRes";
            this.bRes.Size = new System.Drawing.Size(143, 62);
            this.bRes.TabIndex = 6;
            this.bRes.Text = "Chọn lại";
            this.bRes.Click += new System.EventHandler(this.bRes_Click);
            // 
            // ReqLIst
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.bRes);
            this.Controls.Add(this.bAllD);
            this.Controls.Add(this.bAllA);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bAct);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReqLIst";
            this.Size = new System.Drawing.Size(1545, 500);
            this.Load += new System.EventHandler(this.ReqLIst_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewUnCheck)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dtViewUnCheck;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dtViewCheck;
        private Guna.UI2.WinForms.Guna2Button bAct;
        private Guna.UI2.WinForms.Guna2Button bDel;
        private Guna.UI2.WinForms.Guna2Button bAllA;
        private Guna.UI2.WinForms.Guna2Button bAllD;
        private Guna.UI2.WinForms.Guna2Button bRes;
    }
}
