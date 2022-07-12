namespace FileOrganize
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.txtExtensao = new System.Windows.Forms.TextBox();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.pgrBar = new System.Windows.Forms.ProgressBar();
            this.txtTamanhoMin = new System.Windows.Forms.TextBox();
            this.btnLocDest = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.SelDir = new System.Windows.Forms.FolderBrowserDialog();
            this.lstArquivos = new System.Windows.Forms.TextBox();
            this.grpConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalizar.Location = new System.Drawing.Point(539, 15);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 0;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiretorio.Location = new System.Drawing.Point(6, 17);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(527, 20);
            this.txtDiretorio.TabIndex = 2;
            // 
            // txtExtensao
            // 
            this.txtExtensao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtensao.Location = new System.Drawing.Point(620, 17);
            this.txtExtensao.Name = "txtExtensao";
            this.txtExtensao.Size = new System.Drawing.Size(158, 20);
            this.txtExtensao.TabIndex = 3;
            this.txtExtensao.Text = "TIF;JPG;JPEG;BMP;TIFF;GIF";
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.pgrBar);
            this.grpConfig.Controls.Add(this.txtTamanhoMin);
            this.grpConfig.Controls.Add(this.btnLocDest);
            this.grpConfig.Controls.Add(this.txtDestino);
            this.grpConfig.Controls.Add(this.btnListar);
            this.grpConfig.Controls.Add(this.btnLocalizar);
            this.grpConfig.Controls.Add(this.txtExtensao);
            this.grpConfig.Controls.Add(this.txtDiretorio);
            this.grpConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpConfig.Location = new System.Drawing.Point(0, 0);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(837, 117);
            this.grpConfig.TabIndex = 4;
            this.grpConfig.TabStop = false;
            // 
            // pgrBar
            // 
            this.pgrBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgrBar.BackColor = System.Drawing.SystemColors.Control;
            this.pgrBar.Location = new System.Drawing.Point(6, 82);
            this.pgrBar.Maximum = 0;
            this.pgrBar.Name = "pgrBar";
            this.pgrBar.Size = new System.Drawing.Size(825, 28);
            this.pgrBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgrBar.TabIndex = 8;
            // 
            // txtTamanhoMin
            // 
            this.txtTamanhoMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTamanhoMin.Location = new System.Drawing.Point(784, 17);
            this.txtTamanhoMin.Name = "txtTamanhoMin";
            this.txtTamanhoMin.Size = new System.Drawing.Size(47, 20);
            this.txtTamanhoMin.TabIndex = 7;
            this.txtTamanhoMin.Text = "0";
            // 
            // btnLocDest
            // 
            this.btnLocDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocDest.Location = new System.Drawing.Point(539, 52);
            this.btnLocDest.Name = "btnLocDest";
            this.btnLocDest.Size = new System.Drawing.Size(75, 23);
            this.btnLocDest.TabIndex = 6;
            this.btnLocDest.Text = "Localizar";
            this.btnLocDest.UseVisualStyleBackColor = true;
            this.btnLocDest.Click += new System.EventHandler(this.btnLocDest_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestino.Location = new System.Drawing.Point(6, 54);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(527, 20);
            this.txtDestino.TabIndex = 5;
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(622, 52);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(156, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar...";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // SelDir
            // 
            this.SelDir.ShowNewFolderButton = false;
            // 
            // lstArquivos
            // 
            this.lstArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstArquivos.Location = new System.Drawing.Point(0, 117);
            this.lstArquivos.Multiline = true;
            this.lstArquivos.Name = "lstArquivos";
            this.lstArquivos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lstArquivos.Size = new System.Drawing.Size(837, 533);
            this.lstArquivos.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 650);
            this.Controls.Add(this.lstArquivos);
            this.Controls.Add(this.grpConfig);
            this.Name = "frmPrincipal";
            this.Text = "File Organizer - Tissu";
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.TextBox txtExtensao;
        private System.Windows.Forms.GroupBox grpConfig;
        private System.Windows.Forms.FolderBrowserDialog SelDir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnLocDest;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox lstArquivos;
        private System.Windows.Forms.TextBox txtTamanhoMin;
        private System.Windows.Forms.ProgressBar pgrBar;
    }
}

