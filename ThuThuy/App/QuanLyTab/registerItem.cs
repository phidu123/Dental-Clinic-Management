using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuThuy.App.QuanLyTab
{
    public partial class registerItem : UserControl
    {
        public registerItem()
        {
            InitializeComponent();
        }
        private string _UserName;
        private string _Name;
        private string _Place;
        private string _Number;
        
        [Category("Custom Props")]
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        [Category("Custom Props")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; lbName.Text = value;  }
        }

        [Category("Custom Props")]
        public string Place
        {
            get { return _Place; }
            set { _Place = value; lbChucVu.Text = value; }
        }
        
        [Category("Custom Props")]
        public string Number
        {
            get { return _Number; }
            set { _Number = value; lbNumber.Text = value; }
        }

        private void bSet_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(UserName);
            change.Show();
        }
    }
}
