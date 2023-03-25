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
            // Excel dosyasýnýn yolunu belirtin
            string filePath = @"C:\Users\Sonerr\Desktop\aaa.xlsm";

            // Excel dosyasýný yükleyin
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Excel dosyasýndaki verileri bir DataTable nesnesine yükleyin
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    // DataGridView nesnesindeki verileri DataTable nesnesinden yükleyin
                    dataGridView1.DataSource = result.Tables[0];
                }
            }
        }
    }
}