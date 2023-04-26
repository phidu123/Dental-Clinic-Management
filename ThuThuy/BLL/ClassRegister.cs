using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using ThuThuy.DAL;

namespace ThuThuy.BLL
{
    internal class ClassRegister
    {
        DataTable tb;
        public String strName(String Id)
        {
            try
            {
                ClassAcount objdal = new ClassAcount();
                return objdal.strGetName(Id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                throw;
            }
        }
        public String strId(String Username)
        {
            try
            {
                ClassAcount objdal = new ClassAcount();
                return objdal.strGetId(Username);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                throw;
            }
        }
        public bool DisableACC(string ID)
        {
            try
            {
                ClassAcount objdal = new ClassAcount();
                return objdal.disable(ID);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                throw;
            }
        }
        public int checkLogin(String Username, String Pass)
        {
            try
            {
                ClassAcount objdal = new ClassAcount();
                return objdal.checkLogin(Username, Pass);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return -10;
            }
        }
        public bool SaveItems(String Id, String Username, String Pass, int Chucvu, String Ten, String SDT, String NgaySinh, bool Gender, int Songaylam, int luongngay, int tongluong)
        {
            try
            {
                ClassAcount objdal = new ClassAcount();
                return objdal.AddItemsToTable(Id, Username, Pass, Chucvu, Ten, SDT, NgaySinh, Gender, Songaylam, luongngay, tongluong);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable ViewData()
        {
            try
            {
                ClassAcount objdal = new ClassAcount();
                return objdal.ReadInfoNV();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataRow ViewInfo(string Id)
        {
            try
            {
                ClassAcount objdal = new ClassAcount();
                return objdal.ReadInfo(Id);
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
                ClassAcount objdal = new ClassAcount();
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public bool confirmExist(string username)
        {
            try
            {
                ClassAcount objdal = new ClassAcount();
                return objdal.checkExistU(username);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public bool confirmChange(String Id, String Username, String Pass, int Chucvu, String SDT, String NgaySinh, int Songaylam, int luongngay, int tongluong)
        {
            try
            {
                ClassAcount objdal = new ClassAcount();
                return objdal.Change(Id,Username,Pass,Chucvu,SDT,NgaySinh,Songaylam,luongngay,tongluong);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public string phatsinhTudong(int numId)
        {
            try
            {
                string s = "";
                string mk = "";
                ClassAcount objdal = new ClassAcount();
                tb = objdal.ReadItemsTable();
                if (numId == 1)
                {
                    mk = "QL";
                }
                else if (numId == 2)
                {
                    mk = "NV";
                }
                else if (numId == 3)
                {
                    mk = "BS";
                }
                if (tb.Rows.Count > 0)
                {
                    int stt = objdal.CountData(numId) + 1;
                    if (stt < 10)
                        s = mk + "0" + stt.ToString();
                    else
                        s = mk + stt.ToString();
                }
                else
                    s = mk + "01";
                return s;
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public string phatsinhTudongNN()
        {
            try
            {
                string s = "";
                string mk = "P";
                ClassAcount objYC = new ClassAcount();
                if (objYC.countItemsNN() > 0)
                {
                    int stt = objYC.countItemsNN() + 1;
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
        public bool SaveItemsNN(int soNgay, string id_nv)
        {
            try
            {
                ClassAcount objdal = new ClassAcount();
                ClassRegister objc = new ClassRegister();
                return objdal.AddItemsNN(objc.phatsinhTudongNN(), soNgay, id_nv);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
    }
}
