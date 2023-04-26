using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThuy.BLL;
using ThuThuy.App.QuanLyTab;
using Excel = Microsoft.Office.Interop.Excel;

namespace ThuThuy.App.QuanLyTab
{
    public partial class TaiLieu : UserControl
    {
        int pick = 0;
        DataTable dtCur;
        public TaiLieu()
        {
            InitializeComponent();
            ClassVHD hD =  new ClassVHD();
            ClassVCTHD cTHD = new ClassVCTHD();
            dtView.DataSource = hD.GetData();
            dtCur = hD.GetData();
            dtView.Columns[0].Visible = false;
            dtView.Columns[1].HeaderText = "Tên nhân viên";
            dtView.Columns[2].HeaderText = "Tên khách hàng";
            dtView.Columns[3].HeaderText = "Ngày tạo";
            dtView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtCTView.DataSource = cTHD.ShowData(dtView.Rows[0].Cells[0].Value.ToString());
            dtCTView.Columns[0].Visible = false;
            dtCTView.Columns[1].Visible = false;
            dtCTView.Columns[2].HeaderText = "Tên dịch vụ";
            dtCTView.Columns[3].HeaderText = "Số lượng";
            dtCTView.Columns[4].HeaderText = "Giá tiền";
        }

        private void tControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tControl.SelectedIndex == 0)
            {
                ClassVHD hD = new ClassVHD();
                ClassVCTHD cTHD = new ClassVCTHD();
                dtView.DataSource = null;
                dtView.DataSource = hD.GetData();
                dtCur = hD.GetData();
                dtView.Columns[0].Visible = false;
                dtView.Columns[1].HeaderText = "Tên nhân viên";
                dtView.Columns[2].HeaderText = "Tên khách hàng";
                dtView.Columns[3].HeaderText = "Ngày tạo";
                dtView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dtCTView.DataSource = cTHD.ShowData(dtView.Rows[0].Cells[0].Value.ToString());
                dtCTView.Columns[0].Visible = false;
                dtCTView.Columns[1].Visible = false;
                dtCTView.Columns[2].HeaderText = "Tên dịch vụ";
                dtCTView.Columns[3].HeaderText = "Số lượng";
                dtCTView.Columns[4].HeaderText = "Giá tiền";
                pick = 0;
            }
            else if (tControl.SelectedIndex == 1)
            {
                ClassTCI TC = new ClassTCI();
                dtView.DataSource = null;
                dtView.DataSource = TC.GetItems();
                dtView.Columns[0].Visible = false;
                dtView.Columns[3].HeaderText = "Tổng Tiền";
                dtCur = TC.GetItems();
                dtView.Columns[1].HeaderText = "Ngày tạo";
                dtView.Columns[2].HeaderText = "Tên khách hàng";
                dtView.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                pick = 1;
            }
        }

        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(pick == 0)
            {
                if (e.RowIndex < 0) return;
                ClassVCTHD cTHD = new ClassVCTHD();
                string id = dtView.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtCTView.DataSource = cTHD.ShowData(id);
            }
            else if(pick == 1)
            {
                if (e.RowIndex < 0) return;
                ClassTCI TC = new ClassTCI();
                string id = dtView.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (id.Contains("HD"))
                {
                    dtView.Columns[2].HeaderText = "Tên khách hàng";
                }
                else 
                {
                    dtView.Columns[2].HeaderText = "Tên nhân viên";
                }
                dtThuChi.DataSource = TC.GetItem(id);
                dtThuChi.Columns[0].Visible = false;
                dtThuChi.Columns[1].HeaderText = "Tên dịch vụ / Sản phẩm";
                dtThuChi.Columns[2].HeaderText = "Số lượng";
                dtThuChi.Columns[3].HeaderText = "Giá tiền";
            }
        }

        private void bDay_Click(object sender, EventArgs e)
        {
            ClassTCI objN = new ClassTCI();
            dtView.DataSource = objN.GetItemsByDay(txtDate.Value.ToString("yyyy/MM/dd"));
            dtCur = objN.GetItemsByDay(txtDate.Value.ToString("yyyy/MM/dd"));
        }
        private void bMonth_Click(object sender, EventArgs e)
        {
            ClassTCI objN = new ClassTCI();
            dtView.DataSource = objN.GetItemsByMonth();
            dtCur = objN.GetItemsByMonth();
        }
        private void bYear_Click(object sender, EventArgs e)
        {
            ClassTCI objN = new ClassTCI();
            dtView.DataSource = objN.GetItemsByYear();
            dtCur = objN.GetItemsByYear();
        }

        private void bErn_Click(object sender, EventArgs e)
        {
            dtView.DataSource = dtCur;
            DataTable dt = new DataTable();
            dt = dtCur.Copy();
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                if (!row[0].ToString().Contains("HD"))
                {
                    row.Delete();
                }
            }
            dt.AcceptChanges();
            dtView.DataSource = dt;
        }

        private void bSpend_Click(object sender, EventArgs e)
        {
            dtView.DataSource = dtCur;
            DataTable dt = new DataTable();
            dt = dtCur.Copy();
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString().Contains("HD"))
                {
                    row.Delete();
                }
            }
            dt.AcceptChanges();
            dtView.DataSource = dt;
        }

        private void bRes_Click(object sender, EventArgs e)
        {
            ClassTCI TC = new ClassTCI();
            dtView.DataSource = null;
            dtView.DataSource = TC.GetItems();
            dtCur = TC.GetItems();
            dtView.Columns[1].HeaderText = "Ngày tạo";
            dtView.Columns[2].HeaderText = "Tên khách hàng";
            dtView.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtView.Columns[0].Visible = true;
        }
        private void copyAlltoClipboard()
        {
            dtView.Columns[0].Visible = true;
            dtView.SelectAll();
            DataObject dataObj = dtView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            dtView.Columns[0].Visible = false;
        }

        private void bPrint_Click(object sender, EventArgs e)
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
