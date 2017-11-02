using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MergePDFUI
{
    public partial class FormMain : Form
    {
        private const string PdfMergeFile = "MergePdf.exe";

        public FormMain()
        {
            InitializeComponent();
            CheckForPdfMergeExe();
        }

        private void CheckForPdfMergeExe()
        {
            if (!File.Exists(PdfMergeFile))
            {
                MessageBox.Show(string.Format("Unable to find {0}. Please make sure you copy this program to same folder as of {0}", PdfMergeFile), "Select files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uxMergePdfButton.Enabled = false;
            }
        }

        private void uxSelectFilesButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in openFileDialog.FileNames)
                {
                    uxFileslistBox.Items.Add(file);
                }
            }
        }

        private void uxMoveUpButton_Click(object sender, EventArgs e)
        {
            // only if the first item isn't the current one
            if (uxFileslistBox.SelectedIndex > 0)
            {
                // add a duplicate item up in the listbox
                uxFileslistBox.Items.Insert(uxFileslistBox.SelectedIndex - 1, uxFileslistBox.Text);
                // make it the current item
                uxFileslistBox.SelectedIndex = (uxFileslistBox.SelectedIndex - 2);
                // delete the old occurrence of this item
                uxFileslistBox.Items.RemoveAt(uxFileslistBox.SelectedIndex + 2);
            }
        }

        private void uxMoveDownButton_Click(object sender, EventArgs e)
        {
            // only if the last item isn't the current one
            if ((uxFileslistBox.SelectedIndex != -1) && (uxFileslistBox.SelectedIndex < uxFileslistBox.Items.Count - 1))
            {
                // add a duplicate item down in the listbox
                uxFileslistBox.Items.Insert(uxFileslistBox.SelectedIndex + 2, uxFileslistBox.Text);
                // make it the current item
                uxFileslistBox.SelectedIndex = uxFileslistBox.SelectedIndex + 2;
                // delete the old occurrence of this item
                uxFileslistBox.Items.RemoveAt(uxFileslistBox.SelectedIndex - 2);
            }
        }

        private void uxMergePdfButton_Click(object sender, EventArgs e)
        {
            uxResultTextBox.Text = string.Empty;

            if (string.IsNullOrEmpty(uxOutputFileTextBox.Text))
            {
                MessageBox.Show("Please select output file", "Select file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsFileLocked(uxOutputFileTextBox.Text))
            {
                MessageBox.Show(string.Format("Output file {0} is locked by another process. Please make sure file is not open.", uxOutputFileTextBox.Text), "File locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;                
            }

            if (uxFileslistBox.Items.Count < 2)
            {
                MessageBox.Show("Please select two or more files", "Select files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var files = new List<string>();
            foreach (var file in uxFileslistBox.Items)
            {
                files.Add(file.ToString());
            }

            var args = string.Format("output=\"{0}\" input=\"{1}\"", uxOutputFileTextBox.Text, string.Join("|", files.ToArray()));
            
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = PdfMergeFile;
                start.UseShellExecute = false;
                start.CreateNoWindow = true;
                start.RedirectStandardOutput = true;
                start.Arguments = args;

                using (Process exeProcess = Process.Start(start))
                {
                    exeProcess.WaitForExit();

                    using (StreamReader reader = exeProcess.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        uxResultTextBox.Text = result;
                    }
                }

                Process.Start(uxOutputFileTextBox.Text);
            }
            catch(Exception ex)
            {
                uxResultTextBox.Text = ex.Message;
            }            
        }

        private void uxOutputFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = false;

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    uxOutputFileTextBox.Text = openFileDialog.FileName;
                }
            }
            catch(Exception ex)
            {
                uxResultTextBox.Text = ex.Message;
            }
            finally
            {
                openFileDialog.Multiselect = true;
                openFileDialog.CheckFileExists = true;
            }
        }

        private void uxRemoveButton_Click(object sender, EventArgs e)
        {
            if (uxFileslistBox.SelectedIndex > -1)
            {
                uxFileslistBox.Items.RemoveAt(uxFileslistBox.SelectedIndex);
            }
        }

        private void uxRemoveAllButton_Click(object sender, EventArgs e)
        {
            uxFileslistBox.Items.Clear();
        }

        private bool IsFileLocked(string filePath)
        {
            try
            {
                using (File.Open(filePath, FileMode.Open)) { }
            }
            catch (IOException ex)
            {
                var errorCode = Marshal.GetHRForException(ex) & ((1 << 16) - 1);

                return errorCode == 32 || errorCode == 33;
            }

            return false;
        }

        private void uxProjectLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mergepdfui.codeplex.com/");
        }
    }
}
