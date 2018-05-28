
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyecto1
{
    class pruebaconexion
    {
        
        public static SqlConnection conect() {
    
            string server = "SERMON02";
            string database = "bla_estados";
            
            string pass = "true";

            SqlConnection cn = new SqlConnection("Data Source="+server+";Initial Catalog="+database+";Integrated Security="+pass+"");
            
            return cn;            


        }

        

    }
}
