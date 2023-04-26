using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThuy.DAL;

namespace ThuThuy.BLL
{
    internal class ClassNKI
    {
        public bool SaveItemsPNK(string id, string idNV)
        {
            try
            {
                ClassNK objdal = new ClassNK();
                return objdal.AddItemToTablePNK(id, idNV);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public bool SaveItemsCTNK(string id, string name,int SL, int Price)
        {
            try
            {
                ClassNK objdal = new ClassNK();
                ClassSPI objSPI = new ClassSPI();
                return objdal.AddItemToTableCTNK(id, objSPI.getID(name),SL,Price);
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
                ClassNK objdal = new ClassNK();
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
                string mk = "PNK";
                ClassNKI objYC = new ClassNKI();
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
