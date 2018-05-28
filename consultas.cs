using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace proyecto1
{
    class consultas
    {

        
       
        private SqlConnection cn = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader;
        private DataTable table = null;


        
       

        // consulta de ESTA_DETALLE

           
            /*
             esta funcion consulta la base de datos een la tabla esta_detalle*/
        public DataTable consultardetalle(string dato) {
            nombredetalle();
            string query = "SELECT * FROM ESTA_DETALLE WHERE DESTNRTA = '"+dato+"'";

            cn = pruebaconexion.conect();
            cn.Open();
            cmd = new SqlCommand(query, cn);
            reader = cmd.ExecuteReader();

            table.Load(reader);
            
            cn.Close();
            return table;
            
             }



        /*}
         esta funcion lo que hace es consultar la base de datos esta_encabezado*/
        // Consulta de ESTA_ENCABEZADO
        public DataTable consultar() {
            
            nombrecolummna();
            //string query = "SELECT FROM ESTA_ENCABEZADO";
            string query = "SELECT TOP 10 * FROM ESTA_ENCABEZADO";
            cn = pruebaconexion.conect();
            cn.Open();
            
            cmd = new SqlCommand(query,cn);
            
            reader = cmd.ExecuteReader();
            table.Load(reader);

            /* while (reader.Read()) {*/
            /*

                table.Rows.Add(new object[] { reader["ENC_ID"], reader["CESTNRTA"],
                reader["CESTNFAC"], reader["CESTFFAC"],  reader["CESTCCIC"],
                reader["CESTFLPA"], reader["CESTLCR1"], reader["CESTLCR2"],
                reader["CESTDIS1"], reader["CESTDIS2"], reader["CESTSMA1"],
                reader["CESTSMA2"], reader["CESTCRP1"], reader["CESTCRP2"],
                reader["CESTDBC1"], reader["CESTDBC2"], reader["CESTSCO1"],
                reader["CESTSCO2"], reader["CESTBON1"], reader["CESTBON2"],
                reader["CESTSSF1"], reader["CESTSSF2"], reader["CESTSNF1"],
                reader["CESTSNF2"], reader["CESTPMI1"], reader["CESTPMI2"],
                reader["CESTIVE1"], reader["CESTIVE2"], reader["CESTCVE1"],
                reader["CESTCVE2"], reader["CESTNOMB"], reader["CESTPROD"],
                reader["CESTDIR1"], reader["CESTDIR2"], reader["CESTDIR3"],
                reader["CESTDIR4"], reader["CESTMSG1"], reader["CESTMSG2"],
                reader["CESTMSG3"], reader["CESTMSG4"], reader["CESTMSG5"],
                reader["CESTZENV"], reader["CESTTEMP"], reader["CESTRNCE"],
                reader["CESTEMPR"], reader["CESTGEMP"], reader["CESTCTAB"],
                reader["CESTSPR1"], reader["CESTSPR2"], reader["CESTSPM1"],
                reader["CESTSPM2"], reader["ENCA_ESTATUS"], reader["ENCA_RUTA"]} );
        }
       cn.Close();*/
        reader.Close();
            cn.Close();
             return table;
            
        }
        /*
         estos son los nombres que se le asigna a la columnas del datagridview
             */
        public void nombredetalle() {
            table = new DataTable();
            table.Columns.Add("DET_ID");
            table.Columns.Add("DESTNRTA");
            table.Columns.Add("DESTNFAC");
            table.Columns.Add("DESTFFAC");
            table.Columns.Add("DESTFTRN");
            table.Columns.Add("DESTFPRO");
            table.Columns.Add("DESTCOMP");
            table.Columns.Add("DESTREFU");
            table.Columns.Add("DESTDESC");
            table.Columns.Add("DESTMONE");
            table.Columns.Add("DESTVRTR");
            table.Columns.Add("DESTCDTR");
            table.Columns.Add("DESTTITR");
            table.Columns.Add("DESTNCOM");
            table.Columns.Add("DESTCATC");
            table.Columns.Add("DESTNAUT");
            table.Columns.Add("DESTVRPC");
            table.Columns.Add("DESTNCDI");
            table.Columns.Add("DESTNCRE");
            table.Columns.Add("DESTESTA");
            table.Columns.Add("DESTFREV");
            table.Columns.Add("DESTOFIC");
            table.Columns.Add("DESTCDPR");
            table.Columns.Add("DESTORM");
            table.Columns.Add("DESTTAPL");
            table.Columns.Add("DESTCIPA");
            table.Columns.Add("BLANCO");
            }

        /*
         estos son los nombres que se le asigna a la columnas del datagridview
             */
        public void nombrecolummna()
        {
            table = new DataTable();

            table.Columns.Add("ENC_ID");
            table.Columns.Add("CESTNRTA");
            table.Columns.Add("CESTNFAC");
            table.Columns.Add("CESTFFAC");
            table.Columns.Add("CESTCCIC");
            table.Columns.Add("CESTFLPA");
            table.Columns.Add("CESTLCR1");
            table.Columns.Add("CESTLCR2");
            table.Columns.Add("CESTDIS1");
            table.Columns.Add("CESTDIS2");
            table.Columns.Add("CESTSMA1");
            table.Columns.Add("CESTSMA2");
            table.Columns.Add("CESTCRP1");
            table.Columns.Add("CESTCRP2");
            table.Columns.Add("CESTDBC1");
            table.Columns.Add("CESTDBC2");
            table.Columns.Add("CESTSCO1");
            table.Columns.Add("CESTSCO2");
            table.Columns.Add("CESTBON1");
            table.Columns.Add("CESTBON2");
            table.Columns.Add("CESTSSF1");
            table.Columns.Add("CESTSSF2");
            table.Columns.Add("CESTSNF1");
            table.Columns.Add("CESTSNF2");
            table.Columns.Add("CESTPMI1");
            table.Columns.Add("CESTPMI2");
            table.Columns.Add("CESTIVE1");
            table.Columns.Add("CESTIVE2");
            table.Columns.Add("CESTCVE1");
            table.Columns.Add("CESTCVE2");
            table.Columns.Add("CESTNOMB");
            table.Columns.Add("CESTPROD");
            table.Columns.Add("CESTDIR1");
            table.Columns.Add("CESTDIR2");
            table.Columns.Add("CESTDIR3");
            table.Columns.Add("CESTDIR4");
            table.Columns.Add("CESTMSG1");
            table.Columns.Add("CESTMSG2");
            table.Columns.Add("CESTMSG3");
            table.Columns.Add("CESTMSG4");
            table.Columns.Add("CESTMSG5");
            table.Columns.Add("CESTZENV");
            table.Columns.Add("CESTTEMP");
            table.Columns.Add("CESTRNCE");
            table.Columns.Add("CESTEMPR");
            table.Columns.Add("CESTGEMP");
            table.Columns.Add("CESTCTAB");
            table.Columns.Add("CESTSPR1");
            table.Columns.Add("CESTSPR2");
            table.Columns.Add("CESTSPM1");
            table.Columns.Add("CESTSPM2");
            table.Columns.Add("ENCA_ESTATUS");
            table.Columns.Add("ENCA_RUTA");
           
        }


        //consultas base de datos2 tabla tbl cabecera tc
        public DataTable consultabd2() {
            nombrebd2();
            string query = "SELECT * FROM TBL_CABECERA_EST_TC";

            cn = conexion.conectar();
            cn.Open();
            cmd = new SqlCommand(query, cn);
            reader = cmd.ExecuteReader();
            table.Load(reader);
            
            cn.Close();
            return table;

        }

        //Consulta tabla tbl detalles
        public DataTable consultatbldetalle() {
            nombretbldetalles();
            string query = "SELECT * FROM TBL_DETALLE_EST_TC";
            cn = conexion.conectar();
            cn.Open();

            cmd = new SqlCommand(query, cn);
            reader = cmd.ExecuteReader();
            table.Load(reader);

            cn.Close();
            return table;
        }

        /*
         estos son los nombres que se le asigna a la columnas del datagridview
             */
        public void nombretbldetalles() {
            table = new DataTable();
        }

        /*
         estos son los nombres que se le asigna a la columnas del datagridview
             */
        public void nombrebd2() {
            table = new DataTable();
            
        }


    }

    }

