using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WA_Proyecto_Chamba_Search
{
    public class DaoDistrito
    {
        SqlConnection con = new SqlConnection("server=ENRIQUEEA;database=DB_ChambaSearch;integrated security=true");

        public DataTable listarDistrito()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM distrito ORDER BY 3", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}