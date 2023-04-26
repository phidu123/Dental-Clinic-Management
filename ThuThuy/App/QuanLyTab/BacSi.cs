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

namespace ThuThuy.App.QuanLyTab
{
    public partial class BacSi : Form
    {
        string id;
        string id_KH;
        public BacSi(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BacSi_Load(object sender, EventArgs e)
        {
            ClassKHI objKH = new ClassKHI();
            ClassVCTHD objCTHD = new ClassVCTHD();
            listKH.DataSource = objKH.GetItemsForBS();
            listKH.Columns[0].Visible = false;
            listKH.Columns[1].HeaderText = "Tên khách hàng";
            listKH.Columns[2].Visible = false;
            
        }

        private void listKH_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassVCTHD objCTHD = new ClassVCTHD();
            listDV.DataSource = objCTHD.ShowDataBS(listKH.Rows[e.RowIndex].Cells[0].Value.ToString());
            id_KH = listKH.Rows[e.RowIndex].Cells[2].Value.ToString();
            listDV.Columns[0].Visible = false;
            listDV.Columns[1].HeaderText = "Tên dịch vụ";
            ClassKHI objKH = new ClassKHI();
            txtMoTa.Text = objKH.motaKH(id_KH);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ClassKHI objKH = new ClassKHI();
            objKH.mtUpdate(id_KH, txtMoTa.Text);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
