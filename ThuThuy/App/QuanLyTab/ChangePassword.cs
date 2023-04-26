using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThuy.BLL;

namespace ThuThuy.App.QuanLyTab
{
    public partial class ChangePassword : Form
    {
        string UserName;
        public ChangePassword(String UserName)
        {
            this.UserName = UserName;
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            warning.Hide();
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            ClassRegister objre = new ClassRegister();
            if ((txtNewPassword.Text.Trim().Length == 0))
            {
                warning.Text = "Bạn chưa nhập mật khẩu mới";
                warning.Show();
                txtNewPassword.Focus();
                return;
            }
            if ((txtConfirmPassword.Text.Trim().Length == 0))
            {
                warning.Text = "Bạn chưa nhập mật khẩu xác nhận mới";
                warning.Show();
                txtConfirmPassword.Focus();
                return;
            }
            if ((txtNewPassword.TextLength < 5))
            {
                warning.Text = "Mật khẩu mới phải lớn hơn 5 ký tự";
                warning.Show();
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtNewPassword.Focus();
                return;
            }
            else if ((txtNewPassword.Text != txtConfirmPassword.Text))
            {
                warning.Text = "Hai mật khẩu chưa khớp với nhau";
                warning.Show();
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtNewPassword.Focus();
                return;
            }
            if (objre.confirmChange(UserName, txtConfirmPassword.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
