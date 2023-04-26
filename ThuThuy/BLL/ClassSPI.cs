using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThuy.DAL;

namespace ThuThuy.BLL
{
    internal class ClassSPI
    {
        public DataTable tb = GetItems();

        public String getID(string Name)
        {
            try
            {
                ClassSP objre = new ClassSP();
                return objre.idSP(Name);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                throw;
            }
        }
        public String getName(string id)
        {
            try
            {
                ClassSP objre = new ClassSP();
                return objre.getNameSP(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                throw;
            }
        }
        public DataTable getNameI() 
        {
            try
            {
                ClassSP objdal = new ClassSP();
                return objdal.iName();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public static DataTable GetItems()
        {
            try
            {
                ClassSP objdal = new ClassSP();
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public bool SaveItems(string id,string name, int price, int soluong)
        {
            try
            {
                ClassSP objdal = new ClassSP();
                return objdal.AddItemsToTable(id, name, price, soluong);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public void slUpdate(string nameSP,int SL, string ID_NV)
        {
            try
            {
                ClassSP objdal = new ClassSP();
                objdal.changeSL(objdal.idSP(nameSP),SL,ID_NV);
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
                string mk = "TB";
                ClassSP objdal = new ClassSP();
                tb = objdal.ReadItemsTable();
                if (tb.Rows.Count > 0)
                {
                    int stt = objdal.CountData() + 1;
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
    }
}
