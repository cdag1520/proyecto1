using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class formulariotbldetalles : Form
    {
        public formulariotbldetalles()
        {
            InitializeComponent();
        }

        private void txt_est_transaccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new registrar().insertardetalles_bd2(new string[] {txt_notarjeta.Text , txt_nofacturacion.Text, txt_fecha_facturacion.Text, txt_fecha_trans.Text, txt_fecha_proc.Text, txt_comprobante.Text, txt_referencia_universal.Text, txt_descripcion.Text, txt_dmoneda.Text, txt_valor_transaccion.Text, txt_codigo_transaccion.Text, txt_tipo_transaccion.Text, txt_d_no_comercio.Text, txt_categoria_comercio.Text, txt_noautorizacion.Text, txt_d_valor_primera_cuota.Text, txt_no_cuota_dif.Text, txt_cuota_ref.Text, txt_est_transaccion.Text, txt_fecha_reversion.Text, txt_oficina.Text, txt_codigo_producto.Text, txt_origen_movimiento.Text, txt_tipo_applicacion.Text, txt_ciudad_pais.Text}))
            {

                MessageBox.Show("Se ha registrado correctamente");

            }
        }

        private void formulariotbldetalles_Load(object sender, EventArgs e)
        {
            
        }
    }
}
