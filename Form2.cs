using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace proyecto1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            cargar__bd2();
            cargartbldetalles();
        }
        

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter dt;
        DataTable table;
        
        /*
         esto muesta la consulta de la base de datos2 y lo muestra en un datagridview
             */
        public void cargar__bd2() {
            dgvDB2.DataSource = new consultas().consultabd2();
               
        }
        /*
         esto muestra la consulta de la base de datos2 y lo muestra en datagridview
             */
        public void cargartbldetalles() {
            dgvtbldetalles.DataSource = new consultas().consultatbldetalle();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        /*
            esta funcion hace una consulta especifica a la base de datos tbl_cabecera_est_tc 
            mediante el numero de tarjeta
             
             */
        private void txtfiltarbd2_TextChanged(object sender, EventArgs e)
        {
            cn = conexion.conectar();
            cn.Open();

            cmd = new SqlCommand("SELECT * FROM TBL_CABECERA_EST_TC WHERE C_NO_TARJETA LIKE'" + txtfiltarbd2.Text + "%'", cn);
            dt = new SqlDataAdapter(cmd);
            table = new DataTable();
            dt.Fill(table);
            dgvDB2.DataSource = table;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
         esta funcion hace una consulta especifica a la base de datos
         tbl_detalle_est_tc mediante numero de tarjeta
             */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cn = conexion.conectar();
            cn.Open();
            
            cmd = new SqlCommand("SELECT * FROM TBL_DETALLE_EST_TC WHERE D_NO_TARJETA LIKE'" + txttbldetalle.Text + "%'", cn); 
            dt = new SqlDataAdapter(cmd);
            table = new DataTable();
            dt.Fill(table);
            dgvtbldetalles.DataSource = table;
            
        }

        private void dgvDB2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("No se puedde editar");
        }

        private void dgvtbldetalles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("No se puede editar");
        }
        

        
        
        private void txttbldetalle_KeyPress(object sender, KeyPressEventArgs e)
        {

            validar v = new validar();
            v.solonumeros(e);

        }

        private void txtfiltarbd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar v = new validar();
            v.solonumeros(e);
        }
    }
}
