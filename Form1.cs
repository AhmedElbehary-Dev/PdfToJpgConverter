using PdfiumViewer;
using System.Drawing.Imaging;

namespace PdfToJpgConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "PDF Files|*.pdf";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using var folderDialog = new FolderBrowserDialog();
                if (folderDialog.ShowDialog() != DialogResult.OK)
                    return;

                string baseOutputFolder = folderDialog.SelectedPath;

                foreach (string pdfFile in ofd.FileNames)
                {
                    using var document = PdfDocument.Load(pdfFile);

                    string pdfFileName = Path.GetFileNameWithoutExtension(pdfFile);
                    string outputFolder = Path.Combine(baseOutputFolder, pdfFileName);

                    Directory.CreateDirectory(outputFolder);

                    for (int i = 0; i < document.PageCount; i++)
                    {
                        using var image = document.Render(i, 300, 300, true);
                        string outputPath = Path.Combine(outputFolder, $"page_{i + 1}.jpg");
                        image.Save(outputPath, ImageFormat.Jpeg);
                    }
                }

                MessageBox.Show("All PDFs converted to JPGs in separate folders!");
            }
        }
        private void btnRenameImages_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var files = ofd.FileNames;
                string folderPath = Path.GetDirectoryName(files[0])!;

                int counter = 1;
                foreach (var file in files.OrderBy(f => f)) // Optional: sort to control rename order
                {
                    string extension = Path.GetExtension(file);
                    string newFileName = $"{counter}{extension}";
                    string newPath = Path.Combine(folderPath, newFileName);

                    if (File.Exists(newPath))
                    {
                        // Skip if destination file already exists
                        counter++;
                        continue;
                    }

                    File.Move(file, newPath);
                    counter++;
                }

                MessageBox.Show("Images renamed successfully (skipped existing names)!");
            }
        }
    }
}
