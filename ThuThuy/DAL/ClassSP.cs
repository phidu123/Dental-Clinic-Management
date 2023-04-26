using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ThuThuy.App.QuanLyTab;

namespace ThuThuy.DAL
{
    internal class ClassSP
    {
        
        public DataTable ReadItemsTable()
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select SAN_PHAM.*,NHAN_VIEN.TEN  from SAN_PHAM, NHAN_VIEN where NHAN_VIEN.ID_NV = SAN_PHAM.ID_NV";
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
        public bool AddItemsToTable(String Id,String TEN, int price, int soluong)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string makho = "K01";
            string queryTaiKhoan = "Insert into SAN_PHAM(ID_SP, TEN, GIA, SO_LUONG, MA_KHO)values(@ID_SP, @TEN, @GIA, @SO_LUONG, @MA_KHO);";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Id_SP", Id.Trim());
                    cmd.Parameters.AddWithValue("@TEN", TEN.Trim());
                    cmd.Parameters.AddWithValue("@GIA", price);
                    cmd.Parameters.AddWithValue("@SO_LUONG", soluong);
                    cmd.Parameters.AddWithValue("@MA_KHO", makho);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        public string idSP(String Name)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "Select ID_SP from San_Pham where TEN = @Name";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Name", Name.Trim());
                    return cmd.ExecuteScalar().ToString();
                }
            }
            catch
            {
                throw;
            }
        }
        public void changeSL(string id, int SL, string ID_NV)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE SAN_PHAM SET SO_LUONG=SO_LUONG+@SL,ID_NV=@ID_NV,NGAY = GETDATE() WHERE ID_SP=@ID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", id.Trim());
                    cmd.Parameters.AddWithValue("@ID_NV", ID_NV.Trim());
                    cmd.Parameters.AddWithValue("@SL", SL);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public string getNameSP(String Id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "Select Ten from San_Pham where ID_SP = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                   cmd.Parameters.AddWithValue("@id", Id.Trim());
                    return cmd.ExecuteScalar().ToString();
                }
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
            String queryTaiKhoan = "select Count(*) From SAN_PHAM";

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
        public DataTable iName()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select TEN from SAN_PHAM";
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
    }
}
