using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ThuThuy.App.QuanLyTab;

namespace ThuThuy.App
{
    public partial class QuanLy : Form
    {
        bool barExpand = true;
        String id;
        public QuanLy(string id)
        {
            InitializeComponent();
            barControl.Paint += new PaintEventHandler(set_background);
            panel2.Paint += new PaintEventHandler(set_background);
            panel4.Paint += new PaintEventHandler(set_background);
            this.id = id;
            Kho form = new Kho(id);
            addUserControl(form);
        }
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(135, 206, 235), Color.FromArgb(79, 148, 205), 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            
        }

        private void bartimer_Tick(object sender, EventArgs e)
        {
            if (barExpand)
            {
                barControl.Width -= 10;
                if (barControl.Width == barControl.MinimumSize.Width)
                {
                    barExpand = false;
                    bartimer.Stop();
                }
            }
            else
            {
                barControl.Width += 10;
                if (barControl.Width == barControl.MaximumSize.Width)
                {
                    barExpand = true;
                    bartimer.Stop();
                }
            }
        }



        private void addUserControl(UserControl userControl)
        {
            userControl.Dock =  DockStyle.Fill;
            listKho.Controls.Clear();
            listKho.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void bKho_Click(object sender, EventArgs e)
        {
            Kho form = new Kho(id);
            addUserControl(form);
        }

        private void bDangKy_Click(object sender, EventArgs e)
        {
            Register_form form = new Register_form();
            addUserControl(form);
        }

        private void bTaiLieu_Click(object sender, EventArgs e)
        {
            TaiLieu form = new TaiLieu();
            addUserControl(form);
        }

        private void bClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bClose_MouseHover(object sender, EventArgs e)
        {
            bClose.FillColor = Color.Blue;
        }
        private void bClose_MouseLeave(object sender, EventArgs e)
        {
            bClose.FillColor = Color.Red;
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            if (barExpand)
            {
                bartimer.Start();
            }
            if(!barExpand)
            {
                bartimer.Start();
            }
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
