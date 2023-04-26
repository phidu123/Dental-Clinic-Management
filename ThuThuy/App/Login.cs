using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ThuThuy.App.QuanLyTab;
using ThuThuy.BLL;

namespace ThuThuy.App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            warning.Hide();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txt_User.Focus();
            guna2ProgressBar1.Hide();
        }
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(135, 206, 235), Color.FromArgb(79, 148, 205), 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Pass.ForeColor = Color.SteelBlue;
            }
            catch { }
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_User.ForeColor = Color.SteelBlue;
            }
            catch { }
        }
        private void txt_User_Leave(object sender, EventArgs e)
        {
            if (txt_User.Text == "")
            {
                txt_User.Text = "User name";
            }
        }

        private void txt_Pass_Leave(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "")
            {
                txt_Pass.PasswordChar = '\0';
                txt_Pass.Text = "Password";
            }
        }

        private void txt_User_Enter(object sender, EventArgs e)
        {
            if(txt_User.Text == "User name")
            {
                txt_User.Text = "";
            }
            else
            {
                if (txt_User.Text == "")
                {
                    txt_User.Text = "User name";
                }
            }
        }

        private void txt_Pass_Enter(object sender, EventArgs e)
        {
            if(txt_Pass.Text == "Password")
            {
                txt_Pass.PasswordChar = '*';
                txt_Pass.Text = "";
            }
            else
            {
                if (txt_Pass.Text == "")
                {
                    txt_Pass.PasswordChar = '\0';
                    txt_Pass.Text = "Password";
                }
            }
        }
        private void bLogin_Click(object sender, EventArgs e)
        {
            guna2ProgressBar1.Show();
            loadForm();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loadForm();
            }
        }
        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Pass.Focus();
            }
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadForm();
            }
        }
        private void loadForm()
        {
            this.timer.Start();
            if (txt_User.Text == "" || txt_User.Text == "User name")
            {
                warning.Text = "Bạn chưa nhập UserName";
                txt_User.Focus();
                warning.Show();
                return;
            }
            if (txt_Pass.Text == "" || txt_Pass.Text == "Password")
            {
                warning.Text = "Bạn chưa nhập Mật Khẩu";
                txt_Pass.Focus();
                warning.Show();
                return;
            }
            ClassRegister objre = new ClassRegister();
            if (objre.checkLogin(txt_User.Text, txt_Pass.Text) == 1 || objre.checkLogin(txt_User.Text, txt_Pass.Text) == 0)
            {
                QuanLy frm = new QuanLy(objre.strId(txt_User.Text));
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else if (objre.checkLogin(txt_User.Text, txt_Pass.Text) == 2)
            {
                NhanVien frm = new NhanVien(objre.strId(txt_User.Text));
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else if (objre.checkLogin(txt_User.Text, txt_Pass.Text) == 3)
            {
                BacSi frm = new BacSi(objre.strId(txt_User.Text));
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else if (objre.checkLogin(txt_User.Text, txt_Pass.Text) == -1)
            {
                warning.Text = "Tài khoản đã bị vô hiệu hóa" + (int)objre.checkLogin(txt_User.Text, txt_Pass.Text);
                txt_User.Text = "User name";
                txt_Pass.Text = "Password";
                warning.Show();
                return;
            }
            else
            {
                warning.Text = "Sai tài khoản hoặc mật khẩu" + (int)objre.checkLogin(txt_User.Text, txt_Pass.Text);
                txt_User.Text = "User name";
                txt_Pass.Text = "Password";
                warning.Show();
                return;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.guna2ProgressBar1.Increment(10);
        }
    }
}
