using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using ThuThuy.BLL;

namespace ThuThuy.App.QuanLyTab
{
    public partial class Register_form : UserControl
    {
        private string ID_NV;
        int SoNgayLam;
        public Register_form()
        {
            InitializeComponent();
        }

        private void Register_form_Load(object sender, EventArgs e)
        {
            bDis.Enabled = false;
            bAdd.Enabled = false;
            bFix.Enabled = false;
            bSave.Enabled = true;
            Warning.Hide();
            ClassRegister objnv = new ClassRegister();
            this.txtName.Enter += new EventHandler(txtName_Enter);
            this.txtName.Leave += new EventHandler(txtName_Leave);
            txtName_SetText();
            this.txtUserName.Enter += new EventHandler(txtUserName_Enter);
            this.txtUserName.Leave += new EventHandler(txtUserName_Leave);
            txtUserName_SetText();
            this.txtPass.Enter += new EventHandler(txtPass_Enter);
            this.txtPass.Leave += new EventHandler(txtPass_Leave);
            txtPass_SetText();
            this.txtSDT.Enter += new EventHandler(txtSDT_Enter);
            this.txtSDT.Leave += new EventHandler(txtSDT_Leave);
            txtSDT_SetText();
            this.txtNumdate.Enter += new EventHandler(txtNumdate_Enter);
            this.txtNumdate.Leave += new EventHandler(txtNumdate_Leave);
            txtNumdate_SetText();
            this.txtSalaryPD.Enter += new EventHandler(txtSalaryPD_Enter);
            this.txtSalaryPD.Leave += new EventHandler(txtSalaryPD_Leave);
            txtSalaryPD_SetText();
            cbChucVu.SelectedIndex = 3;
            dtView.DataSource = objnv.ViewData();
            dtView.Columns[0].Visible = false;
            dtView.Columns[1].HeaderText = "Tên";
            dtView.Columns[2].HeaderText = "Số điện thoại";
            dtView.Columns[3].HeaderText = "Số ngày nghỉ trong tháng";
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Equals("Nhập tên..."))
            {
                Warning.Show();
                Warning.Text = "Xin vui lòng nhập tên nhân viên";
                txtName.Focus();
                return;
            }
            if (txtUserName.Text.Equals("Nhập tên đăng nhập..."))
            {
                Warning.Show();
                Warning.Text = "Xin vui lòng nhập tên đăng nhập cho nhân viên";
                txtUserName.Focus();
                return;
            }
            if (txtPass.Text.Equals("Nhập mật khẩu..."))
            {
                Warning.Show();
                Warning.Text = "Xin vui lòng nhập mật khẩu cho nhân viên";
                txtPass.Focus();
                return;
            }
            if (txtSDT.Text.Equals( "Nhập số điện thoại..."))
            {
                Warning.Show();
                Warning.Text = "Xin vui lòng nhập số điện thoại nhân viên";
                txtSDT.Focus();
                return;
            }
            if (txtNumdate.Text.Equals( "Nhập số ngày làm..."))
            {
                Warning.Show();
                Warning.Text = "Xin vui lòng nhập số ngày làm trong tháng cho nhân viên";
                txtNumdate.Focus();
                return;
            }
            if (txtSalaryPD.Text.Equals( "Nhập mức lương theo ngày..."))
            {
                Warning.Show();
                Warning.Text = "Xin vui lòng nhập mức lương theo ngày cho nhân viên";
                txtSalaryPD.Focus();
                return;
            }
            ClassRegister objre = new ClassRegister();
            int numId;
            bool gender=true;
            if (cbChucVu.SelectedIndex == 0)
            {
                numId = 1;
            }
            else if (cbChucVu.SelectedIndex == 1)
            {
                numId = 2;
            }
            else if (cbChucVu.SelectedIndex == 2)
            {
                numId = 3;
            }
            else
            {
                Warning.Show();
                Warning.Text = "Xin vui lòng chọn chức vụ nhân viên";
                return;
            }
            if (rbMale.Checked == true)
            {
                gender = false;
            }
            else if (rbFemale.Checked == true)
            {
                gender = true;
            }
            else
            {
                Warning.Show();
                Warning.Text = "Xin vui lòng chọn giới tính nhân viên";
                return;
            }
            String id = objre.phatsinhTudong(numId);
            if (objre.SaveItems(id, txtUserName.Text, txtPass.Text, numId, txtName.Text, txtSDT.Text, txtNgaySinh.Text, gender, Convert.ToInt32(txtNumdate.Text), Convert.ToInt32(txtSalaryPD.Text), (Convert.ToInt32(txtNumdate.Text) * Convert.ToInt32(txtSalaryPD.Text))))
            {
                MessageBox.Show("Đã thêm");
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        protected void txtName_SetText()
        {
            this.txtName.Text = "Nhập tên...";
            txtName.ForeColor = Color.Gray;
        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.ForeColor == Color.Black)
                return;
            if(!txtName.Text.Equals("Nhập tên...") && !txtName.Text.Equals(""))
            {
                Warning.Hide();
            }
            else
            {
                txtName.Text = "";
            }
            txtName.ForeColor = Color.Black;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() == "")
                txtName_SetText();
            string regexC = "[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]";
            string Char;
            foreach(char c in txtName.Text)
            {
                Char = c.ToString();
                if (!Regex.IsMatch(Char,regexC))
                {
                    Warning.Show();
                    Warning.Text = "Không được để trống hoặc chứa số hoặc ký tự đặc biệt";
                    txtName.Focus();
                    return;
                }
            }
            if (txtName.Text.Length < 3 || txtName.Text.Length >50)
            {
                Warning.Show();
                Warning.Text = "Độ dài tên không được ít hơn 3 hoặc dài hơn 50 ký tự";
                txtName.Focus();
                return;
            }
        }

