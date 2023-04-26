using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuThuy.DAL
{
    internal class ClassDV
    {
        public DataTable ReadItemsTable()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "Select * from DICH_VU";
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
        public int countItems(string id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String queryTaiKhoan = "select Gia from DICH_VU where ID_DV = @id";
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
