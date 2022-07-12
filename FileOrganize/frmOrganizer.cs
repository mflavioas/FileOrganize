using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Microsoft.WindowsAPICodePack.Shell;

namespace FileOrganize
{
    public partial class frmPrincipal : Form
    {
        private List<Arq> Arquivos = new List<Arq>();
        private string sExtensoes = string.Empty;
        private long lQtdTotalArq = 0;
        private long lQtdTotalArqSalvos = 0;

        #region Metodos

        private void LocalizarArquivos(string sDir, string sMask)
        {
            try
            {
                if (pgrBar.Value == 0)
                {
                    pgrBar.Maximum = 100;
                    pgrBar.Update();
                }
                foreach (string d in System.IO.Directory.GetDirectories(sDir))
                {
                    foreach (string f in System.IO.Directory.GetFiles(d))
                    {
                        pgrBar.Update();
                        System.IO.FileInfo fi = new System.IO.FileInfo(f);
                        if (!sExtensoes.ToUpper().Contains(fi.Extension.Replace(".", "").ToUpper()))
                            sExtensoes += string.Concat("_", fi.Extension);
                        lQtdTotalArq += 1;
                        if (((sMask.ToUpper().Contains(fi.Extension.Replace(".", "").ToUpper())) || (sMask == "*.*")) &&
                            (!"Cópia".Contains(fi.Name)) &&
                            ((fi.Length / 1024.0) > Convert.ToInt64(txtTamanhoMin.Text)))
                        {
                            try
                            {
                                DateTime data = fi.LastWriteTime;
                                if ("TIF;JPG;JPEG;BMP;TIFF;GIF".Contains(fi.Extension.Replace(".", "").ToUpper()))
                                {
                                    using (ShellObject picture = ShellObject.FromParsingName(f))
                                    {
                                        if (picture != null)
                                        {
                                            try
                                            {
                                                data = Convert.ToDateTime(picture.Properties.GetProperty(SystemProperties.System.Photo.DateTaken).ValueAsObject.ToString());
                                            }
                                            catch
                                            {
                                                data = fi.LastWriteTime;
                                            }
                                        }
                                    }
                                }
                                Arq arq = new Arq(fi.Name, f, fi.Length, data);
                                Arquivos.Add(arq);
                            }
                            catch
                            {
                                lstArquivos.Text += "Problemas no arquivo: " + f;
                            }
                        }
                    }
                    LocalizarArquivos(d, sMask);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PreencherListaDuplicados()
        {
            var arqvs = Arquivos.OrderBy(a => a.Nome).ToList();
            lstArquivos.Text = string.Empty;
            string Nome = string.Empty;
            string NomeA = string.Empty;
            long Tamanho = 0;
            pgrBar.Maximum = arqvs.Count;
            pgrBar.Style = ProgressBarStyle.Continuous;
            int cont = 0;
            foreach (Arq item in arqvs)
            {
                cont += 1;
                pgrBar.Value = cont;
                if (Nome == item.Nome && Tamanho == item.Tamanho)
                {
                    lstArquivos.Text += string.Concat(NomeA, " -> ", item.NomeCompleto, " - Tamanho: ",
                        item.Tamanho.ToString(), " - Data: ", item.Modificado.ToString("dd-MM-yyyy"), Environment.NewLine);
                    lstArquivos.Update();
                }
                else
                {
                    CriarNovoAmbiente(txtDestino.Text, item);
                }
                Nome = item.Nome;
                NomeA = item.NomeCompleto;
                Tamanho = item.Tamanho;
            }
        }

        private void CriarNovoAmbiente(string sDir, Arq pArquivo)
        {
            string sPath = string.Concat(sDir, "\\", pArquivo.Modificado.ToString("yyyy"));
            if (!System.IO.Directory.Exists(sPath))
                System.IO.Directory.CreateDirectory(sPath);
            sPath += string.Concat("\\", pArquivo.Modificado.ToString("MMMM"));
            if (!System.IO.Directory.Exists(sPath))
                System.IO.Directory.CreateDirectory(sPath);
            sPath += string.Concat("\\", pArquivo.Nome);
            if (System.IO.File.Exists(sPath))
            {
                lstArquivos.Text += string.Concat("Arquivo: ", pArquivo.NomeCompleto, ", já existe na pasta(", sPath, ").", Environment.NewLine);
                lstArquivos.Update();
            }
            else
            {
                lQtdTotalArqSalvos += 1;
                System.IO.File.Copy(pArquivo.NomeCompleto, sPath);
            }
        }
        #endregion

        #region Eventos

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            SelDir.ShowNewFolderButton = false;
            if (SelDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDiretorio.Text = SelDir.SelectedPath;
            }
        }

        private void btnLocDest_Click(object sender, EventArgs e)
        {
            SelDir.ShowNewFolderButton = true;
            if (SelDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDestino.Text = SelDir.SelectedPath;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DateTime dInicio = DateTime.Now;
            Arquivos.Clear();
            LocalizarArquivos(txtDiretorio.Text, txtExtensao.Text);
            PreencherListaDuplicados();
            lstArquivos.Text += string.Concat("Exteções existentes: ", sExtensoes, Environment.NewLine);
            lstArquivos.Text += string.Concat("Quantidade de arquivos origem\\destino ", lQtdTotalArq.ToString(), "\\", lQtdTotalArqSalvos.ToString(), Environment.NewLine);
            lstArquivos.Update();
            MessageBox.Show($"Processo concluido. Inicio: {dInicio:hh:mm:ss} - Fim: {DateTime.Now:hh:mm:ss}");
            pgrBar.Value = 0;
        }

        #endregion
    }

    internal class Arq
    {
        public string Nome { get; set; }
        public string NomeCompleto { get; set; }
        public long Tamanho { get; set; }
        public DateTime Modificado { get; set; }

        public Arq() { }

        public Arq(string pNome, string pNomeCompleto, long pTamanho, DateTime pModificado)
        {
            Nome = pNome;
            NomeCompleto = pNomeCompleto;
            Tamanho = pTamanho;
            Modificado = pModificado;
        }
    }
}
