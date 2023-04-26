using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThuy.App.QuanLyTab;
using ThuThuy.App;
using ThuThuy.BLL;
using ThuThuy.DAL;
using System.Windows.Documents;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Text.RegularExpressions;
using System.ServiceModel.Configuration;
using Excel = Microsoft.Office.Interop.Excel;

namespace ThuThuy.App
{
    public partial class NhanVien : Form
    {
        public String id;
        public String id_hd;
        public String id_dv;
        public NhanVien(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            ClassSPI objre = new ClassSPI();
            ClassSPI objSP = new ClassSPI();
            dtView.DataSource = objSP.tb;
            dtView.Columns[0].Visible = false;
            dtView.Columns[2].Visible = false;
            dtView.Columns[4].Visible = false;
            dtView.Columns[1].HeaderText = "Tên Sản Phẩm";
            dtView.Columns[3].HeaderText = "Số Lượng";
            dtView.Columns[5].HeaderText = "Ngày Cập Nhật";
            dtView.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtView.Columns[6].HeaderText = "Tên NV Cập Nhật";
            cbItem.DataSource = objre.getNameI();
            cbItem.DisplayMember = "TEN";
            cbItemOut.DataSource = objre.getNameI();
            cbItemOut.DisplayMember = "TEN";
            warReq.Hide();
            this.txtDonGia.Enter += new EventHandler(txtDonGia_Enter);
            this.txtDonGia.Leave += new EventHandler(txtDonGia_Leave);
            txtDonGia_SetText();
            ClassITYC objM = new ClassITYC();
            dtReady.DataSource = objM.GetItems_READY();
            dtReady.Columns[0].Visible = false;
            dtReady.Columns[1].HeaderText = "Tên Sản Phẩm";
            dtReady.Columns[2].HeaderText = "Số Lượng";
            dtReady.Columns[3].Visible = false;
            dtReady.Columns[4].Visible = false;
            dtUpdate.DataSource = objM.GetItems_Update();
            dtUpdate.Columns[0].Visible = false;
            dtUpdate.Columns[1].HeaderText = "Tên Sản Phẩm";
            dtUpdate.Columns[2].HeaderText = "Số Lượng";
            dtUpdate.Columns[3].Visible = false;
            dtUpdate.Columns[4].Visible = false;
            this.txtName.Enter += new EventHandler(txtName_Enter);
            this.txtName.Leave += new EventHandler(txtName_Leave);
            txtName_SetText();
            this.txtSDT.Enter += new EventHandler(txtSDT_Enter);
            this.txtSDT.Leave += new EventHandler(txtSDT_Leave);
            txtSDT_SetText();
            bEdit.Enabled = false;
            txtDes.ReadOnly = true;
            ClassKHI objKHI = new ClassKHI();
            dtViewKH.DataSource = objKHI.GetItems();
            dtViewKH.Columns[0].Visible = false;
            dtViewKH.Columns[3].Visible = false;
            dtViewKH.Columns[4].Visible = false;
            dtViewKH.Columns[5].Visible = false;
            dtViewKH.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtViewKH.Columns[1].HeaderText = "Tên khách hàng";
            dtViewKH.Columns[2].HeaderText = "Số điện thoại";
            Warning.Visible = false;
            dtViewDV.Enabled = false;
            dtViewHD.Enabled = false;
            bDone.Enabled = false;
            bClear.Enabled = false;
            ClassDVI objDVI = new ClassDVI();
            dtViewDV.DataSource = objDVI.GetItems();
            dtViewDV.Columns[0].Visible = false;
            dtViewDV.Columns[1].HeaderText = "Tên dịch vụ";
            dtViewDV.Columns[2].HeaderText = "Giá dịch vụ";
            this.txtFind.Enter += new EventHandler(txtFind_Enter);
            this.txtFind.Leave += new EventHandler(txtFind_Leave);
            txtFind_SetText();
            txtSLDV.Enabled = false;
            bUpSL.Enabled = false;
            printHD.Enabled = false;
        }

