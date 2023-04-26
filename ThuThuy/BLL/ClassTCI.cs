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
    internal class ClassTCI
    {
        public DataTable GetItems()
        {
            try
            {
                ClassTC objdal = new ClassTC();
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItem(string ID) 
        {
            if (ID.Contains("PNK"))
            {
                try
                {
                    ClassTC objdal = new ClassTC();
                    return objdal.readC(ID);
                }
                catch (Exception e)
                {
                    DialogResult result = MessageBox.Show(e.Message.ToString());
                    return null;
                }
            }
            else
            {
                try
                {
                    ClassTC objdal = new ClassTC();
                    return objdal.readT(ID);
                }
                catch (Exception e)
                {
                    DialogResult result = MessageBox.Show(e.Message.ToString());
                    return null;
                }
            }
        }
        public DataTable GetItemsByDay(string date)
        {
            try
            {
                ClassTC objdal = new ClassTC();
                return objdal.readToDate(date);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItemsByMonth()
        {
            try
            {
                ClassTC objdal = new ClassTC();
                return objdal.readToMonth(DateTime.Now.Month.ToString());
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItemsByYear()
        {
            try
            {
                ClassTC objdal = new ClassTC();
                return objdal.readToYear(DateTime.Now.Year.ToString());
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
