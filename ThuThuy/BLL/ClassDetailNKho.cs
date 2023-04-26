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
    internal class ClassDetailNKho
    { 
        public DataTable tb = GetItems();
        public string getID_PNK(String id)
        {
            try
            {
                ChiTietNhapKho objdal = new ChiTietNhapKho();
                return objdal.getID_PNK(id);
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
                ChiTietNhapKho objdal = new ChiTietNhapKho();
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public bool SaveItems(string id, string Id_Sp, int sl, int total)
        {
            try
            {
                ChiTietNhapKho objdal = new ChiTietNhapKho();
                return objdal.AddItemsToTable(id, Id_Sp, sl, total);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
    }
}
