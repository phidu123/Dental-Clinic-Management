using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ThuThuy.App.QuanLyTab
{
    public partial class ItemsKho : UserControl
    {
        public ItemsKho()
        {
            InitializeComponent();
        }

        private string _Name;
        private string _Number;
        private string _NAMENV;
        private string _DateUp;

        [Category("Custom Props")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; name.Text = value; }
        }

        [Category("Custom Props")]
        public string Number
        {
            get { return _Number; }
            set { _Number = value; number.Text = value; }
        }

        [Category("Custom Props")]
        public string NAMENV
        {
            get { return _NAMENV; }
            set { _NAMENV = value; dateRequest.Text = value; }
        }

        [Category("Custom Props")]
        public string DateUp
        {
            get { return _DateUp; }
            set { _DateUp = value; dateUp.Text = value; }
        }
    }
}
