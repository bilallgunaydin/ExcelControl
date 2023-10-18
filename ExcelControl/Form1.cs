


using OfficeOpenXml;
using System.Data;

namespace ExcelControl
{
    public partial class Form1 : Form
    {
        private string excelFilePath1;
        private string excelFilePath2;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(excelFilePath1) || string.IsNullOrEmpty(excelFilePath2))
            {
                MessageBox.Show("Lütfen iki Excel dosyasý seçin.");
                return;
            }

            // Dosya uzantýsý kontrolü
            if (!IsValidExcelFile(excelFilePath1) || !IsValidExcelFile(excelFilePath2))
            {
                MessageBox.Show("Geçersiz dosya uzantýsý. Lütfen sadece Excel dosyasý (.xlsx, .xls) seçin.");
                return;
            }

            // Karþýlaþtýrma
            CompareExcelFiles();
        }
        private bool IsValidExcelFile(string filePath)
        {
            string[] validExtensions = { ".xlsx", ".xls" };
            return validExtensions.Any(ext => filePath.EndsWith(ext, StringComparison.OrdinalIgnoreCase));
        }
        private void CompareExcelFiles()
        {

            using (var package1 = new ExcelPackage(new FileInfo(excelFilePath1)))
            using (var package2 = new ExcelPackage(new FileInfo(excelFilePath2)))
            {
                var worksheets1 = package1.Workbook.Worksheets;
                var worksheets2 = package2.Workbook.Worksheets;

                if (worksheets1.Count != worksheets2.Count)
                {
                    MessageBox.Show("Sayfa sayýlarý eþit deðil.");
                    MessageBox.Show($"Excel 1 Sayfa Sayýsý: {worksheets1.Count}");
                    MessageBox.Show($"Excel 2 Sayfa Sayýsý: {worksheets2.Count}");
                    return;
                }

                int sheetCount = worksheets1.Count;

                // DataTable oluþtur
                DataTable comparisonTable = new DataTable();
                comparisonTable.Columns.Add("Aranan", typeof(string));
                comparisonTable.Columns.Add("Excel 1", typeof(string));
                comparisonTable.Columns.Add("Excel 2", typeof(string));
                comparisonTable.Columns.Add("Hücre Numarasý", typeof(string));

                // Ýlk sayfanýn hücre içeriklerini al
                var firstWorksheet1 = worksheets1[0];
                var firstWorksheet2 = worksheets2[0];

                int rowCount = firstWorksheet1.Dimension.End.Row;
                int colCount = firstWorksheet1.Dimension.End.Column;

                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        var cell1 = firstWorksheet1.Cells[row, col];
                        var cell2 = firstWorksheet2.Cells[row, col];

                        // Hücre tarih mi?
                        if (cell1.Style.Numberformat.Format == "mm-dd-yy" && cell2.Style.Numberformat.Format == "mm-dd-yy")
                        {
                            DateTime date1 = cell1.GetValue<DateTime>();
                            DateTime date2 = cell2.GetValue<DateTime>();

                            if (date1 != date2)
                            {
                                comparisonTable.Rows.Add("Tarih", date1.ToString(), date2.ToString(), GetCellAddress(row, col));
                            }
                        }

                        // Hücre rengi farklý mý?
                        if (cell1.Style.Fill.BackgroundColor.Rgb != cell2.Style.Fill.BackgroundColor.Rgb)
                        {
                            comparisonTable.Rows.Add("Farklý Renkler", cell1.Style.Fill.BackgroundColor.Rgb, cell2.Style.Fill.BackgroundColor.Rgb, GetCellAddress(row, col));
                        }

                        var cell1Text = cell1.Text;
                        var cell2Text = cell2.Text;

                        // Eðer hücre içerikleri farklý ise bu durumu DataTable'a ekle
                        if (cell1Text != cell2Text)
                        {
                            comparisonTable.Rows.Add("Farklý", cell1Text, cell2Text, GetCellAddress(row, col));
                        }
                    }
                }

                // DataGridView'e baðla
                comparisonResultsGrid.DataSource = comparisonTable;
            }
        }

        private string GetCellAddress(int row, int col)
        {
            return $"{Convert.ToChar('A' + col - 1)}{row}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelFilePath1 = openFileDialog.FileName;
                    label1.Text = $"Excel Dosyasý 1: {excelFilePath1}";
      
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelFilePath2 = openFileDialog.FileName;
                    label2.Text = $"Excel Dosyasý 2: {excelFilePath2}";
              
                }
            }
        }
    }
}