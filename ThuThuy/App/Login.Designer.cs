namespace ThuThuy.App
{
    partial class Login
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
            this.bLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.txt_User = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.iUser = new FontAwesome.Sharp.IconButton();
            this.iPass = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.warning = new System.Windows.Forms.Label();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.Transparent;
            this.bLogin.BorderRadius = 22;
            this.bLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bLogin.FillColor = System.Drawing.Color.White;
            this.bLogin.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.Color.SteelBlue;
            this.bLogin.Location = new System.Drawing.Point(100, 366);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(300, 45);
            this.bLogin.TabIndex = 0;
            this.bLogin.Text = "LOGIN";
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.MintCream;
            this.guna2Button2.Location = new System.Drawing.Point(460, 1);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(40, 40);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "X";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.Transparent;
            this.txt_User.BorderRadius = 25;
            this.txt_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_User.DefaultText = "User name";
            this.txt_User.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_User.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_User.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_User.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_User.Location = new System.Drawing.Point(130, 208);
            this.txt_User.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_User.Name = "txt_User";
            this.txt_User.PasswordChar = '\0';
            this.txt_User.PlaceholderText = "";
            this.txt_User.SelectedText = "";
            this.txt_User.Size = new System.Drawing.Size(270, 50);
            this.txt_User.TabIndex = 2;
            this.txt_User.TextOffset = new System.Drawing.Point(30, 0);
            this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
            this.txt_User.Enter += new System.EventHandler(this.txt_User_Enter);
            this.txt_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_User_KeyDown);
            this.txt_User.Leave += new System.EventHandler(this.txt_User_Leave);
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_Pass.BorderRadius = 25;
            this.txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pass.DefaultText = "Password";
            this.txt_Pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Pass.Location = new System.Drawing.Point(100, 284);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '\0';
            this.txt_Pass.PlaceholderText = "";
            this.txt_Pass.SelectedText = "";
            this.txt_Pass.Size = new System.Drawing.Size(270, 50);
            this.txt_Pass.TabIndex = 3;
            this.txt_Pass.TextOffset = new System.Drawing.Point(60, 0);
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            this.txt_Pass.Enter += new System.EventHandler(this.txt_Pass_Enter);
            this.txt_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pass_KeyDown);
            this.txt_Pass.Leave += new System.EventHandler(this.txt_Pass_Leave);
            // 
            // iUser
            // 
            this.iUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iUser.IconColor = System.Drawing.Color.SkyBlue;
            this.iUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iUser.IconSize = 30;
            this.iUser.Location = new System.Drawing.Point(100, 203);
            this.iUser.Name = "iUser";
            this.iUser.Size = new System.Drawing.Size(60, 60);
            this.iUser.TabIndex = 4;
            this.iUser.UseVisualStyleBackColor = true;
            // 
            // iPass
            // 
            this.iPass.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.iPass.IconColor = System.Drawing.Color.SteelBlue;
            this.iPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPass.IconSize = 30;
            this.iPass.Location = new System.Drawing.Point(350, 279);
            this.iPass.Name = "iPass";
            this.iPass.Size = new System.Drawing.Size(60, 60);
            this.iPass.TabIndex = 5;
            this.iPass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(144, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "USER LOGIN";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.BackColor = System.Drawing.Color.Transparent;
            this.warning.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(126, 341);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(80, 16);
            this.warning.TabIndex = 7;
            this.warning.Text = "Hiển thị Lỗi";
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(0, 470);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.Size = new System.Drawing.Size(500, 30);
            this.guna2ProgressBar1.TabIndex = 8;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iPass);
            this.Controls.Add(this.iUser);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.bLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button bLogin;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox txt_User;
        private Guna.UI2.WinForms.Guna2TextBox txt_Pass;
        private FontAwesome.Sharp.IconButton iUser;
        private FontAwesome.Sharp.IconButton iPass;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label warning;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Timer timer;
    }
}