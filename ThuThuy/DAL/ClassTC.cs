using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuThuy.DAL
{
    internal class ClassTC
    {
        public DataTable ReadItemsTable()
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select HOA_DON.ID_HD, HOA_DON.NGAY, KHACH_HANG.HO_TEN, SUM(GIA) as TongTien from HOA_DON, KHACH_HANG, CTHD where HOA_DON.ID_KH = KHACH_HANG.ID_KH and HOA_DON.ID_HD = CTHD.ID_HD Group by HOA_DON.ID_HD, HOA_DON.NGAY,  KHACH_HANG.HO_TEN UNION Select PHIEU_NHAP_KHO.ID_PNK, PHIEU_NHAP_KHO.NGAY, NHAN_VIEN.TEN, SUM(CTNK.GIA)  from PHIEU_NHAP_KHO, CTNK, NHAN_VIEN where PHIEU_NHAP_KHO.ID_NV = NHAN_VIEN.ID_NV  and PHIEU_NHAP_KHO.ID_PNK = CTNK.ID_PNK Group by PHIEU_NHAP_KHO.ID_PNK, PHIEU_NHAP_KHO.NGAY, NHAN_VIEN.TEN";
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
        public DataTable readC(string ID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select ID_PNK, SAN_PHAM.TEN, SO_LUONG, CTNK.GIA from CTNK, SAN_PHAM where CTNK.ID_SP = SAN_PHAM.ID_SP and CTNK.ID_PNK = @ID";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                cmd.Parameters.AddWithValue("@ID", ID.Trim());
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
        public DataTable readT(string ID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select id_hd, dich_vu.TEN, CTHD.SOLUONG, CTHD.GIA from DICH_VU, CTHD where DICH_VU.ID_DV = CTHD.ID_DV and  CTHD.ID_HD = @ID";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                cmd.Parameters.AddWithValue("@ID", ID.Trim());
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

        public DataTable readToDate(string date)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select HOA_DON.ID_HD, HOA_DON.NGAY, KHACH_HANG.HO_TEN, SUM(GIA) as TongTien from HOA_DON, KHACH_HANG, CTHD where HOA_DON.ID_KH = KHACH_HANG.ID_KH and HOA_DON.ID_HD = CTHD.ID_HD and HOA_DON.NGAY = @date Group by HOA_DON.ID_HD, HOA_DON.NGAY,  KHACH_HANG.HO_TEN UNION Select PHIEU_NHAP_KHO.ID_PNK, PHIEU_NHAP_KHO.NGAY, NHAN_VIEN.TEN, SUM(CTNK.GIA)  from PHIEU_NHAP_KHO, CTNK, NHAN_VIEN where PHIEU_NHAP_KHO.ID_NV = NHAN_VIEN.ID_NV  and PHIEU_NHAP_KHO.ID_PNK = CTNK.ID_PNK and PHIEU_NHAP_KHO.NGAY = @date Group by PHIEU_NHAP_KHO.ID_PNK, PHIEU_NHAP_KHO.NGAY, NHAN_VIEN.TEN";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                cmd.Parameters.AddWithValue("@date", date.Trim());
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

        public DataTable readToMonth(string month)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select HOA_DON.ID_HD, HOA_DON.NGAY, KHACH_HANG.HO_TEN, SUM(GIA) as TongTien from HOA_DON, KHACH_HANG, CTHD where HOA_DON.ID_KH = KHACH_HANG.ID_KH and HOA_DON.ID_HD = CTHD.ID_HD and MONTH(HOA_DON.NGAY)=@date Group by HOA_DON.ID_HD, HOA_DON.NGAY,  KHACH_HANG.HO_TEN UNION Select PHIEU_NHAP_KHO.ID_PNK, PHIEU_NHAP_KHO.NGAY, NHAN_VIEN.TEN, SUM(CTNK.GIA)  from PHIEU_NHAP_KHO, CTNK, NHAN_VIEN where PHIEU_NHAP_KHO.ID_NV = NHAN_VIEN.ID_NV  and PHIEU_NHAP_KHO.ID_PNK = CTNK.ID_PNK and MONTH(PHIEU_NHAP_KHO.NGAY) = @date  Group by PHIEU_NHAP_KHO.ID_PNK, PHIEU_NHAP_KHO.NGAY, NHAN_VIEN.TEN";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                cmd.Parameters.AddWithValue("@date", month.Trim());
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

        public DataTable readToYear(string year)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select HOA_DON.ID_HD, HOA_DON.NGAY, KHACH_HANG.HO_TEN, SUM(GIA) as TongTien from HOA_DON, KHACH_HANG, CTHD where HOA_DON.ID_KH = KHACH_HANG.ID_KH and HOA_DON.ID_HD = CTHD.ID_HD and YEAR(HOA_DON.NGAY)=@date Group by HOA_DON.ID_HD, HOA_DON.NGAY,  KHACH_HANG.HO_TEN UNION Select PHIEU_NHAP_KHO.ID_PNK, PHIEU_NHAP_KHO.NGAY, NHAN_VIEN.TEN, SUM(CTNK.GIA)  from PHIEU_NHAP_KHO, CTNK, NHAN_VIEN where PHIEU_NHAP_KHO.ID_NV = NHAN_VIEN.ID_NV  and PHIEU_NHAP_KHO.ID_PNK = CTNK.ID_PNK and YEAR(PHIEU_NHAP_KHO.NGAY) = @date  Group by PHIEU_NHAP_KHO.ID_PNK, PHIEU_NHAP_KHO.NGAY, NHAN_VIEN.TEN";
            SqlCommand cmd = new SqlCommand(queryTaiKhoan, con.connect);
            try
            {
                cmd.Parameters.AddWithValue("@date", year.Trim());
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
