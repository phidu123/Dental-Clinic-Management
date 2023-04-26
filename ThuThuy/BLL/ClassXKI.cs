using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThuy.DAL;

namespace ThuThuy.BLL
{
    internal class ClassXKI
    {
        public bool SaveItemsXK(string id, string idNV)
        {
            try
            {
                ClassXK objdal = new ClassXK();
                return objdal.AddItemToTableXK(id, idNV);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public bool SaveItemsCTXK(string id, string name,int sl)
        {
            try
            {
                ClassXK objdal = new ClassXK();
                ClassSPI objSPI = new ClassSPI();
                return objdal.AddItemToTableCTXK(id, objSPI.getID(name),sl,0);
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
                ClassXK objdal = new ClassXK();
                return objdal.countItems();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return 0;
            }
        }
        public int countItemsCTXK(string id)
        {
            try
            {
                ClassXK objdal = new ClassXK();
                return objdal.countItemCTXK(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return 0;
            }
        }
        public string getIDNew()
        {
            try
            {
                ClassXK objdal = new ClassXK();
                return objdal.getIDNew();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItems(string id)
        {
            try
            {
                ClassXK objdal = new ClassXK();
                return objdal.ReadItemsTable(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public void deleteNew(string id)
        {
            try
            {
                ClassXK objdal = new ClassXK();
                objdal.deleteNew(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return;
            }
        }
        public void deleteAll(string id)
        {
            try
            {
                ClassXK objdal = new ClassXK();
                objdal.deleteAllID(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return;
            }
        }
        public void deleteSPID(string id, string id_sp)
        {
            try
            {
                ClassXK objdal = new ClassXK();
                objdal.deleteSPID(id, id_sp);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return;
            }
        }
        public string phatsinhTudong()
        {
            try
            {
                string s = "";
                string mk = "PXK";
                ClassXKI objYC = new ClassXKI();
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
