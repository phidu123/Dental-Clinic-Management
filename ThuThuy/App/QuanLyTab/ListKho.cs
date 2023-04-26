using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThuy.BLL;

namespace ThuThuy.App.QuanLyTab
{
    public partial class ListKho : UserControl
    {
        public ListKho()
        {
            InitializeComponent();
        }
        private void ListKho_Load(object sender, EventArgs e)
        {
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
        }
    }
}
