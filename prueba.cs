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
    class prueba
    {

        SqlConnection cn;
        SqlCommand cmd;

        public bool insertarconsulta() {

            cn = pruebaconexion.conect();
            cn.Open();   
            string query = "INSERT INTO ";
            cmd = new SqlCommand(query,cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha insertado Correctamente");

            return true;

        }
    }
}
