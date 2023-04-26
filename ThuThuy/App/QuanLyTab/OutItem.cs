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
    public partial class OutItem : UserControl
    {
        private String Id;
        public OutItem(String Id)
        {
            this.Id = Id;
            InitializeComponent();
        }
        private bool _check = false;
        private string _Date;
        private string _nvName;
        private string _ItName;
        private string _Number;
        [Category("Custom Props")]
        public string nvName
        {
            get { return _nvName; }
            set { _nvName = value; lbNVName.Text = value; }
        }
        [Category("Custom Props")]
        public string ItName
        {
            get { return _ItName; }
            set { _ItName = value; lbItemName.Text = value; }
        }
        [Category("Custom Props")]
        public string Date
        {
            get { return _Date; }
            set { _Date = value; lbDate.Text = value; }
        }
        [Category("Custom Props")]
        public string Number
        {
            get { return _Number; }
            set { _Number = value; lbNumber.Text = value; }
        }
        private void bCheck_Click(object sender, EventArgs e)
        {
            if (!_check)
            {
                _check = true;
                bCheck.Hide();
                //ClassOutItem objRe = new ClassOutItem();
                //objRe.status(Id);
            }
        }

        public void hide_button()
        {
            bCheck.Hide();
        }
    }
}
