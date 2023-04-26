using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThuy.App;

namespace ThuThuy.App.QuanLyTab
{
    public partial class Kho : UserControl
    {
        string ID;
        public Kho(string iD)
        {
            InitializeComponent();
            this.ID = iD;
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            ListKho form = new ListKho();
            addUserControl(form);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelList.Controls.Clear();
            panelList.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void listKho_Click(object sender, EventArgs e)
        {
            ListKho form = new ListKho();
            addUserControl(form);
        }

        private void listOrder_Click(object sender, EventArgs e)
        {
            ReqLIst form = new ReqLIst(this.ID);
            addUserControl(form);
        }
    }
}
