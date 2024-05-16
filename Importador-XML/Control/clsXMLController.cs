using Importador_XML.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importador_XML.Control
{
    public class clsXMLController
    {
        public static void LerXML(string arquivoXML, DataGridView dataGridView, string codigoCartorio, DateTime dataApresentacao, decimal porcentagemCustas)
        {
            modXML.PreencherDataGridViewComXML(dataGridView, arquivoXML, codigoCartorio, dataApresentacao, porcentagemCustas);
        }

        public static void ExportarXML(int protocolo, string nomeDevedor, string documentoDevedor, string nomeApresentante, string documentoApresentante, string nomeCredor,
            string documentoCredor, int numeroTitulo, decimal valorTitulo, DateTime dataEmissao, string especieTitulo, int codigoCartorio, DateTime dataApresentacao, double valorCustas)
        {
            modBancoDados.LimparParametros();

            modBancoDados.AdicionarParametro("@Protocolo", protocolo);
            modBancoDados.AdicionarParametro("@NomeDevedor", nomeDevedor);
            modBancoDados.AdicionarParametro("@DocumentoDevedor", documentoDevedor);
            modBancoDados.AdicionarParametro("@NomeApresentante", nomeApresentante);
            modBancoDados.AdicionarParametro("@DocumentoApresentante", documentoApresentante);
            modBancoDados.AdicionarParametro("@NomeCredor", nomeCredor);
            modBancoDados.AdicionarParametro("@DocumentoCredor", documentoCredor);
            modBancoDados.AdicionarParametro("@NumeroTitulo", numeroTitulo);
            modBancoDados.AdicionarParametro("@ValorTitulo", valorTitulo);
            modBancoDados.AdicionarParametro("@DataEmissao", dataEmissao);
            modBancoDados.AdicionarParametro("@EspecieTitulo", especieTitulo);
            modBancoDados.AdicionarParametro("@CodigoCartorio", codigoCartorio);
            modBancoDados.AdicionarParametro("@DataApresentacao", dataApresentacao);
            modBancoDados.AdicionarParametro("@ValorCustas", valorCustas);

            modBancoDados.Executar("InserirTitulos");
        }
    }
}
