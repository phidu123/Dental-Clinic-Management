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
    internal class ClassVCTHD
    {
        public void deleteDV(string id, string id_dv)
        {
            try
            {
                ClassCTHD objdal = new ClassCTHD();
                objdal.deleteDV(id,id_dv);
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
                ClassCTHD objdal = new ClassCTHD();
                objdal.deleteAll(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return;
            }
        }
        public void updateSL(string id, string id_dv, string sl)
        {
            try
            {
                ClassCTHD objdal = new ClassCTHD();
                ClassDV objdv = new ClassDV();
                objdal.updateSL(id,id_dv,sl,Int32.Parse(sl)*objdv.countItems(id_dv));
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return;
            }
        }
        public DataTable ShowData(string ID_HD)
        {
            try
            {
                ClassCTHD objdal = new ClassCTHD();
                return objdal.ReadData(ID_HD);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable ShowDataBS(string ID_HD)
        {
            try
            {
                ClassCTHD objdal = new ClassCTHD();
                return objdal.ReadDataBS(ID_HD);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItems(string ID_HD)
        {
            try
            {
                ClassCTHD objdal = new ClassCTHD();
                return objdal.ReadItemsTable(ID_HD);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public bool SaveItems(int sl, int price, string ID_DV, string ID_HD)
        {
            try
            {
                ClassCTHD objdal = new ClassCTHD();
                return objdal.AddItemsToTable(sl, price, ID_DV, ID_HD);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public int sumPrice(string ID_HD)
        {
            try
            {
                ClassCTHD objdal = new ClassCTHD();
                return objdal.sumHD(ID_HD);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return 0;
            }
        }

        public int sl(string ID_HD,string id_DV)
        {
            try
            {
                ClassCTHD objdal = new ClassCTHD();
                return objdal.sl(ID_HD,id_DV);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return 0;
            }
        }
    }
}