        protected void txtUserName_SetText()
        {
            this.txtUserName.Text = "Nhập tên đăng nhập...";
            txtUserName.ForeColor = Color.Gray;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.ForeColor == Color.Black)
                return;
            if (!txtUserName.Text.Equals("Nhập tên đăng nhập...") && !txtUserName.Text.Equals(""))
            {
                Warning.Hide();
            }
            else
            {
                txtUserName.Text = "";
            }
            txtUserName.ForeColor = Color.Black;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
                txtUserName_SetText();
            string regexC = "[A-Za-z0-9_]";
            string Char;
            foreach (char c in txtUserName.Text)
            {
                Char = c.ToString();
                if (!Regex.IsMatch(Char, regexC))
                {
                    Warning.Show();
                    Warning.Text = "Không được để trống hoặc ký tự đặc biệt trừ _";
                    txtUserName.Focus();
                    return;
                }
            }
            if (txtUserName.Text.Length < 8 || txtUserName.Text.Length > 30)
            {
                Warning.Show();
                Warning.Text = "Độ dài tên đăng nhập không được ít hơn 8 hoặc dài hơn 30 ký tự";
                txtUserName.Focus();
                return;
            }
            ClassRegister objNV = new ClassRegister();
            if (objNV.confirmExist(txtUserName.Text))
            {
                Warning.Show();
                Warning.Text = "Đã tồn tại tài khoản này trong hệ thống";
                txtUserName.Focus();
                return;
            }
        }
        protected void txtPass_SetText()
        {
            this.txtPass.Text = "Nhập mật khẩu...";
            txtPass.ForeColor = Color.Gray;
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.ForeColor == Color.Black)
                return;
            if (!txtPass.Text.Equals("Nhập mật khẩu...") && !txtPass.Text.Equals(""))
            {
                Warning.Hide();
            }
            else
            {
                txtPass.Text = "";
            }
            txtPass.ForeColor = Color.Black;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() == "")
                txtPass_SetText();
            string regexC = "[A-Za-z0-9]";
            string Char;
            foreach (char c in txtPass.Text)
            {
                Char = c.ToString();
                if (!Regex.IsMatch(Char, regexC))
                {
                    Warning.Show();
                    Warning.Text = "Không được để trống hoặc ký tự đặc biệt";
                    txtPass.Focus();
                    return;
                }
            }
            if (txtPass.Text.Length < 8 || txtPass.Text.Length > 30)
            {
                Warning.Show();
                Warning.Text = "Độ dài mật khẩu không được ít hơn 8 hoặc dài hơn 30 ký tự";
                txtPass.Focus();
                return;
            }
        }
        protected void txtSDT_SetText()
        {
            this.txtSDT.Text = "Nhập số điện thoại...";
            txtSDT.ForeColor = Color.Gray;
        }
        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.ForeColor == Color.Black)
                return;
            if (!txtSDT.Text.Equals("Nhập số điện thoại...") && !txtSDT.Text.Equals(""))
            {
                Warning.Hide();
            }
            else
            {
                txtSDT.Text = "";
            }
            txtSDT.ForeColor = Color.Black;
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim() == "")
                txtSDT_SetText();
            string regexC = "[0-9]";
            string Char;
            char s = txtSDT.Text[0];
            foreach (char c in txtSDT.Text)
            {
                Char = c.ToString();
                if (!Regex.IsMatch(Char, regexC))
                {
                    Warning.Show();
                    Warning.Text = "Không được để trống hoặc chứa chữ hoặc ký tự đặc biệt";
                    txtSDT.Focus();
                    return;
                }
            }

            if (s!='0')
            {
                Warning.Show();
                Warning.Text = "Đây không phải số điện thoại Việt Nam";
                txtSDT.Focus();
                return;
            }
        }
        protected void txtNumdate_SetText()
        {
            this.txtNumdate.Text = "Nhập số ngày làm...";
            txtNumdate.ForeColor = Color.Gray;
        }
        private void txtNumdate_Enter(object sender, EventArgs e)
        {
            if (txtNumdate.ForeColor == Color.Black)
                return;
            if (!txtNumdate.Text.Equals("Nhập số ngày làm...") && !txtNumdate.Text.Equals(""))
            {
                Warning.Hide();
            }
            else
            {
                txtNumdate.Text = "";
            }
            txtNumdate.ForeColor = Color.Black;
        }

        private void txtNumdate_Leave(object sender, EventArgs e)
        {
            if (txtNumdate.Text.Trim() == "")
                txtNumdate_SetText();
            string regexC = "[0-9]";
            string Char;
            char s = txtNumdate.Text[0];
            foreach (char c in txtNumdate.Text)
            {
                Char = c.ToString();
                if (!Regex.IsMatch(Char, regexC))
                {
                    Warning.Show();
                    Warning.Text = "Không được để trống hoặc chứa chữ hoặc ký tự đặc biệt";
                    txtNumdate.Focus();
                    return;
                }
            }

            if (s == '0')
            {
                Warning.Show();
                Warning.Text = "Không được nhập số 0 đầu tiên";
                txtNumdate.Focus();
                return;
            }
        }
        protected void txtSalaryPD_SetText()
        {
            this.txtSalaryPD.Text = "Nhập mức lương theo ngày...";
            txtSalaryPD.ForeColor = Color.Gray;
        }
        private void txtSalaryPD_Enter(object sender, EventArgs e)
        {
            if (txtSalaryPD.ForeColor == Color.Black)
                return;
            if (!txtSalaryPD.Text.Equals("Nhập mức lương theo ngày...") && !txtSalaryPD.Text.Equals(""))
            {
                Warning.Hide();
            }
            else
            {
                txtSalaryPD.Text = "";
            }
            txtSalaryPD.ForeColor = Color.Black;
        }

        private void txtSalaryPD_Leave(object sender, EventArgs e)
        {
            if (txtSalaryPD.Text.Trim() == "")
                txtSalaryPD_SetText();
            string regexC = "[0-9]";
            string Char;
            char s = txtSalaryPD.Text[0];
            foreach (char c in txtSalaryPD.Text)
            {
                Char = c.ToString();
                if (!Regex.IsMatch(Char, regexC))
                {
                    Warning.Show();
                    Warning.Text = "Không được để trống hoặc chứa chữ hoặc ký tự đặc biệt";
                    txtSalaryPD.Focus();
                    return;
                }
            }

            if (s == '0')
            {
                Warning.Show();
                Warning.Text = "Không được nhập số 0 đầu tiên";
                txtSalaryPD.Focus();
                return;
            }
        }
        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rbFemale.Enabled = false;
            rbMale.Enabled = false;
            bSave.Enabled = false;
            bDis.Enabled = true;
            bAdd.Enabled = true;
            bFix.Enabled = true;
            if (e.RowIndex < 0) return;
            ClassRegister objNV = new ClassRegister();
            DataRow dt = objNV.ViewInfo(dtView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dt[1].ToString();
            txtName.Enabled = false;
            txtUserName.Text = dt[2].ToString();
            txtUserName.Enabled = false;
            txtPass.Text = dt[3].ToString();
            txtSDT.Text = dt[4].ToString();
            if (Int32.Parse(dt[5].ToString())==0)
            {
                cbChucVu.Text = "Vô hiệu";
                bDis.Enabled = false;
            }
            else
            {
                cbChucVu.SelectedIndex = Int32.Parse(dt[5].ToString())-1;
                bDis.Enabled=true;
            }
            string date = dt[6].ToString();
            DateTime myDate = DateTime.Parse(date);
            txtNgaySinh.Text = myDate.ToString("dd/MM/yyyy");
            txtNgaySinh.Enabled = false;
            txtNumdate.Text = dt[7].ToString();
            SoNgayLam = Int32.Parse(dt[7].ToString());
            txtSalaryPD.Text = dt[8].ToString();
            ID_NV = dtView.SelectedCells[0].Value.ToString();
        }
        private void cbChucVu_MouseClick(object sender, MouseEventArgs e)
        {
            cbChucVu.Items.Remove("Chọn Chức Vụ");
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            bSave.Enabled = true;
            bDis.Enabled = false;
            bAdd.Enabled = false;
            bFix.Enabled = false;
            rbFemale.Enabled = true;
            rbMale.Enabled = true;
            txtName.Enabled = true;
            txtUserName.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtName_SetText();
            txtUserName_SetText();
            txtPass_SetText();
            txtSDT_SetText();
            txtNgaySinh.Clear();
            txtNumdate_SetText();
            txtSalaryPD_SetText();
            txtName.Focus();
        }

        private void bDis_Click(object sender, EventArgs e)
        {
            ClassRegister objNV = new ClassRegister();
            if (objNV.DisableACC(ID_NV))
            {
                bDis.Enabled = false;
            }
        }

        private void bFix_Click(object sender, EventArgs e)
        {
            ClassRegister objNV = new ClassRegister();
            if(SoNgayLam > Int32.Parse(txtNumdate.Text))
            {
                objNV.SaveItemsNN((SoNgayLam - Int32.Parse(txtNumdate.Text)),ID_NV);
            }
            if (objNV.confirmChange(ID_NV, txtUserName.Text, txtPass.Text, cbChucVu.SelectedIndex+1, txtSDT.Text, txtNgaySinh.Text, Convert.ToInt32(txtNumdate.Text), Convert.ToInt32(txtSalaryPD.Text), (Convert.ToInt32(txtNumdate.Text) * Convert.ToInt32(txtSalaryPD.Text))))
            {
                MessageBox.Show("Đã Sửa");
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
            dtView.DataSource = objNV.ViewData();
        }
    }
}
