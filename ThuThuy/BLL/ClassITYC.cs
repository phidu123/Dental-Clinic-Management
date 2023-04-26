using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThuy.DAL;

namespace ThuThuy.BLL
{
    internal class ClassITYC
    {
        public int countChecked()
        {
            try
            {
                ClassYC objdal = new ClassYC();
                return objdal.countCheck();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return 0;
            }
        }
        public int countUnChecked()
        {
            try
            {
                ClassYC objdal = new ClassYC();
                return objdal.countUnCheck();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return 0;
            }
        }
        public DataTable GetItems_Check()
        {
            try
            {
                ClassYC objdal = new ClassYC();
                return objdal.ReadItemsCheckTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItems_UnCheck()
        {
            try
            {
                ClassYC objdal = new ClassYC();
                return objdal.ReadItemsUnCheckTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItems_READY()
        {
            try
            {
                ClassYC objdal = new ClassYC();
                return objdal.ReadItemsReadyTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItems_Update()
        {
            try
            {
                ClassYC objdal = new ClassYC();
                return objdal.ReadItemsUpdateTable();
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
                ClassYC objdal = new ClassYC();
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public void statusToCheck(string id)
        {
            try
            {
                ClassYC objdal = new ClassYC();
                objdal.changeStatusToCheck(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
        public void statusToReady(string id)
        {
            try
            {
                ClassYC objdal = new ClassYC();
                objdal.changeUpdateToReady(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
        public void statusToDone(string id)
        {
            try
            {
                ClassYC objdal = new ClassYC();
                objdal.changeUpdateToDone(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
        public void statusToUpdate(string id)
        {
            try
            {
                ClassYC objdal = new ClassYC();
                objdal.changeReadyToUpdate(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
        public void statusToUnCheck(string id)
        {
            try
            {
                ClassYC objdal = new ClassYC();
                objdal.changeStatusToUnCheck(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
        public bool SaveItems(string id, string id_sp, string ID_NV, int sl, int donggia)
        {
            try
            {
                ClassYC objdal = new ClassYC();
                int tongtien = sl * donggia;
                return objdal.AddItemsToTable(id, id_sp, ID_NV, sl,tongtien);
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
                ClassYC objdal = new ClassYC();
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
                string mk = "YC";
                ClassITYC objYC = new ClassITYC();
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

        public void bDelCheck()
        {
            try
            {
                ClassYC objdal = new ClassYC();
                objdal.DelCheck();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
        public void bRes()
        {
            try
            {
                ClassYC objdal = new ClassYC();
                objdal.changeAllToUnCheck();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
        public void bDelAll()
        {
            try
            {
                ClassYC objdal = new ClassYC();
                objdal.DelAll();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
        public void bAll(string ID)
        {
            try
            {
                ClassYC objdal = new ClassYC();
                objdal.changeAllToReady(ID);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
        public void bCheckR(string ID)
        {
            try
            {
                ClassYC objdal = new ClassYC();
                objdal.changeCheckToReady(ID);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
            }
        }
    }
}
