using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Importador_XML.Model
{
    public class modXML
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Titulos
        {

            private TitulosTitulo[] tituloField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Titulo")]
            public TitulosTitulo[] Titulo
            {
                get
                {
                    return this.tituloField;
                }
                set
                {
                    this.tituloField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TitulosTitulo
        {

            private ushort protocoloField;

            private string nomeDevedorField;

            private string documentoDevedorField;

            private string nomeApresentanteField;

            private string documentoApresentanteField;

            private string nomeCredorField;

            private string documentoCredorField;

            private uint numeroTituloField;

            private decimal valorTituloField;

            private System.DateTime dataEmissaoField;

            private string especieTituloField;

            private string codigoCartorioField;

            private System.DateTime dataApresentacaoField;

            private decimal valorCustasField;

            /// <remarks/>
            public ushort Protocolo
            {
                get
                {
                    return this.protocoloField;
                }
                set
                {
                    this.protocoloField = value;
                }
            }

            /// <remarks/>
            public string NomeDevedor
            {
                get
                {
                    return this.nomeDevedorField;
                }
                set
                {
                    this.nomeDevedorField = value;
                }
            }

            /// <remarks/>
            public string DocumentoDevedor
            {
                get
                {
                    return this.documentoDevedorField;
                }
                set
                {
                    this.documentoDevedorField = value;
                }
            }

            /// <remarks/>
            public string NomeApresentante
            {
                get
                {
                    return this.nomeApresentanteField;
                }
                set
                {
                    this.nomeApresentanteField = value;
                }
            }

            /// <remarks/>
            public string DocumentoApresentante
            {
                get
                {
                    return this.documentoApresentanteField;
                }
                set
                {
                    this.documentoApresentanteField = value;
                }
            }

            /// <remarks/>
            public string NomeCredor
            {
                get
                {
                    return this.nomeCredorField;
                }
                set
                {
                    this.nomeCredorField = value;
                }
            }

            /// <remarks/>
            public string DocumentoCredor
            {
                get
                {
                    return this.documentoCredorField;
                }
                set
                {
                    this.documentoCredorField = value;
                }
            }

            /// <remarks/>
            public uint NumeroTitulo
            {
                get
                {
                    return this.numeroTituloField;
                }
                set
                {
                    this.numeroTituloField = value;
                }
            }

            /// <remarks/>
            public decimal ValorTitulo
            {
                get
                {
                    return this.valorTituloField;
                }
                set
                {
                    this.valorTituloField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataEmissao
            {
                get
                {
                    return this.dataEmissaoField;
                }
                set
                {
                    this.dataEmissaoField = value;
                }
            }

            /// <remarks/>
            public string EspecieTitulo
            {
                get
                {
                    return this.especieTituloField;
                }
                set
                {
                    this.especieTituloField = value;
                }
            }

            /// <remarks/>
            public string CodigoCartorio
            {
                get
                {
                    return this.codigoCartorioField;
                }
                set
                {
                    this.codigoCartorioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataApresentacao
            {
                get
                {
                    return this.dataApresentacaoField;
                }
                set
                {
                    this.dataApresentacaoField = value;
                }
            }


            /// <remarks/>
            public decimal ValorCustas
            {
                get
                {
                    return this.valorCustasField;
                }
                set
                {
                    this.valorCustasField = value;
                }
            }

        }

        public static void PreencherDataGridViewComXML(DataGridView dataGridView, string caminhoArquivo, string codigoCartório, DateTime dataApresentacao, decimal valorCustas)
        {
            try
            {
                // Limpa o DataGridView antes de preencher com os novos dados
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                // Cria um XmlSerializer para deserializar o arquivo XML
                XmlSerializer serializer = new XmlSerializer(typeof(Titulos));

                // Abre o arquivo XML para leitura
                using (FileStream fs = new FileStream(caminhoArquivo, FileMode.Open))
                {
                    // Deserializa o XML e converte para o tipo Titulos
                    Titulos titulos = (Titulos)serializer.Deserialize(fs);

                    // Adiciona as colunas ao DataGridView
                    dataGridView.ColumnCount = typeof(TitulosTitulo).GetProperties().Length;
                    int colIndex = 0;
                    foreach (var prop in typeof(TitulosTitulo).GetProperties())
                    {
                        dataGridView.Columns[colIndex].Name = prop.Name;
                        colIndex++;
                    }

                    // Adiciona as linhas ao DataGridView
                    foreach (var titulo in titulos.Titulo)
                    {
                        dataGridView.Rows.Add(
                            titulo.Protocolo,
                            titulo.NomeDevedor,
                            titulo.DocumentoDevedor,
                            titulo.NomeApresentante,
                            titulo.DocumentoApresentante,
                            titulo.NomeCredor,
                            titulo.DocumentoCredor,
                            titulo.NumeroTitulo,
                            titulo.ValorTitulo,
                            titulo.DataEmissao,
                            titulo.EspecieTitulo,
                            titulo.CodigoCartorio = codigoCartório,
                            titulo.DataApresentacao = dataApresentacao,
                            titulo.ValorCustas = titulo.ValorTitulo * (valorCustas / 100)
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao ler o arquivo XML: " + ex.Message);
            }
        }
    }
}

