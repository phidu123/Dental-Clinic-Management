using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuThuy.DAL
{
    internal class ClassHD
    {
        public DataTable ShowData()
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "SELECT ID_HD, NHAN_VIEN.TEN, KHACH_HANG.HO_TEN, NGAY FROM HOA_DON, NHAN_VIEN, KHACH_HANG \r\nWHERE KHACH_HANG.ID_KH = HOA_DON.ID_KH AND NHAN_VIEN.ID_NV = HOA_DON.ID_TT";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
        public DataTable ReadItemsTable()
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select * from HOA_DON";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
        public bool AddItemsToTable(String Id, String ID_KH, String ID_TT)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "Insert into HOA_DON(ID_HD, NGAY, ID_KH, ID_TT)values(@ID_HD, @NGAY, @ID_KH, @ID_TT);";
            DateTime date = DateTime.Now;
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID_HD", Id.Trim());
                    cmd.Parameters.AddWithValue("@NGAY", date);
                    cmd.Parameters.AddWithValue("@ID_KH", ID_KH.Trim());
                    cmd.Parameters.AddWithValue("@ID_TT", ID_TT.Trim());
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
            String queryTaiKhoan = "select Top 1 (ID_HD) from HOA_DON ORDER BY ID_HD DESC";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    return Int32.Parse(cmd.ExecuteScalar().ToString().Substring(2, cmd.ExecuteScalar().ToString().Length - 2));
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
