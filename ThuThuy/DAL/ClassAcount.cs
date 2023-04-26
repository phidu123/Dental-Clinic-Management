using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Controls;
using System.ServiceModel.Channels;
using System.Windows;
using System.Globalization;
using System.Net.NetworkInformation;

namespace ThuThuy.DAL
{
    class ClassAcount
    {
        public String strGetName(String Id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTai_khoan = "Select Ten from Nhan_vien where Id_NV = @Id";
            try
            {
                using (SqlCommand cmd =     new SqlCommand(queryTai_khoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Id", Id.Trim());
                    return (String)cmd.ExecuteScalar();
                }
            }
            catch
            {
                throw;
            }
        }
        public String strGetId(String Username)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTai_khoan = "Select Id_NV from Nhan_vien where UserName = @Username";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTai_khoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Username", Username.Trim());
                    return (String)cmd.ExecuteScalar();
                }
            }
            catch
            {
                throw;
            }
        }
        
        public int checkLogin(String Username, String Pass)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryTai_khoan = "Select COUNT(*) from Tai_khoan where UserName = @Username and Pass = @Pass";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTai_khoan, con.connect))
                {
                    int cv;
                    cmd.Parameters.AddWithValue("@Username", Username.Trim());
                    cmd.Parameters.AddWithValue("@Pass", Pass.Trim());
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        queryTai_khoan = "Select ID_CV from Nhan_vien where UserName = @Username";
                        using (SqlCommand checkCMD = new SqlCommand(queryTai_khoan,con.connect))
                        {
                            checkCMD.Parameters.AddWithValue("@Username", Username.Trim());
                            cv = Convert.ToInt32(checkCMD.ExecuteScalar());
                            return cv;
                        }
                    }
                    else
                    {
                        return -10;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        public bool AddItemsToTable(String Id, String Username, String Pass, int ID_CV, String Ten, String SDT, String NgaySinh, bool Gender, int Songaylam, int luongngay, int tongluong)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string queryTai_khoan = "Insert into Tai_Khoan(Username, Pass)values(@Username,@Pass);Insert into Nhan_Vien(Id_NV, Ten, Username, ID_CV, SDT, Gioi_Tinh, Ngay_Sinh, so_ngay_lam, luong_ngay, tong_luong)values(@Id,@Ten,@Username,@ID_CV,@SDT,@Gender,@NgaySinh, @songaylam, @luongngay, @tongluong)";
            
            string dateB = DateTime.ParseExact(NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime date = DateTime.Parse(dateB);
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTai_khoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Username", Username.Trim());
                    cmd.Parameters.AddWithValue("@Pass", Pass.Trim());
                    cmd.Parameters.AddWithValue("@Id", Id.Trim());
                    cmd.Parameters.AddWithValue("@ID_CV", ID_CV);
                    cmd.Parameters.AddWithValue("@Ten", Ten.Trim());
                    cmd.Parameters.AddWithValue("@SDT", SDT.Trim());
                    cmd.Parameters.AddWithValue("@NgaySinh", date);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@songaylam", Songaylam);
                    cmd.Parameters.AddWithValue("@luongngay", luongngay);
                    cmd.Parameters.AddWithValue("@tongluong", tongluong);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch 
            {
                throw;
            }
        }

        public bool checkExistU(string Username)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryChange = "Select COUNT(*) from TAI_KHOAN where Username = @US";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryChange, con.connect))
                {
                    cmd.Parameters.AddWithValue("@US", Username.Trim());
                    if(cmd.ExecuteScalar().ToString() == "1")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        public bool Change(String Id, String Username, String Pass, int Chucvu, String SDT, String NgaySinh, int Songaylam, int luongngay, int tongluong)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryChange ="Update Tai_khoan set Pass = @Pass where UserName=@Username; Update Nhan_vien set ID_CV = @CV, SDT = @SDT, Ngay_sinh = @date, So_ngay_lam = @numdate, Luong_ngay = @salary, tong_luong = @tongluong where ID_NV = @ID";
            string dateB = DateTime.ParseExact(NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime date = DateTime.Parse(dateB);
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryChange, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Username", Username.Trim());
                    cmd.Parameters.AddWithValue("@ID", Id.Trim());
                    cmd.Parameters.AddWithValue("@Pass", Pass.Trim());
                    cmd.Parameters.AddWithValue("@CV", Chucvu);
                    cmd.Parameters.AddWithValue("@SDT", SDT.Trim());
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@numdate", Songaylam);
                    cmd.Parameters.AddWithValue("@salary", luongngay);
                    cmd.Parameters.AddWithValue("@tongluong", tongluong);
                    cmd.ExecuteNonQuery();
                }
                return true;
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
            String queryTai_khoan = "Select Id_NV, Nhan_vien.UserName, Tai_khoan.Pass, ID_CV,Ten,SDT from Nhan_vien, Tai_khoan\r\nwhere Tai_khoan.Username = Nhan_vien.UserName";
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
        public bool disable(string ID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string queryChange = "Update Nhan_vien set ID_CV = 0 where ID_NV=@ID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryChange, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID", ID.Trim());
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public DataTable ReadInfoNV()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTai_khoan = "Select NHAn_Vien.ID_NV, NHAN_VIEN.TEN, NHAN_VIEN.SDT ,COALESCE(sum(DON_PHEP.TONG_SO),'0')as Ngay_Nghi from NHAN_VIEN left join DON_PHEP on MONTH(DON_PHEP.BAT_DAU) = MONTH(GETDATE()) AND NHAN_VIEN.ID_NV = DON_PHEP.ID_NV group by NHAn_Vien.ID_NV, NHAN_VIEN.TEN, NHAN_VIEN.SDT";
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
        public DataRow ReadInfo(String iD)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTai_khoan = "Select ID_NV,NHAN_VIEN.TEN, NHAN_VIEN.Username,TAI_KHOAN.pass,SDT,NHAN_VIEN.ID_CV,NGAY_SINH,SO_NGAY_LAM,LUONG_NGAY From NHAN_VIEN, TAI_KHOAN where NHAN_VIEN.ID_NV = @ID and NHAN_VIEN.Username = TAI_KHOAN.Username";
            SqlCommand cmd = new SqlCommand(queryTai_khoan, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@ID", iD.Trim());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    DataRow row = dt.Rows[0];
                    return row;
                }
            }
            catch
            {
                throw;
            }
        }
        public int CountData(int numId)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTai_khoan = "select Count(*) From Nhan_vien where ID_CV = " + numId;
            
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTai_khoan, con.connect))
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
        public bool AddItemsNN(String Id, int SoNgay, string id_nv)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string queryTai_khoan = "Insert into DON_PHEP(ID_DP, BAT_DAU, TONG_SO,ID_NV)values(@Id,@date,@Num,@ID_NV)";
            DateTime date = DateTime.Now;
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTai_khoan, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Id", Id.Trim());
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@Num", SoNgay);
                    cmd.Parameters.AddWithValue("@Id_NV", id_nv.Trim());
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        public int countItemsNN()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select Top 1 (ID_DP) from DON_PHEP ORDER BY ID_DP DESC";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect))
                {
                    string Id = cmd.ExecuteScalar().ToString();
                    return Int32.Parse(Id.Substring(1, Id.Length - 1));
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
