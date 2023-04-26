using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows;

namespace ThuThuy.DAL
{
    internal class ClassYC
    {
        public void changeStatusToCheck(string id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE YEU_CAU_NHAP SET Status = 'CHECKED' WHERE Status = 'UNCHECKED' AND ID_YCN = @ID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", id.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void changeStatusToUnCheck(string id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE YEU_CAU_NHAP SET Status = 'UNCHECKED' WHERE Status = 'CHECKED' AND ID_YCN = @ID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", id.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void changeAllToUnCheck()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE YEU_CAU_NHAP SET Status = 'UNCHECKED' WHERE Status = 'CHECKED'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void changeCheckToReady(string ID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE YEU_CAU_NHAP SET Status = 'READY', ID_QL=@ID WHERE Status = 'CHECKED'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", ID.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void changeReadyToUpdate(string ID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE YEU_CAU_NHAP SET Status = 'UPDATE' WHERE Status = 'READY' AND ID_YCN = @ID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", ID.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void changeUpdateToReady(string ID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE YEU_CAU_NHAP SET Status = 'READY' WHERE Status = 'UPDATE' AND ID_YCN = @ID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", ID.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void changeUpdateToDone(string ID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE YEU_CAU_NHAP SET Status = 'DONE' WHERE Status = 'UPDATE' AND ID_YCN = @ID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", ID.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void changeAllToDone()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE YEU_CAU_NHAP SET Status = 'DONE' WHERE Status = 'UPDATE' OR Status = 'READY'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void changeAllToReady(string ID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "UPDATE YEU_CAU_NHAP SET Status = 'READY', ID_QL = @ID WHERE Status != 'UPDATE' and Status != 'DONE' ";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", ID.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void DelCheck()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "DELETE FROM YEU_CAU_NHAP WHERE YEU_CAU_NHAP.Status = 'CHECKED'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void DelAll()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "DELETE FROM YEU_CAU_NHAP WHERE YEU_CAU_NHAP.Status != 'UPDATE' AND YEU_CAU_NHAP.Status != 'READY'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public int countUnCheck()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "SELECT COUNT(*) FROM YEU_CAU_NHAP WHERE Status ='UNCHECKED'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    return Int32.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch
            {
                return 0;
            }
        }
        public int countCheck()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "SELECT COUNT(*) FROM YEU_CAU_NHAP WHERE Status ='CHECKED'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    return Int32.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch
            {
                return 0;
            }
        }

        public int countItems()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select Top 1 (ID_YCN) from YEU_CAU_NHAP ORDER BY ID_YCN DESC";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    return Int32.Parse(cmd.ExecuteScalar().ToString().Substring(2, cmd.ExecuteScalar().ToString().Length-2));
                }
            }
            catch
            {
                return 0;
            }
        }

        public DataTable ReadItemsTable()
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "SELECT * FROM YEU_CAU_NHAP";
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
        public DataTable ReadItemsUnCheckTable()
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "SELECT YEU_CAU_NHAP.ID_YCN, SAN_PHAM.TEN, YEU_CAU_NHAP.SL, YEU_CAU_NHAP.GIA, NHAN_VIEN.TEN FROM YEU_CAU_NHAP, SAN_PHAM, NHAN_VIEN WHERE SAN_PHAM.ID_SP = YEU_CAU_NHAP.ID_SP AND NHAN_VIEN.ID_NV = YEU_CAU_NHAP.ID_NV  AND YEU_CAU_NHAP.Status='UNCHECKED'";
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

        public DataTable ReadItemsCheckTable()
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "SELECT YEU_CAU_NHAP.ID_YCN, SAN_PHAM.TEN, YEU_CAU_NHAP.SL, YEU_CAU_NHAP.GIA, NHAN_VIEN.TEN FROM YEU_CAU_NHAP, SAN_PHAM, NHAN_VIEN WHERE SAN_PHAM.ID_SP = YEU_CAU_NHAP.ID_SP AND NHAN_VIEN.ID_NV = YEU_CAU_NHAP.ID_NV  AND YEU_CAU_NHAP.Status='CHECKED'";
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
        public DataTable ReadItemsReadyTable()
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "SELECT YEU_CAU_NHAP.ID_YCN, SAN_PHAM.TEN, YEU_CAU_NHAP.SL, YEU_CAU_NHAP.GIA, NHAN_VIEN.TEN FROM YEU_CAU_NHAP, SAN_PHAM, NHAN_VIEN WHERE SAN_PHAM.ID_SP = YEU_CAU_NHAP.ID_SP AND NHAN_VIEN.ID_NV = YEU_CAU_NHAP.ID_NV  AND YEU_CAU_NHAP.Status='READY'";
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
        public DataTable ReadItemsUpdateTable()
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "SELECT YEU_CAU_NHAP.ID_YCN, SAN_PHAM.TEN, YEU_CAU_NHAP.SL, YEU_CAU_NHAP.GIA, NHAN_VIEN.TEN FROM YEU_CAU_NHAP, SAN_PHAM, NHAN_VIEN WHERE SAN_PHAM.ID_SP = YEU_CAU_NHAP.ID_SP AND NHAN_VIEN.ID_NV = YEU_CAU_NHAP.ID_NV  AND YEU_CAU_NHAP.Status='Update'";
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
        public bool AddItemsToTable(String Id, String id_sp, String id_nv, int SL, int gia)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTaiKhoan = "Insert into Yeu_cau_nhap(ID_YCN, Ngay, ID_SP, ID_NV, Status, SL, Gia)values(@ID_YCN, @Ngay, @ID_SP, @ID_NV, @STATUS, @SL, @Gia);";
            DateTime date = DateTime.Now;
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Id_YCN", Id.Trim());
                    cmd.Parameters.AddWithValue("@ngay", date);
                    cmd.Parameters.AddWithValue("@ID_SP", id_sp.Trim());
                    cmd.Parameters.AddWithValue("@ID_NV", id_nv.Trim());
                    cmd.Parameters.AddWithValue("@Status", "UNCHECKED");
                    cmd.Parameters.AddWithValue("@SL", SL);
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
