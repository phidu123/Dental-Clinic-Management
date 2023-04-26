using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ThuThuy.DAL
{
    internal class ClassCTHD
    {
        public void deleteDV(string id, string id_dv)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Delete from CTHD where ID_HD = @id and ID_DV=@id_DV";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", id.Trim());
                    cmd.Parameters.AddWithValue("@id_DV", id_dv.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        public void deleteAll(string id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Delete from CTHD where ID_HD = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", id.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        public void updateSL(string id, string id_dv, string sl, int gia)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Update CTHD set SOLUONG = @sl, GIA = @gia where ID_HD= @id and ID_DV = @ID_DV";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", id.Trim());
                    cmd.Parameters.AddWithValue("@ID_DV", id_dv.Trim());
                    cmd.Parameters.AddWithValue("@sl", sl.Trim());
                    cmd.Parameters.AddWithValue("@gia", gia);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public DataTable ReadData(string ID_HD)
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select id_hd, CTHD.id_dv, dich_vu.TEN, CTHD.SOLUONG, CTHD.GIA from DICH_VU, CTHD where DICH_VU.ID_DV = CTHD.ID_DV and  CTHD.ID_HD = @ID_HD";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@ID_HD", ID_HD.Trim());
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

        public DataTable ReadDataBS(string ID_HD)
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select CTHD.ID_HD, DICH_VU.TEN from CTHD, DICH_VU where CTHD.ID_DV = DICH_VU.ID_DV and CTHD.ID_HD = @ID_HD";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@ID_HD", ID_HD.Trim());
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
        public DataTable ReadItemsTable(string ID_HD)  
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select * from CTHD where ID_HD=@ID_HD";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@ID_HD", ID_HD.Trim());
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
        public bool AddItemsToTable(int SL, int TT, String ID_DV, String ID_HD)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "Insert into CTHD(SOLUONG, GIA, ID_DV, ID_HD)values(@SL, @TT, @ID_DV, @ID_HD);";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@SL", SL);
                    cmd.Parameters.AddWithValue("@TT", TT);
                    cmd.Parameters.AddWithValue("@ID_DV", ID_DV.Trim());
                    cmd.Parameters.AddWithValue("@ID_HD", ID_HD.Trim());
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        public int sumHD(String ID_HD)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "select sum(GIA) from CTHD where ID_HD = @ID_HD";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID_HD", ID_HD.Trim());
                    return Int32.Parse(cmd.ExecuteScalar().ToString());    
                }
            }
            catch
            {
                return 0;
            }
        }

        public int sl(String ID_HD, string ID_DV)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "select SOLUONG from CTHD where ID_HD = @ID_HD and ID_DV= @ID_DV";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID_HD", ID_HD.Trim());
                    cmd.Parameters.AddWithValue("@ID_DV", ID_DV.Trim());
                    int st = 0;
                    return st + Int32.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
