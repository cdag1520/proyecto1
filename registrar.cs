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
    class registrar
    {
        SqlConnection cn;
        SqlCommand cmd;
        

        public bool insertar(string[] data)
        {

            string query = "INSERT INTO TBL_CABECERA_EST_TC (C_NO_TARJETA," +
                "C_NO_FACTURACION," +
                "c_FECHA_FACTURA," +
                "C_CODIGO_CLICLO," +
                "C_FECHA_LIMITE_PAGO," +
                "C_LIMITE_CREDITO_RD," +
                "C_LIMITE_CREDITO_US," +
                "C_SALDO_ANTERIOR_RD," +
                "C_SALDO_ANTERIOR_US," +
                "C_DISPONIBLE_RD," +
                "C_DISPONIBLE_US," +
                "C_CRED_PAGO_RD," +
                "C_CRED_PAGO_US," +
                "C_DEB_COMPRA_RD," +
                "C_DEB_COMPRA_US," +
                "C_SALDO_CORTE_RD," +
                "C_SALDO_CORTE_US," +
                "C_BONIFICABLE_RD," +
                "C_BONIFICABLE_US," +
                "C_SALDO_S_FINANCIA_RD," +
                "C_SALDO_S_FINANCIA_US," +
                "C_SALDO_N_FINANCIA_RD," +
                "C_SALDO_N_FINANCIA_US," +
                "C_PAGO_MINIMO_RD," +
                "C_PAGO_MINIMO_US," +
                "C_IMPORTE_VENC_RD," +
                "C_IMPORTE_VENC_US," +
                "C_CUOTA_VENC_RD," +
                "C_CUOTA_VENC_US," +
                "C_NOMBRE_CLEINTE," +
                "C_PRODUCTO," +
                "C_DIR01," +
                "C_DIR02," +
                "C_DIR03," +
                "C_DIR04," +
                "C_MSJ01," +
                "C_MSJ02," +
                "C_MSJ03," +
                "C_MSJ04," +
                "C_MSJ05," +
                "C_ZONA_ENV," +
                "C_TARJETA_EMPRESA," +
                "C_RNC_EMPRESA," +
                "C_NOMBRE_EMPRESA," +
                "C_GRUPO_EMPRESA," +
                "C_CUENTA_BANCARIA," +
                "C_SALDO_PROM1_RD," +
                "C_SALDO_PROM1_US," +
                "C_SALDO_PROM2_RD," +
                "C_SALDO_PROM2_US)VALUES ('" + data[0] + "', '" + data[1] + "', '" + Convert.ToDateTime(data[2]).ToString("yyyy-MM-dd") + "', '" + data[3] + "', '" + Convert.ToDateTime(data[4]).ToString("yyyy-MM-dd") + "', '" + data[5] + "', '" + data[6] + "', '" + data[7] + "', '" + data[8] + "', '" + data[9] + "', '" + data[10] + "', '" + data[11] + "', '" + data[12] + "', '" + data[13] + "', '" + data[14] + "', '" + data[15] + "', '" + data[16] + "', '" + data[17] + "', '" + data[18] + "', '" + data[19] + "', '" + data[20] + "', '" + data[21] + "', '" + data[22] + "', '" + data[23] + "', '" + data[24] + "', '" + data[25] + "', '" + data[26] + "', '" + data[27] + "', '" + data[28] + "', '" + data[29] + "', '" + data[30] + "', '" + data[31] + "', '" + data[32] + "', '" + data[33] + "', '" + data[34] + "', '" + data[35] + "', '" + data[36] + "', '" + data[37] + "', '" + data[38] + "', '" + data[39] + "', '" + data[40] + "', '" + data[41] + "', '" + data[42] + "', '" + data[43] + "', '" + data[44] + "', '" + data[45] + "', '" + data[46] + "', '" + data[47] + "', '" + data[48] + "','"+data[49]+"');";
           // MessageBox.Show(query);
            cn = conexion.conectar();
            cn.Open();

            cmd = new SqlCommand(query, cn);

             cmd.ExecuteNonQuery();
            cn.Close();
            /*
            if (cmd.ExecuteNonQuery() > 0)
            {
                cn.Close();
                return true;


            }*/


            return true; ;
        }


        public bool insertardetalles_bd2(string[] data1)
        {
           
                formulariotbldetalles det = new formulariotbldetalles();


                string query = "INSERT INTO TBL_DETALLE_EST_TC(D_NO_TARJETA," +
                    "D_NO_FACTURTACION," +
                    "D_FECHA_FACTURACION," +
                    "D_FECHA_TRANS," +
                    "D_FECHA_PROC," +
                    "D_COMPROBANTE," +
                    "D_REFERENCIA_UNIVERSAL," +
                    "D_DESCRIPCION," +
                    "D_MONEDA," +
                    "D_VALOR_TRANSACCION," +
                    "D_CODIGO_TRANSACCION," +
                    "D_TIPO_TRANSCCION," +
                    "D_NO_COMERCIO," +
                    "D_CATEGORIA_COMERCIO," +
                    "D_NO_AUTORIZACION," +
                    "D_VALOR_PRIMERA_CUOTA," +
                    "D_NO_CUOTA_DIF," +
                    "D_NO_CUOTA_REF," +
                    "D_EST_TRANSACCION," +
                    "D_FECHA_REVERSION," +
                    "D_OFICINA," +
                    "D_CODIGO_PRODUCTO," +
                    "D_ORIGEN_MOVIMIENTO," +
                    "D_TIPO_APPLICACION," +
                    "D_CIUDAD_PAIS) VALUES(" +data1[0] + ",'" + data1[1] + "','" + Convert.ToDateTime(data1[2]).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(data1[3]).ToString("yyyy-MM-dd") + "','" +Convert.ToDateTime(data1[4]).ToString("yyyy-MM-dd") + "','" + data1[5] + "','" + data1[6] + "','" + data1[7] + "','" + data1[8] + "','" + data1[9] + "','" + data1[10] + "','" + data1[11] + "','" + data1[12] + "','" + data1[13] + "','" + data1[14] + "','" + data1[15] + "','" + data1[16] + "','" + data1[17] + "','" + data1[18] + "','" +Convert.ToDateTime(data1[19]).ToString("yyyy-MM-dd") + "','" + data1[20] + "','" + data1[21] + "','" + data1[22] + "','" + data1[23] + "','" + data1[24] + "')";
                cn = conexion.conectar();
                cn.Open();
                cmd = new SqlCommand(query, cn);

                cmd.ExecuteNonQuery();
                /*
                if (cmd.ExecuteNonQuery() > 0) {
                    cn.Close();
                    return true;
                }
                */
                cn.Close();
                return true;
           


            }
            

       
    }
}
