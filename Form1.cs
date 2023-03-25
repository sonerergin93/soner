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

        // Excel dosyas�n�n yolu
        string filePath = "C:\\example.xlsx";

        // Sayfa ad�
        string sheetName = "Sheet1";

    // Yeni bir Excel �al��ma kitab� olu�tur
    using (var workbook = new XLWorkbook(filePath))
    {
        // Sayfa ad�na g�re sayfay� se�
        var worksheet = workbook.Worksheet(sheetName);

    // Sayfadaki t�m verileri al
    var cells = worksheet.CellsUsed();

    // Windows Forms DataGridView olu�tur
    var dataGridView = new DataGridView();
    dataGridView.Dock = DockStyle.Fill;
        dataGridView.AutoGenerateColumns = true;

        // Sat�rlar� DataGridView'e ekle
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