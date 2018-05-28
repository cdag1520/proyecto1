using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace proyecto1
{
    public partial class Form1 : Form 
    {

        private DataTable table;
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataAdapter dt;
        private DataSet ds;


        public Form1()
        {
            InitializeComponent();
            consultar_enc();
            //consultar_detall();
            paginacion = 0;
        }

        int paginacion;

        private void pasardatlbl() {
          lbltarjetas.Text = dgv1.CurrentRow.Cells[1].Value.ToString();

        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
             
            
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtfiltrar_KeyUp(object sender, KeyEventArgs e)
        {
     
        }

        private void consultar_detall() {
            string dato;
            dato = dgv1.CurrentRow.Cells[1].Value.ToString();
            dgvdetalle.DataSource = new consultas().consultardetalle(dato);
        }

        private void consultar_enc() {
            dgv1.DataSource = new consultas().consultar();
        }

        //probar before 

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            
            cn = pruebaconexion.conect();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM ESTA_ENCABEZADO WHERE CESTNRTA LIKE'" + txtfiltrar.Text + "%'", cn);
            dt = new SqlDataAdapter(cmd);
            
            table = new DataTable();
            dt.Fill(table);
            
            dgv1.DataSource = table;
            //cn.Close();
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtfiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar v = new validar();
            v.solonumeros(e);

        }

        public void dgv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            /*
            formulario1.txt_no_tarjeta.Text = dgv1.CurrentRow.Cells[1].Value.ToString();

            formulario1.Show();
            */
 
            //esto es para obtener los datos de la primera tabla para 
            //poder insertarlos en otra base de datos
            /*
            string[] data = new string[50];
            data[0] = dgv1.CurrentRow.Cells[1].Value.ToString();
            data[1] = dgv1.CurrentRow.Cells[2].Value.ToString();
            data[2] = dgv1.CurrentRow.Cells[3].Value.ToString();
            data[3] = dgv1.CurrentRow.Cells[4].Value.ToString();
            data[4] = dgv1.CurrentRow.Cells[5].Value.ToString();
            data[5] = dgv1.CurrentRow.Cells[6].Value.ToString();
            data[6] = dgv1.CurrentRow.Cells[7].Value.ToString();
            data[7] = dgv1.CurrentRow.Cells[8].Value.ToString();
            data[8] = dgv1.CurrentRow.Cells[9].Value.ToString();
            data[9] = dgv1.CurrentRow.Cells[10].Value.ToString();
            data[10] = dgv1.CurrentRow.Cells[11].Value.ToString();
            data[11] = dgv1.CurrentRow.Cells[12].Value.ToString();
            data[12] = dgv1.CurrentRow.Cells[13].Value.ToString();
            data[13] = dgv1.CurrentRow.Cells[14].Value.ToString();
            data[14] = dgv1.CurrentRow.Cells[15].Value.ToString();
            data[15] = dgv1.CurrentRow.Cells[16].Value.ToString();
            data[16] = dgv1.CurrentRow.Cells[17].Value.ToString();
            data[17] = dgv1.CurrentRow.Cells[18].Value.ToString();
            data[18] = dgv1.CurrentRow.Cells[19].Value.ToString();
            data[19] = dgv1.CurrentRow.Cells[20].Value.ToString();
            data[20] = dgv1.CurrentRow.Cells[21].Value.ToString();
            data[21] = dgv1.CurrentRow.Cells[22].Value.ToString();
            data[22] = dgv1.CurrentRow.Cells[23].Value.ToString();
            data[23] = dgv1.CurrentRow.Cells[24].Value.ToString();
            data[24] = dgv1.CurrentRow.Cells[25].Value.ToString();
            data[25] = dgv1.CurrentRow.Cells[26].Value.ToString();
            data[26] = dgv1.CurrentRow.Cells[27].Value.ToString();
            data[27] = dgv1.CurrentRow.Cells[28].Value.ToString();
            data[28] = dgv1.CurrentRow.Cells[29].Value.ToString();
            data[29] = dgv1.CurrentRow.Cells[30].Value.ToString();
            data[30] = dgv1.CurrentRow.Cells[31].Value.ToString();
            data[31] = dgv1.CurrentRow.Cells[32].Value.ToString();
            data[32] = dgv1.CurrentRow.Cells[33].Value.ToString();
            data[33] = dgv1.CurrentRow.Cells[34].Value.ToString();
            data[34] = dgv1.CurrentRow.Cells[35].Value.ToString();
            data[35] = dgv1.CurrentRow.Cells[36].Value.ToString();
            data[36] = dgv1.CurrentRow.Cells[37].Value.ToString();
            data[37] = dgv1.CurrentRow.Cells[38].Value.ToString();
            data[38] = dgv1.CurrentRow.Cells[39].Value.ToString();
            data[39] = dgv1.CurrentRow.Cells[40].Value.ToString();
            data[40] = dgv1.CurrentRow.Cells[41].Value.ToString();
            data[41] = dgv1.CurrentRow.Cells[42].Value.ToString();
            data[42] = dgv1.CurrentRow.Cells[43].Value.ToString();
            data[43] = dgv1.CurrentRow.Cells[44].Value.ToString();
            data[44] = dgv1.CurrentRow.Cells[45].Value.ToString();
            data[45] = dgv1.CurrentRow.Cells[46].Value.ToString();
            data[46] = dgv1.CurrentRow.Cells[47].Value.ToString();
            data[47] = dgv1.CurrentRow.Cells[48].Value.ToString();
            data[48] = dgv1.CurrentRow.Cells[49].Value.ToString();
            data[49] = dgv1.CurrentRow.Cells[50].Value.ToString();
            
            
            dgv1.DataSource = new registrar().insertar(data);

            */

            // esto es para consultar otra tabla lo que hace es 
            //obtener el numero de tarjeta para hacer la consulta
            // y asi mostrarlo en otro datagridview
           string dato;
           dato = dgv1.CurrentRow.Cells[1].Value.ToString();
           dgvdetalle.DataSource = new consultas().consultardetalle(dato);
            pasardatlbl();
            
        } 

        private void lbltarjetas_Click(object sender, EventArgs e)
        {

        }

        private void dgvdetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        private void dgvdetalle_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("No tiene permiso para editar esta información");
            
        }

        /*
         el button1_click abre un nuevo form donde estan las consultas de la 
         base de datos2 que esta seria tbl_cabecera_est_tc
             */
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 bd2 = new Form2();
            bd2.Show();
        }

        private void dgv1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            if (new registrar().insertar(new string[] { }  )) {

                MessageBox.Show("Se ha registrado correctamente");
                
            }
            */
        }

        /*
         1-Funcion del boton button2_click : primero en caso de que el formulario 
         este abierto y le das click en abrir formulario de nuevo con el abierto lo cierra 
         y lo vuelve a abrir porque si no se hace asi se abre 2 veces y da error.

        2-Luego entra en el foreach que llena los texbox con informacion de la base
        de datos por su numero de index.
             
             */
        private void button2_Click_1(object sender, EventArgs e)
        {

            int i = 1;


            formulariotblcabecera formulario1 = new formulariotblcabecera();
            if (formulario1.IsDisposed == true) {
                formulario1 = new formulariotblcabecera();
                
            }

            foreach (Control ctrl in formulario1.Controls.Cast<Control>().OrderBy(c => c.TabIndex)) {
                if (ctrl.GetType() == typeof(TextBox)) {
                    ctrl.Text = dgv1.CurrentRow.Cells[i].Value.ToString();
                    i++;
                }
            }
            formulario1.Show();
        }

        /*
         1-Funcion del boton button3_click : primero en caso de que el formulario 
         este abierto y le das click en abrir formulario de nuevo con el abierto lo cierra 
         y lo vuelve a abrir porque si no se hace asi se abre 2 veces y da error.

        2-Luego entra en el foreach que llena los texbox con informacion de la base
        de datos por su numero de index.
             
             */

        
        private void button3_Click(object sender, EventArgs e)
        {
            int i = 1;

            formulariotbldetalles formulariodetall = new formulariotbldetalles();
            if (formulariodetall.IsDisposed == true) {
                formulariodetall = new formulariotbldetalles();
            }

            try
            {
                foreach (Control ctrl in formulariodetall.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                {
                    if (ctrl.GetType() == typeof(TextBox))
                    {
                        ctrl.Text = dgvdetalle.CurrentRow.Cells[i].Value.ToString();
                        i++;
                    }
                    formulariodetall.Show();
                }
            }
            catch (Exception p) {
                MessageBox.Show("El campo que a seleccionado esta vacio ",p.Source);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paginacion = paginacion - 5;
            

            if (paginacion <= 0)
            {
                paginacion = 0;

            }
            ds.Clear();
            dt.Fill(ds, paginacion, 200, "ESTA_ENCABEZADO");
        }
    }
}
