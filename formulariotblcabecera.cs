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
    public partial class formulariotblcabecera : Form
    {
        public formulariotblcabecera()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void formulariotblcabecera_Load(object sender, EventArgs e)
        {
            
            
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (new registrar().insertar(new string[] {txt_no_tarjeta.Text,txt_no_facturacion.Text,txt_fecha_factura.Text,txt_codigo_cliclo.Text,txt_fecha_limite_pago.Text,txt_c_limite_credito_rd.Text,txt_limite_credito_us.Text,txt_c_saldo_anterior_rd.Text,txt_c_saldo_anterior_us.Text,txt_c_disponible_rd.Text,txt_c_disponible_us.Text,txt_c_cred_pago_rd.Text,txt_c_cred_pago_us.Text,txt_c_deb_compra_rd.Text,txt_deb_compra_us.Text,txt_c_saldo_corte_rd.Text,txt_c_saldo_corte_us.Text,txt_c_bonificable_rd.Text,txt_c_bonificable_us.Text,txt_c_saldo_s_financia_rd.Text,txt_c_saldo_s_financia_us.Text,txt_c_saldo_n_financia_rd.Text,txt_c_saldo_n_financia_us.Text,txt_c_pago_minimo_rd.Text,txt_c_pago_minimo_us.Text,txt_c_importe_venc_rd.Text,txt_c_importe_venc_us.Text,txt_c_cuota_venc_rd.Text,txt_c_cuota_venc_us.Text,txt_c_nombre_cleinte.Text,txt_c_producto.Text,txt_c_dir01.Text,txt_c_dir02.Text,txt_c_dir03.Text,txt_c_dir04.Text,txt_c_msj01.Text,txt_c_msj02.Text,txt_c_msj03.Text,txt_c_msj04.Text,txt_c_msj05.Text,txt_c_zona_env.Text,txt_c_tarjeta_empresa.Text,txt_c_rnc_empresa.Text,txt_c_nombre_empresa.Text,txt_grupo_empresa.Text,txt_c_cuenta_bancaria.Text,txt_c_saldo_prom1_rd.Text,txt_saldo_prom1_us.Text,txt_saldo_prom2_rd.Text,txt_saldo_prom2_us.Text}))
            {

                MessageBox.Show("Se ha registrado correctamente");
                
            }
        }
    }
}
