using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ThuThuy.App;
using ThuThuy.BLL;

namespace ThuThuy.App.QuanLyTab
{
    public partial class ReqLIst : UserControl
    {
        private String ID;
        public ReqLIst(String ID)
        {
            this.ID = ID;
            InitializeComponent();
        }
        private void ReqLIst_Load(object sender, EventArgs e)
        {
            ClassITYC objYC = new ClassITYC();
            if (objYC.countChecked() != 0)
            {
                ClassITYC classITYC = new ClassITYC();
                dtViewCheck.DataSource = classITYC.GetItems_Check();
                dtViewCheck.Columns[0].Visible = false;
                dtViewCheck.Columns[1].HeaderText = "Tên Sản Phẩm";
                dtViewCheck.Columns[2].HeaderText = "Số Lượng";
                dtViewCheck.Columns[3].HeaderText = "Tổng Tiền";
                dtViewCheck.Columns[4].HeaderText = "Tên Nhân Viên";
                bAct.Enabled = true;
                bAllA.Enabled = true;
                bDel.Enabled = true;
                bAllD.Enabled = true;
                bRes.Enabled = true;
            }
            else
            {
                bAct.Enabled = false;
                bAllA.Enabled = false;
                bDel.Enabled = false;
                bAllD.Enabled = false;
                bRes.Enabled = false;
            }
            if (objYC.countUnChecked() != 0)
            {
                ClassITYC classITYC = new ClassITYC();
                dtViewUnCheck.DataSource = classITYC.GetItems_UnCheck();
                dtViewUnCheck.Columns[0].Visible = false;
                dtViewUnCheck.Columns[1].HeaderText = "Tên Sản Phẩm";
                dtViewUnCheck.Columns[2].HeaderText = "Số Lượng";
                dtViewUnCheck.Columns[3].HeaderText = "Tổng Tiền";
                dtViewUnCheck.Columns[4].HeaderText = "Tên Nhân Viên";
                bAllA.Enabled = true;
                bAllD.Enabled = true;
            }
            else
            {
                bAllA.Enabled = false;
                bAllD.Enabled = false;
            }
        }


        private void dtViewCheck_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassITYC classITYC = new ClassITYC();
            classITYC.statusToUnCheck(dtViewCheck.Rows[e.RowIndex].Cells[0].Value.ToString());
            ClassITYC objYC = new ClassITYC();
            dtViewCheck.DataSource = objYC.GetItems_Check();
            dtViewUnCheck.DataSource = objYC.GetItems_UnCheck();
            if(objYC.countChecked() == 0)
            {
                bAct.Enabled = false;
                bDel.Enabled = false;
            }
        }

        private void dtViewUnCheck_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassITYC classITYC = new ClassITYC();
            classITYC.statusToCheck(dtViewUnCheck.Rows[e.RowIndex].Cells[0].Value.ToString());
            ClassITYC objYC = new ClassITYC();
            bAct.Enabled = true;
            bDel.Enabled = true;
            dtViewCheck.DataSource = objYC.GetItems_Check();
            dtViewUnCheck.DataSource = objYC.GetItems_UnCheck();
        }

        private void bRes_Click(object sender, EventArgs e)
        {
            ClassITYC objYC = new ClassITYC();
            objYC.bRes();
            dtViewCheck.DataSource = objYC.GetItems_Check();
            dtViewUnCheck.DataSource = objYC.GetItems_UnCheck();
        }

        private void bAct_Click(object sender, EventArgs e)
        {
            ClassITYC objYC = new ClassITYC();
            objYC.bCheckR(ID);
            dtViewCheck.DataSource = objYC.GetItems_Check();
            dtViewUnCheck.DataSource = objYC.GetItems_UnCheck();
        }

        private void bAllA_Click(object sender, EventArgs e)
        {
            ClassITYC objYC = new ClassITYC();
            objYC.bAll(ID);
            dtViewCheck.DataSource = objYC.GetItems_Check();
            dtViewUnCheck.DataSource = objYC.GetItems_UnCheck();
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            ClassITYC objYC = new ClassITYC();
            objYC.bDelCheck();
            dtViewCheck.DataSource = objYC.GetItems_Check();
            dtViewUnCheck.DataSource = objYC.GetItems_UnCheck();
        }

        private void bAllD_Click(object sender, EventArgs e)
        {
            ClassITYC objYC = new ClassITYC();
            objYC.bDelAll();
            dtViewCheck.DataSource = objYC.GetItems_Check();
            dtViewUnCheck.DataSource = objYC.GetItems_UnCheck();
        }
    }
}
