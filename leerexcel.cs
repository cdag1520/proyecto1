using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExcelDataReader;
using System.Windows.Forms;
using System.Data;

namespace convertfile
{
    class leerexcel
    {

        public void leerxls(ComboBox data, DataSet result)
        {
            /* Metodo 1 */
            //DataSet result;


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


                    data.Items.Clear();
                    result = reader.AsDataSet(conf);
                    foreach (DataTable dt in result.Tables)
                    {
                        data.Items.Add(dt.TableName);
                    };
                    reader.Close();




                }

            }

        }
    }
}
