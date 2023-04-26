using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuThuy.DAL
{
    internal class ClassKH
    {
        public bool AddItemsToTable(String Id, String Ten, String SDT, String NgaySinh, bool Gender, string id_nv)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string queryTai_khoan = "Insert into KHACH_HANG(ID_KH,HO_TEN,NGAY_SINH,GIOI_TINH,ID_TT,SDT,MO_TA)values(@ID,@NAME,@DATE,@GENDER,@ID_NV,@SDT,'New')";
            DateTime date = DateTime.Parse(NgaySinh);
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTai_khoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", Id.Trim());
                    cmd.Parameters.AddWithValue("@ID_NV", id_nv.Trim());
                    cmd.Parameters.AddWithValue("@NAME", Ten.Trim());
                    cmd.Parameters.AddWithValue("@SDT", SDT.Trim());
                    cmd.Parameters.AddWithValue("@DATE", date);
                    cmd.Parameters.AddWithValue("@GENDER", Gender);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        public DataTable ReadItemsTableKH(string SDT)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTai_khoan = "select ID_KH,HO_TEN from KHACH_HANG where SDT = @SDT";
            SqlCommand cmd = new SqlCommand(queryTai_khoan, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@SDT", SDT.Trim());
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
            String queryTai_khoan = "select ID_KH, HO_TEN, SDT, NGAY_SINH, MO_TA, GIOI_TINH from KHACH_HANG";
            SqlCommand cmd = new SqlCommand(queryTai_khoan, con.connect);
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
        
        public DataTable ReadItemsTableForBS(string date)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTai_khoan = "Select HOA_DON.ID_HD, KHACH_HANG.HO_TEN, HOA_DON.ID_KH from HOA_DON, KHACH_HANG where HOA_DON.ID_KH = KHACH_HANG.ID_KH and HOA_DON.NGAY = @Date";
            SqlCommand cmd = new SqlCommand(queryTai_khoan, con.connect);
            try
            {
                cmd.Parameters.AddWithValue("@Date", date.Trim());
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
        public int countItems()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select Top 1 (ID_KH) from KHACH_HANG ORDER BY ID_KH DESC";
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

        public string motaKH(string id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select MO_TA from KHACH_HANG where ID_KH = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", id.Trim());
                    return (string)cmd.ExecuteScalar();
                }
            }
            catch
            {
                throw;
            }
        }

        public string getIdKH(string name)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select ID_KH from KHACH_HANG where HO_TEN = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", name.Trim());
                    return (string)cmd.ExecuteScalar();
                }
            }
            catch
            {
                throw;
            }
        }
        public void changeMT(string id, string MT)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE KHACH_HANG SET MO_TA=@MT WHERE ID_KH=@ID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", id.Trim());
                    cmd.Parameters.AddWithValue("@MT", MT.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
