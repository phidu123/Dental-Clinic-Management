using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThuy.DAL;

namespace ThuThuy.BLL
{
    internal class ClassVHD
    {
        public DataTable GetData()
        {
            try
            {
                ClassHD objdal = new ClassHD();
                return objdal.ShowData();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItems()
        {
            try
            {
                ClassHD objdal = new ClassHD();
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public bool SaveItems(string id, string ID_KH, string ID_NV)
        {
            try
            {
                ClassHD objdal = new ClassHD();
                return objdal.AddItemsToTable(id, ID_KH, ID_NV);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public int countItems()
        {
            try
            {
                ClassHD objdal = new ClassHD();
                return objdal.countItems();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return 0;
            }
        }
        public string phatsinhTudong()
        {
            try
            {
                string s = "";
                string mk = "HD";
                ClassVHD objYC = new ClassVHD();
                if (objYC.countItems() > 0)
                {
                    int stt = objYC.countItems() + 1;
                    if (stt < 10)
                        s = mk + "000" + stt.ToString();
                    else if (stt < 100)
                        s = mk + "00" + stt.ToString();
                    else if (stt < 1000)
                        s = mk + "0" + stt.ToString();
                    else
                        s = mk + stt.ToString();
                }
                else
                    s = mk + "0001";
                return s;
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
