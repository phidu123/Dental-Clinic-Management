using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuThuy.DAL
{
    internal class NhapKho
    {
        public string getDate(String id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryDS = "Select Ngay from PHIEU_NHAP_KHO where NGAY in (Select TOP 1 PHIEU_NHAP_KHO.NGAY from PHIEU_NHAP_KHO, CTNK where NGAY < getdate() and CTNK.ID_SP = @Id order by PHIEU_NHAP_KHO.NGAY Desc)";
            SqlCommand cmd = new SqlCommand(queryDS, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@Id", id.Trim());
                    return Convert.ToDateTime(cmd.ExecuteScalar()).ToString("dd/MM/yyyy");
                }
            }
            catch
            {
                throw;
            }
        }
        public string getId_NV(String id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryDS = "Select ID_NV from PHIEU_NHAP_KHO where ID_PNK = @Id";
            SqlCommand cmd = new SqlCommand(queryDS, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@Id", id.Trim());
                    return (String)cmd.ExecuteScalar();
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
            String queryTaiKhoan = "Select * from PHIEU_NHAP_KHO";
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
        public bool AddItemsToTable(String Id, String IdNV, DateTime Ngay )
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string queryTaiKhoan = "Insert into PHIEU_NHAP_KHO(ID_PNK, NGAY, ID_NV)values(@ID_PNK, @NGAY, @ID_NV);";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Id_PNK", Id.Trim());
                    cmd.Parameters.AddWithValue("@NGAY", Ngay);
                    cmd.Parameters.AddWithValue("@ID_NV", IdNV.Trim());

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
            String queryTaiKhoan = "select Count(*) From PHIEU_NHAP_KHO";

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
