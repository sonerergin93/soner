using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Excel dosyasýnýn yolu
        string filePath = "C:\\example.xlsx";

        // Sayfa adý
        string sheetName = "Sheet1";

    // Yeni bir Excel çalýþma kitabý oluþtur
    using (var workbook = new XLWorkbook(filePath))
    {
        // Sayfa adýna göre sayfayý seç
        var worksheet = workbook.Worksheet(sheetName);

    // Sayfadaki tüm verileri al
    var cells = worksheet.CellsUsed();

    // Windows Forms DataGridView oluþtur
    var dataGridView = new DataGridView();
    dataGridView.Dock = DockStyle.Fill;
        dataGridView.AutoGenerateColumns = true;

        // Satýrlarý DataGridView'e ekle
        foreach (var row in cells.RowsUsed())
        {
            var dataGridViewRow = new DataGridViewRow();

            foreach (var cell in row.Cells())
            {
                var cellValue = cell.Value;
    dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell { Value = cellValue
});
            }

            dataGridView.Rows.Add(dataGridViewRow);
        }

        // DataGridView'i konteyner nesnesine ekle
        panel1.Controls.Add(dataGridView);
    }
}
}