using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuThuy.DAL
{
    internal class ClassXK
    {
        public bool AddItemToTableXK(String Id, String id_nv)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "Insert into PHIEU_XUAT_KHO(ID_PXK,NGAY,ID_NV)values(@ID_PXK, @Ngay, @ID_NV)";
            DateTime date = DateTime.Now;
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Id_PXK", Id.Trim());
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
        public bool AddItemToTableCTXK(String Id, String id_sp, int SL, int Price)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "Insert into CTXK(ID_PXK,ID_SP,SOLUONG,GIA)values(@ID_PXK,@ID_SP,@SL,@PRICE)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Id_PXK", Id.Trim());
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
        public string getIDNew()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select Top 1 (ID_PXK) from PHIEU_XUAT_KHO ORDER BY ID_PXK DESC";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    return cmd.ExecuteScalar().ToString();
                }
            }
            catch
            {
                return null;
            }
        }
        public void deleteNew(string id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Delete from Phieu_Xuat_Kho where ID_PXK = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id",id.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void deleteAllID(string id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "delete from ctxk where id_pxk = @id";
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
        public void deleteSPID(string id, string Id_sp)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "delete from ctxk where ID_PXK = @id and ID_SP = @idsp";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", id.Trim());
                    cmd.Parameters.AddWithValue("@idsp", Id_sp.Trim());
                    cmd.ExecuteNonQuery();
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
            String queryTaiKhoan = "select Top 1 (ID_PXK) from PHIEU_XUAT_KHO ORDER BY ID_PXK DESC";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    string Id = cmd.ExecuteScalar().ToString();
                    return Int32.Parse(Id.Substring(3, Id.Length - 3));
                }
            }
            catch
            {
                return 0;
            }
        }
        public DataTable ReadItemsTable(string id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select id_pxk, TEN, soluong from ctxk, SAN_PHAM where CTXK.ID_SP = SAN_PHAM.ID_SP and CTXK.ID_PXK = @id";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                cmd.Parameters.AddWithValue("@id", id.Trim());
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
        public int countItemCTXK(string id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select count(*) soluong from ctxk where ID_PXK = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", id.Trim());
                    return Int32.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
