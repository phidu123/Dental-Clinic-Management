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
using ThuThuy.BLL;

namespace ThuThuy.App
{
    public partial class OutList : UserControl
    {
        public OutList()
        {
            InitializeComponent();
            //GenerateDynamicUserControl();
        }

        /*private void GenerateDynamicUserControl()
        {
            pChecked.Controls.Clear();
            pUnchecked.Controls.Clear();

            ClassOutItem objRe = new ClassOutItem();

            DataTable dt = objRe.tb;
            int numberI;
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    OutItem[] listItems = new OutItem[dt.Rows.Count];

                    int i = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new OutItem(row["Id"].ToString());
                        listItems[i].nvName = row["Name"].ToString();
                        listItems[i].ItName = objRe.itemName(row["IdItem"].ToString());
                        numberI = int.Parse(row["Number"].ToString());
                        listItems[i].Number = numberI.ToString();
                        listItems[i].Date = DateTime.Now.ToString("dd/mm/yyyy");
                        if (row["STATUS"].ToString().Equals("unchecked "))
                        {
                            pUnchecked.Controls.Add(listItems[i]);
                        }
                        else
                        {
                            listItems[i].hide_button();
                            pChecked.Controls.Add(listItems[i]);
                        }
                        i++;
                    }
                }
            }
        }*/

        private void bRe_Click(object sender, EventArgs e)
        {
            //GenerateDynamicUserControl();
        }
    }
}
