using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ThuThuy.DAL
{
    internal class Connection
    {
        public SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-QSESO04I\HTRUC;Initial Catalog=QLNK;Integrated Security=True");
    }
}
