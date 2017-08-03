namespace RenombradorDeFicheros
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtInputFolder = new System.Windows.Forms.TextBox();
            this.btnInputFolder = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.rtxtLogData = new System.Windows.Forms.RichTextBox();
            this.btnRenameFiles = new System.Windows.Forms.Button();
            this.txtStringsToChange = new System.Windows.Forms.TextBox();
            this.lblStringsToChange = new System.Windows.Forms.Label();
            this.lblChangeFor = new System.Windows.Forms.Label();
            this.txtChangeFor = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblInputFolder = new System.Windows.Forms.Label();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.flbInputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.flbOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnReset = new System.Windows.Forms.Button();
            this.pgbFilesCompleted = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInputFolder
            // 
            this.txtInputFolder.Location = new System.Drawing.Point(12, 37);
            this.txtInputFolder.Name = "txtInputFolder";
            this.txtInputFolder.Size = new System.Drawing.Size(497, 20);
            this.txtInputFolder.TabIndex = 0;
            // 
            // btnInputFolder
            // 
            this.btnInputFolder.Location = new System.Drawing.Point(535, 35);
            this.btnInputFolder.Name = "btnInputFolder";
            this.btnInputFolder.Size = new System.Drawing.Size(135, 23);
            this.btnInputFolder.TabIndex = 1;
            this.btnInputFolder.Text = "Buscar Carpeta Entrada";
            this.btnInputFolder.UseVisualStyleBackColor = true;
            this.btnInputFolder.Click += new System.EventHandler(this.btnInputFolder_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(12, 88);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(497, 20);
            this.txtOutputFolder.TabIndex = 2;
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Location = new System.Drawing.Point(535, 86);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(135, 23);
            this.btnOutputFolder.TabIndex = 3;
            this.btnOutputFolder.Text = "Buscar Carpeta Salida";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // rtxtLogData
            // 
            this.rtxtLogData.Location = new System.Drawing.Point(12, 292);
            this.rtxtLogData.Name = "rtxtLogData";
            this.rtxtLogData.Size = new System.Drawing.Size(664, 331);
            this.rtxtLogData.TabIndex = 4;
            this.rtxtLogData.Text = "";
            // 
            // btnRenameFiles
            // 
            this.btnRenameFiles.Enabled = false;
            this.btnRenameFiles.Location = new System.Drawing.Point(12, 203);
            this.btnRenameFiles.Name = "btnRenameFiles";
            this.btnRenameFiles.Size = new System.Drawing.Size(135, 23);
            this.btnRenameFiles.TabIndex = 5;
            this.btnRenameFiles.Text = "Renombrar Ficheros";
            this.btnRenameFiles.UseVisualStyleBackColor = true;
            this.btnRenameFiles.Click += new System.EventHandler(this.btnRenameFiles_Click);
            // 
            // txtStringsToChange
            // 
            this.txtStringsToChange.Location = new System.Drawing.Point(117, 145);
            this.txtStringsToChange.Name = "txtStringsToChange";
            this.txtStringsToChange.Size = new System.Drawing.Size(553, 20);
            this.txtStringsToChange.TabIndex = 6;
            // 
            // lblStringsToChange
            // 
            this.lblStringsToChange.AutoSize = true;
            this.lblStringsToChange.Location = new System.Drawing.Point(12, 148);
            this.lblStringsToChange.Name = "lblStringsToChange";
            this.lblStringsToChange.Size = new System.Drawing.Size(101, 13);
            this.lblStringsToChange.TabIndex = 7;
            this.lblStringsToChange.Text = "Cadenas a cambiar:";
            // 
            // lblChangeFor
            // 
            this.lblChangeFor.AutoSize = true;
            this.lblChangeFor.Location = new System.Drawing.Point(13, 174);
            this.lblChangeFor.Name = "lblChangeFor";
            this.lblChangeFor.Size = new System.Drawing.Size(66, 13);
            this.lblChangeFor.TabIndex = 8;
            this.lblChangeFor.Text = "Cambiar por:";
            // 
            // txtChangeFor
            // 
            this.txtChangeFor.Location = new System.Drawing.Point(117, 171);
            this.txtChangeFor.Name = "txtChangeFor";
            this.txtChangeFor.Size = new System.Drawing.Size(553, 20);
            this.txtChangeFor.TabIndex = 9;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 276);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(28, 13);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = "Log:";
            // 
            // lblInputFolder
            // 
            this.lblInputFolder.AutoSize = true;
            this.lblInputFolder.Location = new System.Drawing.Point(12, 21);
            this.lblInputFolder.Name = "lblInputFolder";
            this.lblInputFolder.Size = new System.Drawing.Size(98, 13);
            this.lblInputFolder.TabIndex = 11;
            this.lblInputFolder.Text = "Carpeta de entrada";
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Location = new System.Drawing.Point(12, 72);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(89, 13);
            this.lblOutputFolder.TabIndex = 12;
            this.lblOutputFolder.Text = "Carpeta de salida";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(535, 203);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset Datos";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pgbFilesCompleted
            // 
            this.pgbFilesCompleted.Location = new System.Drawing.Point(12, 243);
            this.pgbFilesCompleted.Name = "pgbFilesCompleted";
            this.pgbFilesCompleted.Size = new System.Drawing.Size(658, 17);
            this.pgbFilesCompleted.Step = 1;
            this.pgbFilesCompleted.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbFilesCompleted.TabIndex = 14;
            this.pgbFilesCompleted.Tag = "";
            this.pgbFilesCompleted.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 635);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblOutputFolder);
            this.Controls.Add(this.lblInputFolder);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtChangeFor);
            this.Controls.Add(this.lblChangeFor);
            this.Controls.Add(this.lblStringsToChange);
            this.Controls.Add(this.txtStringsToChange);
            this.Controls.Add(this.btnRenameFiles);
            this.Controls.Add(this.rtxtLogData);
            this.Controls.Add(this.btnOutputFolder);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.btnInputFolder);
            this.Controls.Add(this.txtInputFolder);
            this.Controls.Add(this.pgbFilesCompleted);
            this.Name = "Form1";
            this.Text = "Renombrador Ficheros";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputFolder;
        private System.Windows.Forms.Button btnInputFolder;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.RichTextBox rtxtLogData;
        private System.Windows.Forms.Button btnRenameFiles;
        private System.Windows.Forms.TextBox txtStringsToChange;
        private System.Windows.Forms.Label lblStringsToChange;
        private System.Windows.Forms.Label lblChangeFor;
        private System.Windows.Forms.TextBox txtChangeFor;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblInputFolder;
        private System.Windows.Forms.Label lblOutputFolder;
        private System.Windows.Forms.FolderBrowserDialog flbInputFolder;
        private System.Windows.Forms.FolderBrowserDialog flbOutputFolder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ProgressBar pgbFilesCompleted;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