        private void bReq_Click(object sender, EventArgs e)
        {
            ClassITYC objre = new ClassITYC();
            ClassSPI objSP = new ClassSPI();
            String id_YC = objre.phatsinhTudong();
            try 
            {
                objre.SaveItems(id_YC, objSP.getID(cbItem.Text), this.id, Convert.ToInt32(txtNum.Value), Convert.ToInt32(txtDonGia.Text));
                MessageBox.Show("Đã thêm");
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ClassNKI objNK = new ClassNKI();
            ClassITYC objITYC = new ClassITYC();
            ClassSPI objSP = new ClassSPI();
            String Id = objNK.phatsinhTudong();
            objNK.SaveItemsPNK(Id, this.id);
            foreach(DataGridViewRow row in dtUpdate.Rows)
            {
                objNK.SaveItemsCTNK(Id, row.Cells[1].Value.ToString(), Int32.Parse(row.Cells[2].Value.ToString()), Int32.Parse(row.Cells[3].Value.ToString()));
                objITYC.statusToDone(row.Cells[0].Value.ToString());
                objSP.slUpdate(row.Cells[1].Value.ToString(), Int32.Parse(row.Cells[2].Value.ToString()), id);
            }
            dtReady.DataSource = objITYC.GetItems_READY();
            dtUpdate.DataSource = objITYC.GetItems_Update();
            ClassSPI objSPN = new ClassSPI();
            dtView.DataSource = objSPN.tb;
        }
        private void bAddAll_Click(object sender, EventArgs e)
        {
            ClassNKI objNK = new ClassNKI();
            ClassITYC objITYC = new ClassITYC();
            ClassSPI objSP = new ClassSPI();
            String Id = objNK.phatsinhTudong();
            objNK.SaveItemsPNK(Id, this.id);
            foreach (DataGridViewRow row in dtUpdate.Rows)
            {
                objNK.SaveItemsCTNK(Id, row.Cells[1].Value.ToString(), Int32.Parse(row.Cells[2].Value.ToString()), Int32.Parse(row.Cells[3].Value.ToString()));
                objITYC.statusToDone(row.Cells[0].Value.ToString());
                objSP.slUpdate(row.Cells[1].Value.ToString(), Int32.Parse(row.Cells[2].Value.ToString()), id);
            }
            foreach (DataGridViewRow row in dtReady.Rows)
            {
                objNK.SaveItemsCTNK(Id, row.Cells[1].Value.ToString(), Int32.Parse(row.Cells[2].Value.ToString()), Int32.Parse(row.Cells[3].Value.ToString()));
                objITYC.statusToDone(row.Cells[0].Value.ToString());
                objSP.slUpdate(row.Cells[1].Value.ToString(), Int32.Parse(row.Cells[2].Value.ToString()), id);
            }
            dtReady.DataSource = objITYC.GetItems_READY();
            dtUpdate.DataSource = objITYC.GetItems_Update();
            ClassSPI objSPN = new ClassSPI();
            dtView.DataSource = objSPN.tb;
        }


        private void bExit_MouseHover(object sender, EventArgs e)
        {
            bExit.BackColor = Color.Red;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            ClassXKI objsXKI = new ClassXKI();
            string idP = objsXKI.getIDNew();
            if (objsXKI.countItemsCTXK(idP) == 0)
            {
                objsXKI.deleteNew(idP);
            }
            Application.Exit();
        }

        private void dtView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbItem.SelectedIndex = cbItem.FindStringExact(dtView.Rows[e.RowIndex].Cells[1].Value.ToString());
            cbItemOut.SelectedIndex = cbItemOut.FindString(dtView.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtNumberOut.Maximum = Int32.Parse(dtView.Rows[e.RowIndex].Cells[3].Value.ToString());
        }
        protected void txtDonGia_SetText()
        {
            this.txtDonGia.Text = "Nhập đơn giá nhập...";
            txtDonGia.ForeColor = Color.Gray;
        }
        private void txtDonGia_Enter(object sender, EventArgs e)
        {
            if (txtDonGia.ForeColor == Color.Black)
                return;
            if (!txtDonGia.Text.Equals("Nhập đơn giá nhập...") && !txtDonGia.Text.Equals(""))
            {
                warReq.Hide();
            }
            else
            {
                txtDonGia.Text = "";
            }
            txtDonGia.ForeColor = Color.Black;
        }

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            if(txtDonGia.Text.Trim() == "")
                txtDonGia_SetText();
            string regexC = "[0-9]";
            string Char;
            char s = txtDonGia.Text[0];
            foreach (char c in txtDonGia.Text)
            {
                Char = c.ToString();
                if (!Regex.IsMatch(Char, regexC))
                {
                    warReq.Show();
                    warReq.Text = "Không được để trống hoặc chứa chữ hoặc ký tự đặc biệt";
                    txtDonGia.Focus();
                    return;
                }
            }

            if (s == '0')
            {
                warReq.Show();
                warReq.Text = "Không được nhập số 0 đầu tiên";
                txtDonGia.Focus();
                return;
            }
        }

