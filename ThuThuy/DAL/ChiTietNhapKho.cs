using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuThuy.DAL
{
    internal class ChiTietNhapKho
    {
        public String getID_PNK(String id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select ID_PNK from CTNK where ID_PNK in (Select TOP 1 PHIEU_NHAP_KHO.ID_PNK from PHIEU_NHAP_KHO, CTNK where NGAY < getdate() and CTNK.ID_SP = @ID order by PHIEU_NHAP_KHO.NGAY Desc)";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@ID", id.Trim());
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    if (tb!=null)
                    {
                        if (tb.Rows.Count>0)
                        {
                            String id_PNK = tb.Rows[0][0].ToString();
                            return id_PNK;
                        }
                        else
                        {
                            return "ZZZ";
                        }
                    }
                    else
                    {
                        return "ZZZ";
                    }
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
            String queryTaiKhoan = "Select * from CTNK";
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
        public bool AddItemsToTable(String Id, String IdSP, int SL, int Tongtien)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string queryTaiKhoan = "Insert into CTNK(SO_LUONG, TONG_TIEN, ID_PNK, ID_SP)values(@SO_LUONG, @TONG_TIEN, @ID_PNK,@ID_SP);";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Id_PNK", Id.Trim());
                    cmd.Parameters.AddWithValue("@ID_SP", IdSP.Trim());
                    cmd.Parameters.AddWithValue("@SO_LUONG", SL);
                    cmd.Parameters.AddWithValue("@TONG_TIEN", Tongtien);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        public int CountData()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select Count(*) From CTNK";

            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    int count = (int)cmd.ExecuteScalar();
                    return count;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
