using Importador_XML.Control;
using Importador_XML.Model;
using System.Xml;

namespace Importador_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Selecione um arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string arquivoSelecionado = openFileDialog.FileName;
                txtNomeArquivo.Text = arquivoSelecionado;

                clsXMLController.LerXML(arquivoSelecionado, dataGridView1, txtCodigoCartorio.Text, dtSelecionarData.Value, numPorcentagemCustas.Value);
            }
        }

        private void btnImportarXml_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells.Count > 0)
                {
                    int protocolo = Convert.ToInt32(row.Cells["Protocolo"].Value);
                    string nomeDevedor = row.Cells["NomeDevedor"].Value.ToString();
                    string documentoDevedor = row.Cells["DocumentoDevedor"].Value.ToString();
                    string nomeApresentante = row.Cells["NomeApresentante"].Value.ToString();
                    string documentoApresentante = row.Cells["DocumentoApresentante"].Value.ToString();
                    string nomeCredor = row.Cells["NomeCredor"].Value.ToString();
                    string documentoCredor = row.Cells["DocumentoCredor"].Value.ToString();
                    int numeroTitulo = Convert.ToInt32(row.Cells["NumeroTitulo"].Value);
                    decimal valorTitulo = Convert.ToDecimal(row.Cells["ValorTitulo"].Value);
                    DateTime dataEmissao = Convert.ToDateTime(row.Cells["DataEmissao"].Value);
                    string especieTitulo = row.Cells["EspecieTitulo"].Value.ToString();
                    int codigoCartorio = Convert.ToInt32(row.Cells["CodigoCartorio"].Value);
                    DateTime dataApresentacao = Convert.ToDateTime(row.Cells["DataApresentacao"].Value);
                    double valorCustas = Convert.ToDouble(row.Cells["ValorCustas"].Value);

                    clsXMLController.ExportarXML(protocolo, nomeDevedor, documentoDevedor, nomeApresentante,
                                                  documentoApresentante, nomeCredor, documentoCredor, numeroTitulo,
                                                  valorTitulo, dataEmissao, especieTitulo, codigoCartorio,
                                                  dataApresentacao, valorCustas);
                }
            }

            MessageBox.Show("XML ixportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnImportarXML.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numPorcentagemCustas_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                string arquivoSelecionado = txtNomeArquivo.Text;

                // Verifica se o arquivo selecionado é válido
                if (!string.IsNullOrEmpty(arquivoSelecionado))
                {
                    clsXMLController.LerXML(arquivoSelecionado, dataGridView1, txtCodigoCartorio.Text, dtSelecionarData.Value, numPorcentagemCustas.Value);
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnImportarXML.Enabled = true;
        }

        private void txtCodigoCartorio_TextChanged(object sender, EventArgs e)
        {
            string arquivoSelecionado = txtNomeArquivo.Text;

            // Verifica se o arquivo selecionado é válido
            if (!string.IsNullOrEmpty(arquivoSelecionado))
            {
                clsXMLController.LerXML(arquivoSelecionado, dataGridView1, txtCodigoCartorio.Text, dtSelecionarData.Value, numPorcentagemCustas.Value);
            }
        }
    }
}
