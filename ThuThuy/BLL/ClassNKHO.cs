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
    internal class ClassNKHO
    {
        public DataTable tb = GetItems();
        public string getIDNV(string id)
        {
            if (id.Equals("ZZZ"))
            {
                return "QL01";
            }
            try
            {
                NhapKho objdal = new NhapKho();
                return objdal.getId_NV(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                throw;
            }
        }
        public static DataTable GetItems()
        {
            try
            {
                NhapKho objdal = new NhapKho();
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public string date(String id)
        {
            try
            {
                NhapKho objdal = new NhapKho();
                return objdal.getDate(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                throw;
            }
        }
        public bool SaveItems(string id, DateTime date, string ID_NV)
        {
            try
            {
                NhapKho objdal = new NhapKho();
                return objdal.AddItemsToTable(id, ID_NV, date);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public string phatsinhTudong()
        {
            try
            {
                string s = "";
                string mk = "PNK";
                NhapKho objdal = new NhapKho();
                tb = objdal.ReadItemsTable();
                if (tb.Rows.Count > 0)
                {
                    int stt = objdal.CountData() + 1;
                    if (stt < 10)
                        s = mk + "00" + stt.ToString();
                    else if (stt < 100)
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
