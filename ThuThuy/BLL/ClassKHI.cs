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
    internal class ClassKHI
    {
        public DataTable GetItemsKH(string SDT)
        {
            try
            {
                ClassKH objdal = new ClassKH();
                return objdal.ReadItemsTableKH(SDT);
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
                ClassKH objdal = new ClassKH();
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable GetItemsForBS()
        {
            try
            {
                ClassKH objdal = new ClassKH();
                return objdal.ReadItemsTableForBS(DateTime.Now.ToString("yyyy-MM-dd"));
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public bool SaveItems(String Id, String Ten, String SDT, String NgaySinh, bool Gender,string id_nv)
        {
            try
            {
                ClassKH objdal = new ClassKH();
                return objdal.AddItemsToTable(Id, Ten, SDT, NgaySinh, Gender, id_nv);
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
                ClassKH objdal = new ClassKH();
                return objdal.countItems();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return 0;
            }
        }

        public string motaKH(string id)
        {
            try
            {
                ClassKH objdal = new ClassKH();
                return objdal.motaKH(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public string getIdKH(string id)
        {
            try
            {
                ClassKH objdal = new ClassKH();
                return objdal.getIdKH(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public void mtUpdate(string ID_KH, string MT)
        {
            try
            {
                ClassKH objdal = new ClassKH();
                objdal.changeMT(ID_KH,MT);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
        public string phatsinhTudong()
        {
            try
            {
                string s = "";
                string mk = "KH";
                ClassKH objYC = new ClassKH();
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
                    s = mk + "001";
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
