namespace ThuThuy.App
{
    partial class QuanLy
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
            this.components = new System.ComponentModel.Container();
            this.barControl = new System.Windows.Forms.Panel();
            this.bTaiLieu = new FontAwesome.Sharp.IconButton();
            this.bDangKy = new FontAwesome.Sharp.IconButton();
            this.bMenu = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bKho = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bClose = new Guna.UI2.WinForms.Guna2Button();
            this.bartimer = new System.Windows.Forms.Timer(this.components);
            this.listKho = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.LogOut = new FontAwesome.Sharp.IconButton();
            this.barControl.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // barControl
            // 
            this.barControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barControl.Controls.Add(this.LogOut);
            this.barControl.Controls.Add(this.bTaiLieu);
            this.barControl.Controls.Add(this.bDangKy);
            this.barControl.Controls.Add(this.bMenu);
            this.barControl.Controls.Add(this.panel3);
            this.barControl.Controls.Add(this.bKho);
            this.barControl.Location = new System.Drawing.Point(0, 0);
            this.barControl.MaximumSize = new System.Drawing.Size(200, 800);
            this.barControl.MinimumSize = new System.Drawing.Size(55, 800);
            this.barControl.Name = "barControl";
            this.barControl.Size = new System.Drawing.Size(55, 800);
            this.barControl.TabIndex = 3;
            // 
            // bTaiLieu
            // 
            this.bTaiLieu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bTaiLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTaiLieu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTaiLieu.ForeColor = System.Drawing.Color.AliceBlue;
            this.bTaiLieu.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.bTaiLieu.IconColor = System.Drawing.Color.AliceBlue;
            this.bTaiLieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bTaiLieu.IconSize = 36;
            this.bTaiLieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTaiLieu.Location = new System.Drawing.Point(0, 300);
            this.bTaiLieu.Name = "bTaiLieu";
            this.bTaiLieu.Size = new System.Drawing.Size(200, 50);
            this.bTaiLieu.TabIndex = 4;
            this.bTaiLieu.Text = "         Số liệu";
            this.bTaiLieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTaiLieu.UseVisualStyleBackColor = false;
            this.bTaiLieu.Click += new System.EventHandler(this.bTaiLieu_Click);
            // 
            // bDangKy
            // 
            this.bDangKy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDangKy.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDangKy.ForeColor = System.Drawing.Color.AliceBlue;
            this.bDangKy.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.bDangKy.IconColor = System.Drawing.Color.AliceBlue;
            this.bDangKy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bDangKy.IconSize = 36;
            this.bDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDangKy.Location = new System.Drawing.Point(0, 250);
            this.bDangKy.Name = "bDangKy";
            this.bDangKy.Size = new System.Drawing.Size(200, 50);
            this.bDangKy.TabIndex = 3;
            this.bDangKy.Text = "         Đăng Ký";
            this.bDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDangKy.UseVisualStyleBackColor = false;
            this.bDangKy.Click += new System.EventHandler(this.bDangKy_Click);
            // 
            // bMenu
            // 
            this.bMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMenu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMenu.ForeColor = System.Drawing.Color.AliceBlue;
            this.bMenu.IconChar = FontAwesome.Sharp.IconChar.List;
            this.bMenu.IconColor = System.Drawing.Color.AliceBlue;
            this.bMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bMenu.IconSize = 36;
            this.bMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMenu.Location = new System.Drawing.Point(0, 50);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(200, 50);
            this.bMenu.TabIndex = 2;
            this.bMenu.Text = "         Menu";
            this.bMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMenu.UseVisualStyleBackColor = false;
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1300, 150);
            this.panel3.TabIndex = 1;
            // 
            // bKho
            // 
            this.bKho.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKho.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKho.ForeColor = System.Drawing.Color.AliceBlue;
            this.bKho.IconChar = FontAwesome.Sharp.IconChar.House;
            this.bKho.IconColor = System.Drawing.Color.AliceBlue;
            this.bKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bKho.IconSize = 36;
            this.bKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bKho.Location = new System.Drawing.Point(0, 200);
            this.bKho.Name = "bKho";
            this.bKho.Size = new System.Drawing.Size(200, 50);
            this.bKho.TabIndex = 0;
            this.bKho.Text = "         Kho";
            this.bKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bKho.UseVisualStyleBackColor = false;
            this.bKho.Click += new System.EventHandler(this.bKho_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(55, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1545, 100);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bClose);
            this.panel4.Location = new System.Drawing.Point(55, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1545, 50);
            this.panel4.TabIndex = 5;
            // 
            // bClose
            // 
            this.bClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bClose.FillColor = System.Drawing.Color.Red;
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(1467, 3);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(66, 45);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "X";
            this.bClose.Click += new System.EventHandler(this.bClose_Click_1);
            this.bClose.MouseLeave += new System.EventHandler(this.bClose_MouseLeave);
            this.bClose.MouseHover += new System.EventHandler(this.bClose_MouseHover);
            // 
            // bartimer
            // 
            this.bartimer.Interval = 10;
            this.bartimer.Tick += new System.EventHandler(this.bartimer_Tick);
            // 
            // listKho
            // 
            this.listKho.BackColor = System.Drawing.Color.Blue;
            this.listKho.Location = new System.Drawing.Point(55, 50);
            this.listKho.Name = "listKho";
            this.listKho.Size = new System.Drawing.Size(1545, 650);
            this.listKho.TabIndex = 6;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.Red;
            this.LogOut.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.LogOut.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.LogOut.IconColor = System.Drawing.Color.White;
            this.LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogOut.IconSize = 36;
            this.LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.Location = new System.Drawing.Point(-2, 701);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(200, 50);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "         Đăng xuất";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.barControl);
            this.Controls.Add(this.listKho);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.barControl.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barControl;
        private FontAwesome.Sharp.IconButton bKho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton bMenu;
        private System.Windows.Forms.Timer bartimer;
        private System.Windows.Forms.Panel listKho;
        private FontAwesome.Sharp.IconButton bDangKy;
        private FontAwesome.Sharp.IconButton bTaiLieu;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button bClose;
        private FontAwesome.Sharp.IconButton LogOut;
    }
}