        private void dtReady_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassITYC objM = new ClassITYC();
            objM.statusToUpdate(dtReady.Rows[e.RowIndex].Cells[0].Value.ToString());
            dtReady.DataSource = objM.GetItems_READY();
            dtUpdate.DataSource = objM.GetItems_Update();
        }

        private void dtUpdate_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassITYC objM = new ClassITYC();
            objM.statusToReady(dtUpdate.Rows[e.RowIndex].Cells[0].Value.ToString());
            dtReady.DataSource = objM.GetItems_READY();
            dtUpdate.DataSource = objM.GetItems_Update();
        }

        private void guna2TabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl2.SelectedIndex == 2)
            {
                ClassXKI objXKI = new ClassXKI();
                string idP = objXKI.phatsinhTudong();
                objXKI.SaveItemsXK(idP,id);
                dtViewXK.DataSource = objXKI.GetItems(idP);
                dtViewXK.Columns[0].Visible = false;
                dtViewXK.Columns[1].HeaderText = "Tên sản phẩm";
                dtViewXK.Columns[2].HeaderText = "Số lượng";
            }
            else
            {
                ClassXKI objsXKI = new ClassXKI();
                string idP = objsXKI.getIDNew();
                if (objsXKI.countItemsCTXK(idP) == 0)
                {
                    objsXKI.deleteNew(idP);
                }
            }
        }

        private void bAddXK_Click(object sender, EventArgs e)
        {
            ClassXKI objXKI = new ClassXKI();
            objXKI.SaveItemsCTXK(objXKI.getIDNew(), cbItemOut.Text, Int32.Parse(txtNumberOut.Value.ToString()));
            dtViewXK.DataSource = objXKI.GetItems(objXKI.getIDNew());
        }

        private void bAcpXK_Click(object sender, EventArgs e)
        {
            ClassXKI objXKI = new ClassXKI();
            ClassSPI objSP = new ClassSPI();
            string idP = objXKI.phatsinhTudong();
            foreach(DataGridViewRow row in dtViewXK.Rows)
            {
                objSP.slUpdate(row.Cells[1].Value.ToString(), Int32.Parse(row.Cells[2].Value.ToString())*(-1), id);
            }
            objXKI.SaveItemsXK(idP, id);
            dtViewXK.DataSource = objXKI.GetItems(idP);
            ClassSPI objSPN = new ClassSPI();
            dtView.DataSource = objSPN.tb;
        }

        private void bResOut_Click(object sender, EventArgs e)
        {
            ClassXKI objXKI = new ClassXKI();
            objXKI.deleteAll(objXKI.getIDNew());
            dtViewXK.DataSource = objXKI.GetItems(objXKI.getIDNew());
        }

        private void dtViewXK_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassXKI objXKI = new ClassXKI();
            ClassSPI objSPI = new ClassSPI();
            objXKI.deleteSPID(objXKI.getIDNew(), objSPI.getID(dtViewXK.Rows[e.RowIndex].Cells[1].Value.ToString()));
            dtViewXK.DataSource = objXKI.GetItems(objXKI.getIDNew());
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("Nhập tên..."))
            {
                Warning.Show();
                Warning.Text = "Xin vui lòng nhập tên khách hàng";
                txtName.Focus();
                return;
            }
            if (txtSDT.Text.Equals("Nhập số điện thoại..."))
            {
                Warning.Show();
                Warning.Text = "Xin vui lòng nhập số điện thoại khách hàng";
                txtSDT.Focus();
                return;
            }
            ClassKHI objre = new ClassKHI();
            bool gender = true;
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
                Warning.Text = "Xin vui lòng chọn giới tính khách hàng";
                return;
            }
            String id_KH = objre.phatsinhTudong();
            if (objre.SaveItems(id_KH,txtName.Text,txtSDT.Text,txtDate.Value.ToString("yyyy/MM/dd"),gender,id))
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
            if (!txtName.Text.Equals("Nhập tên...") && !txtName.Text.Equals(""))
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
            if (txtName.Text.Trim() == "")
                txtName_SetText();
            string regexC = "[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]";
            string Char;
            foreach (char c in txtName.Text)
            {
                Char = c.ToString();
                if (!Regex.IsMatch(Char, regexC))
                {
                    Warning.Show();
                    Warning.Text = "Không được để trống hoặc chứa số hoặc ký tự đặc biệt";
                    txtName.Focus();
                    return;
                }
            }
            if (txtName.Text.Length < 3 || txtName.Text.Length > 50)
            {
                Warning.Show();
                Warning.Text = "Độ dài tên không được ít hơn 3 hoặc dài hơn 50 ký tự";
                txtName.Focus();
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

            if (s != '0')
            {
                Warning.Show();
                Warning.Text = "Đây không phải số điện thoại Việt Nam";
                txtSDT.Focus();
                return;
            }
        }
        private void dtViewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bEdit.Enabled = true;
            printHD.Enabled = true;
            bSave.Enabled = false;
            txtName.Text = dtViewKH.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSDT.Text = dtViewKH.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDate.Text = dtViewKH.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDes.Text = dtViewKH.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (dtViewKH.Rows[e.RowIndex].Cells[5].Value.ToString().Equals("0"))
            {
                rbFemale.Equals(true);
            }
            else
            {
                rbMale.Equals(true);
            }
            rbFemale.Enabled = false;
            rbMale.Enabled = false;
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            bSave.Enabled = true;
            bEdit.Enabled = false;
            rbFemale.Enabled = true;
            rbMale.Enabled = true;
            txtName.Enabled = true;
            txtName_SetText();
            txtSDT_SetText();
            txtName.Focus();
        }

        protected void txtFind_SetText()
        {
            this.txtFind.Text = "Nhập số điện thoại...";
            txtFind.ForeColor = Color.Gray;
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            if (txtFind.ForeColor == Color.Black)
                return;
            if (!txtFind.Text.Equals("Nhập số điện thoại...") && !txtFind.Text.Equals(""))
            {
                Warning.Hide();
            }
            else
            {
                txtFind.Text = "";
            }
            txtFind.ForeColor = Color.Black;
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            if (txtFind.Text.Trim() == "")
                txtFind_SetText();
            string regexC = "[0-9]";
            string Char;
            char s = txtFind.Text[0];
            foreach (char c in txtFind.Text)
            {
                Char = c.ToString();
                if (!Regex.IsMatch(Char, regexC))
                {
                    Warning.Show();
                    Warning.Text = "Không được để trống hoặc chứa chữ hoặc ký tự đặc biệt";
                    txtFind.Focus();
                    return;
                }
            }

            if (s != '0')
            {
                Warning.Show();
                Warning.Text = "Đây không phải số điện thoại Việt Nam";
                txtFind.Focus();
                return;
            }
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            ClassKHI objKHI = new ClassKHI();
            dtKH.DataSource = objKHI.GetItemsKH(txtFind.Text);
        }

        private void dtKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassVHD objVHD = new ClassVHD();
            ClassKHI objKH = new ClassKHI();
            this.id_hd = objVHD.phatsinhTudong();
            objVHD.SaveItems(id_hd, dtKH.Rows[e.RowIndex].Cells[0].Value.ToString(), id);
            khName.Text = dtKH.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtViewDV.Enabled = true;
            dtViewHD.Enabled = true;
            bDone.Enabled = true;
            bClear.Enabled = true;
            printHD.Enabled = true;
            dtKH.Enabled = false;
            bFind.Enabled = false;
            txtFind.Enabled = false;
            txtDes.Text = objKH.motaKH(objKH.getIdKH(dtKH.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }

        private void dtViewDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassVCTHD objCTHD = new ClassVCTHD();
            objCTHD.SaveItems(1, Int32.Parse(dtViewDV.Rows[e.RowIndex].Cells[2].Value.ToString()), dtViewDV.Rows[e.RowIndex].Cells[0].Value.ToString(),id_hd);
            dtViewHD.DataSource = objCTHD.ShowData(id_hd);
            dtViewHD.Columns[0].Visible = false;
            dtViewHD.Columns[1].Visible = false;
            dtViewHD.Columns[2].HeaderText = "Tên Dịch Vụ";
            dtViewHD.Columns[3].HeaderText = "Số Lượng";
            dtViewHD.Columns[4].HeaderText = "Giá (VNĐ)";
            price.Text = objCTHD.sumPrice(id_hd).ToString();
        }

        private void bDone_Click(object sender, EventArgs e)
        {
            dtViewHD.DataSource = null;
            dtKH.DataSource = null;
            txtFind.Text = null;
            bDone.Enabled = false;
            bClear.Enabled = false;
            printHD.Enabled = false;
            txtFind.Enabled = true;
            dtKH.Enabled = true;
            bFind.Enabled = true;
            txtFind_SetText();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            ClassVCTHD objVCTHD = new ClassVCTHD();
            objVCTHD.deleteAll(id_hd);
            dtViewHD.DataSource = objVCTHD.ShowData(id_hd);
            price.Text = objVCTHD.sumPrice(id_hd).ToString() + "đ";
        }

        private void dtViewHD_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassVCTHD objCTHD = new ClassVCTHD();
            objCTHD.deleteDV(id_hd, dtViewHD.Rows[e.RowIndex].Cells[1].Value.ToString());
            dtViewHD.DataSource = objCTHD.ShowData(id_hd);
            price.Text = objCTHD.sumPrice(id_hd).ToString() + "đ";
        }
        private void dtViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassVCTHD objCTHD = new ClassVCTHD();
            txtSLDV.Enabled = true;
            txtSLDV.Text = objCTHD.sl(id_hd, dtViewHD.Rows[e.RowIndex].Cells[1].Value.ToString()).ToString();
            bUpSL.Enabled = true;
            id_dv = dtViewHD.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void bUpSL_Click(object sender, EventArgs e)
        {
            ClassVCTHD objCTHD = new ClassVCTHD();
            objCTHD.updateSL(id_hd, id_dv, txtSLDV.Text);
            dtViewHD.DataSource = objCTHD.ShowData(id_hd);
            txtSLDV.Enabled = false;
            bUpSL.Enabled = false;
            price.Text = objCTHD.sumPrice(id_hd).ToString();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void copyAlltoClipboard()
        {
            dtViewHD.SelectAll();
            DataObject dataObj = dtViewHD.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void printHD_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

    }
}
