# PDF to JPG Converter

A simple desktop tool for converting PDF files into JPG images. This tool allows users to select multiple PDF files and convert each page into a separate JPG file. The images are saved in separate folders for each PDF file, with pages numbered sequentially.

Additionally, the tool provides functionality to rename images in a folder, ensuring that the images are renamed in sequence.

## Features

- **Convert PDFs to JPGs**: Converts all pages in the selected PDF files to JPG images.
- **Separate Folders for Each PDF**: Each PDF file gets its own folder, and the pages are saved as numbered JPG images.
- **Rename Images**: Allows users to rename the images in a folder sequentially (e.g., `1.jpg`, `2.jpg`, etc.).
- **Handle Multiple Files**: You can select and process multiple PDF files at once.

## Prerequisites

- .NET Framework 4.7.2 or higher
- PdfiumViewer NuGet package for rendering PDFs

## Installation

1. Clone or download the repository to your local machine.

    ```bash
    git clone <repository-url>
    ```

2. Open the solution in **Visual Studio**.

3. Restore the NuGet packages (if not already restored).

4. Build and run the project.

## Usage

### Converting PDFs to JPGs

1. Launch the application.
2. Click the **"Convert"** button to open a file dialog and select one or more PDF files.
3. After selecting the PDFs, choose the destination folder where the converted JPGs will be saved.
4. The tool will create separate folders for each PDF and save each page as a numbered JPG image (e.g., `page_1.jpg`, `page_2.jpg`, etc.).

### Renaming Images

1. Click the **"Rename Images"** button to open a file dialog and select one or more images from a folder.
2. The tool will rename the images sequentially (e.g., `1.jpg`, `2.jpg`, etc.).
3. If an image with the new name already exists, it will be skipped, and the tool will continue renaming the remaining images.

## Example Workflow

1. **Convert PDFs**: Convert your PDF documents into individual images by selecting them and specifying the output folder.
2. **Rename Images**: If you have multiple images in a folder, rename them sequentially for better organization.

## Code Explanation

- **btnConvert_Click**: This event handler handles PDF to JPG conversion. It opens a file dialog to select PDFs, creates a folder for each PDF, and converts each page to JPG using PdfiumViewer.
- **btnRenameImages_Click**: This event handler handles renaming images in a folder. It allows users to rename images in sequential order, skipping existing filenames to avoid overwriting.

## License

This project is open-source and available under the [MIT License](LICENSE).

## Contributions

Feel free to fork the repository, contribute, and submit pull requests. Any improvements or bug fixes are welcome!

---

## Contact

For questions or suggestions, feel free to open an issue or reach out to the project maintainer.

