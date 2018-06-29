using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;






namespace convertfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        DataSet result;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {   /*
            leerexcel dato = new leerexcel();
            dato.leerxls(cbohoja, result);
            */
            /* Metodo 1 */

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel workbook| *.xlsx", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    var conf = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };
                    cbohoja.Items.Clear();
                    result = reader.AsDataSet(conf);
                    foreach (DataTable dt in result.Tables)
                    {
                        cbohoja.Items.Add(dt.TableName);
                    };
                    reader.Close();




                }


            }

            /* Metodo 2*/
            /*
            List<string> tblNames = new List<string>();
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs))
                    {
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            UseColumnDataType = true,

                            ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });

                        foreach (DataTable dt in result.Tables)
                            tblNames.Add(dt.TableName);
                    }
                }
            }
            */



        }

        private void cbohoja_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = result.Tables[cbohoja.SelectedIndex];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfecha_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
            if (txtfecha.Length.Equals(2) || txtfecha.Length.Equals(5))
                txtfecha.Text = txtfecha.Text.Trim() + "/";*/
        }
        string[] valores;
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            /*Recorre todo el exel en busca de la informacion en todos los campos */
            foreach ( DataGridViewRow dat in dataGridView1.Rows)
            {
                DataRow myrow = (dat.DataBoundItem as DataRowView).Row;
                string[] valores = new string[myrow.ItemArray.Length];

                for (int i = 0; i < dat.Cells.Count; i++)
                {
                    
                    valores[i] = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                    
                }
                
               
            }

            DateTime fecha = DateTime.Today;
            MessageBox.Show(fecha.ToString("yyyymmmmdd"));

            //fecha = fecha.Replace(remo,remo2);
            //StringBuilder text = new StringBuilder();
            string ruta = "C:\\Users\\c.acosta\\Documents\\"+txtidcompañia.Text+txtfecha.Text.Replace("/","")+txthora.Text.Replace(":","")+"S.txt";
            //text.AppendLine(text.ToString());
            
            text.Append("H" + txtidcompañia.Text+ dataGridView1.CurrentRow.Cells[0].Value.ToString().PadRight(11)+txtfecha.Text.Replace("/","").PadRight(8)+txthora.Text.Replace(":","").PadRight(6));
           // text.AppendLine(text.ToString());
            File.AppendAllText(ruta, text.ToString());
            /* StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow row in dgv1.SelectedRows)
            {
                StringBuilder linea = new StringBuilder();

                foreach (DataGridViewColumn col in dgv1.Columns)
                {
                    linea.Append("----");
                    linea.Append((row.Cells[col.Index].Value));
                }

                sb.AppendLine(linea.ToString());

            }

            string path = "C:\\Users\\c.acosta\\Documents\\registros_esta_encabezado.txt";
            File.AppendAllText(path, sb.ToString());*/
            MessageBox.Show("Conversion Exitosa");
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FechaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (txtfecha.TextLength.Equals(2) || txtfecha.TextLength.Equals(5))
            {
                txtfecha.Text = txtfecha.Text.Trim() + "/";
            }

            /*
//Esto quiere decir si el largo de tu textbox es igual a 2 o 5 le agrega la barra /
           if(FechaTextBox.Length.Equals(2) || FechaTextBox.Length.Equals(5))
                   FechaTextBox.Text = FechaTextBox.Text.Trim()+"/";

        }*/
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

         

        }

        private void txtfecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
