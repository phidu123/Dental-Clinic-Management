using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuThuy.DAL
{
    internal class ClassNK
    {
        public bool AddItemToTablePNK(String Id, String id_nv)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "Insert into PHIEU_NHAP_KHO(ID_PNK,NGAY,ID_NV)values(@ID_PNK, @Ngay, @ID_NV)";
            DateTime date = DateTime.Now;
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Id_PNK", Id.Trim());
                    cmd.Parameters.AddWithValue("@ngay", date);
                    cmd.Parameters.AddWithValue("@ID_NV", id_nv.Trim());
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool AddItemToTableCTNK(String Id, String id_sp, int SL, int Price)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "Insert into CTNK(ID_PNK,ID_SP,SOLUONG,GIA)values(@ID_PNK,@ID_SP,@SL,@PRICE)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Id_PNK", Id.Trim());
                    cmd.Parameters.AddWithValue("@ID_SP", id_sp.Trim());
                    cmd.Parameters.AddWithValue("@SL", SL);
                    cmd.Parameters.AddWithValue("@PRICE", Price);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        public int countItems()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select Top 1 (ID_PNK) from PHIEU_NHAP_KHO ORDER BY ID_PNK DESC";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    return Int32.Parse(cmd.ExecuteScalar().ToString().Substring(3, cmd.ExecuteScalar().ToString().Length - 3));
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
