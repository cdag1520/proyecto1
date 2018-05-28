

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyecto1
{
    class conexion
    {
        

        public static SqlConnection conectar() {
            string server = "192.168.0.40";
            string db = "DBEST_CUENTAS_TC";
            //string pass = "false";
            string user = "frosario";
            string password = "Zxc.12311";
            SqlConnection cn = new SqlConnection("Data Source =" +server+ ";Initial Catalog=" +db+ ";User ID=" +user+ ";Password ="+password+"");

            //SqlConnection cn = new SqlConnection("Data Source=" + server + ";Initial Catalog=" + db + ";Integrated Security=" + pass + "");
            return cn;


        }
        

    }
}

