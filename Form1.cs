using System.Data;
using System.IO;
using ExcelDataReader;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Excel dosyas�n�n yolunu belirtin
            string filePath = @"C:\Users\Sonerr\Desktop\aaa.xlsm";

            // Excel dosyas�n� y�kleyin
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Excel dosyas�ndaki verileri bir DataTable nesnesine y�kleyin
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    // DataGridView nesnesindeki verileri DataTable nesnesinden y�kleyin
                    dataGridView1.DataSource = result.Tables[0];
                }
            }
        }
    }
}