/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace proyecto1
{
    class filtrar
    {
        SqlConnection cn;
        SqlCommand cmd;

        public DataTable buscar() {
            string query = "SELECT * From Esta_Encabezado WHERE ENC_ID =";
            cn = pruebaconexion.conect();
            cn.Open();
            cmd = new SqlCommand(query,cn);
            cmd.ExecuteNonQuery();
            




        }
    }
}
*/