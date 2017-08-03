using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenombradorDeFicheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInputFolder_Click(object sender, EventArgs e)
        {
            var selectedInputFolder = string.Empty;

            flbInputFolder.ShowDialog();

            selectedInputFolder = flbInputFolder.SelectedPath;

            txtInputFolder.Text = selectedInputFolder;

            EnablebtnRenameFiles();
        } 

        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            var selectedOutputFolder = string.Empty;

            flbOutputFolder.ShowDialog();

            selectedOutputFolder = flbOutputFolder.SelectedPath;

            txtOutputFolder.Text = selectedOutputFolder;

            EnablebtnRenameFiles();
        }


        private void btnRenameFiles_Click(object sender, EventArgs e)
        {
            var response = false;
            if (!string.IsNullOrEmpty(txtStringsToChange.Text) && !string.IsNullOrEmpty(txtChangeFor.Text))
            {
                pgbFilesCompleted.Visible = true;
                response = RenameFiles(txtInputFolder.Text, txtOutputFolder.Text, txtStringsToChange.Text, txtChangeFor.Text);
                
            }
            else if (string.IsNullOrEmpty(txtStringsToChange.Text) && !string.IsNullOrEmpty(txtChangeFor.Text))
                MessageBox.Show("El campo de cadenas a cambiar no puede estar vacío");
            else if (string.IsNullOrEmpty(txtChangeFor.Text) && !string.IsNullOrEmpty(txtStringsToChange.Text))
                MessageBox.Show("El campo cambiar por no puede estar vacío");
            else
                MessageBox.Show("Ninguno de los dos campos: Cadenas a cambiar y Cambiar por; no pueden estar vacíos");

            if (response)
            {
                MessageBox.Show("Proceso finalizado correctamente");
                
            }
            else
            {
                MessageBox.Show("El proceso ha fallado");
            }

        }



        private void EnablebtnRenameFiles()
        {
            if (!string.IsNullOrEmpty(txtInputFolder.Text) && !string.IsNullOrEmpty(txtOutputFolder.Text))
            {
                btnRenameFiles.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInputFolder.Text = string.Empty;
            txtOutputFolder.Text = string.Empty;
            txtStringsToChange.Text = string.Empty;
            txtChangeFor.Text = string.Empty;
            rtxtLogData.Text = string.Empty;
            btnRenameFiles.Enabled = false;
            pgbFilesCompleted.Visible = false;
        }

        private bool RenameFiles(string inputPath, string outputPath, string stringsToChange, string changeFor)
        {
            DirectoryInfo directory = new DirectoryInfo(inputPath);

            FileInfo[] files = directory.GetFiles();

            var totalFiles = files.Count();
            var count = 0;
            
            try
            {
                foreach (var file in files)
                {
                    count++;
                    string name = string.Empty;

                    name = file.Name.Replace(stringsToChange, changeFor);

                    rtxtLogData.Text += string.Concat("Se realiza el cambio del fichero: ", file.Name, " por: ", name, "\n");

                    File.Copy(file.FullName, string.Concat(outputPath, @"/", name));
                    pgbFilesCompleted.Value = (count * 100) / totalFiles;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

    }
}
