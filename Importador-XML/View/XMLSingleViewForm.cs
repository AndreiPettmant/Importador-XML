using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importador_XML.View
{
    public partial class XMLSingleViewForm : Form
    {
        public XMLSingleViewForm(string[] cellValues)
        {
            InitializeComponent();

            this.txtProtocolo.Text = cellValues[0];
            this.txtNomeDevedor.Text = cellValues[1];
            this.txtDocumentoDevedor.Text = cellValues[2];
            this.txtNomeApresentante.Text = cellValues[3];
            this.txtDocumentoApresentante.Text = cellValues[4];
            this.txtNomeCredor.Text = cellValues[5];
            this.txtDocumentoCredor.Text = cellValues[6];
            this.txtNumeroTitulo.Text = cellValues[7];
            this.txtValorTitulo.Text = cellValues[8];
            this.txtDataEmissao.Text = cellValues[9];
            this.txtEspecieTitulo.Text = cellValues[10];
            this.txtCodigoCartorio.Text = cellValues[11];
            this.txtDataApresentacao.Text = cellValues[12];
            this.txtValorCustas.Text = cellValues[13];
        }

        private void XMLSingleViewForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
