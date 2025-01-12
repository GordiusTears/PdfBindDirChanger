using System;
using iText.Kernel.Pdf;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;
using System.IO;

namespace PdfBindDirChanger
{
    public partial class Form1 : Form
    {
        private string sourceFolder = string.Empty;
        private string destFolder   = string.Empty;
        // bind direction: right = true, left = false;
        private bool RLmode       = true; 

        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            using (var dialogBox = new CommonOpenFileDialog())
            {
                dialogBox.IsFolderPicker = true;
                if (dialogBox.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    sourceFolder = dialogBox.FileName;
                }
            }
            if (sourceFolder != null)
            {
                textBoxSrcFlder.Text = sourceFolder;
            }
       }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (var dialogBox = new CommonOpenFileDialog())
            {
                dialogBox.IsFolderPicker = true;
                if (dialogBox.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    destFolder = dialogBox.FileName;
                }
            }
            if (sourceFolder != null)
            {
                textBoxDstFlder.Text = destFolder;
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (RLmode)
            {
                button3.Text = "左綴じ";
                RLmode = false;
            }
            else
            {
                button3.Text = "右綴じ";
                RLmode = true;
            }
        }
        // 変換実行ボタン
        private void Button4_Click(object sender, EventArgs e)
        {
            textBoxSrcFileList.ResetText();
            textBoxDstFileList.ResetText();
            if (CheckFolders())
            {
                string[] pdfFiles = System.IO.Directory.GetFiles(sourceFolder, "*.pdf");
                textBoxSrcFileList.Text = String.Join("\r\n", pdfFiles);
                foreach (string pdfFile in pdfFiles)
                {
                    string convedPdf = ConvPdf(pdfFile);
                    textBoxDstFileList.AppendText(convedPdf + "\r\n");
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckFolders()
        {
            if (sourceFolder.Length < 1)
            {
                MessageBox.Show("変換前フォルダを指定して下さい。", "エラー", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (destFolder.Length < 1)
            {
                MessageBox.Show("変換後フォルダを指定して下さい。", "エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (sourceFolder == destFolder)
            {
                MessageBox.Show("変換前後のフォルダが同じです。", "エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private string ConvPdf(string srcPdfFilePath)
        {
            var pdfFileName       = Path.GetFileName(srcPdfFilePath);
            var convPdfFilePath   = System.IO.Path.Combine(destFolder, pdfFileName);
            var pdfReader         = new PdfReader(srcPdfFilePath);
            var pdfWriter         = new PdfWriter(convPdfFilePath);
            var pdfDocument       = new PdfDocument(pdfReader, pdfWriter);
            var viewerPreferences = new PdfViewerPreferences();

            if (RLmode)
            {
                viewerPreferences.SetDirection(PdfViewerPreferences.PdfViewerPreferencesConstants.RIGHT_TO_LEFT);
            }
            else
            {
                viewerPreferences.SetDirection(PdfViewerPreferences.PdfViewerPreferencesConstants.LEFT_TO_RIGHT);
            }
            pdfDocument.GetCatalog().SetViewerPreferences(viewerPreferences);
            pdfDocument.Close();
            pdfWriter.Close();
            pdfReader.Close();
            return convPdfFilePath;
        }
    }
}
