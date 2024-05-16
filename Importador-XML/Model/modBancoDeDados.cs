using Microsoft.Data.SqlClient;
using System.Data;

namespace Importador_XML.Model
{
    /// <summary>
    /// <example>
    /// Exemplo:
    /// <code>
    /// clsBancoDados.Usuario = "jonh.doe";
    /// clsBancoDados.Senha = "123";
    /// clsBancoDados.Servidor = "000.999.99.99";
    /// clsBancoDados.Banco = "BancoDados_DB";
    /// clsBancoDados.Conectar(autenticarCasoFalhe); // Opcional
    /// 
    /// clsBancoDados.LimparParametros();
    /// clsBancoDados.AdicionarParametro(parametro, valor, input);
    /// dataSet = clsBancoDados.Executar(sql, tipo);
    /// dataTable = dataSet.Tables[0];
    /// </code>
    /// </example>
    /// </summary>
    public static class modBancoDados
    {
        public static SqlConnection Conexao = null;
        /// <summary>
        /// IP do servidor de banco de dados, podendo passar localhost.
        /// </summary>
        public static string Servidor = @"(localdb)\localDB1";

        /// <summary>
        /// Nome do banco de dados.
        /// </summary>
        public static string Banco = "master";

        /// <summary>
        /// Nome de usuário para acesso ao banco de dados, ex: sa.
        /// </summary>
        public static string Usuario = "";

        /// <summary>
        /// Senha de acesso ao banco de dados.
        /// </summary>
        public static string Senha = "";

        /// <summary>
        /// Parâmetro Persist Security Info da ConnectionString. Por padrão True.
        /// </summary>
        public static bool PersistirCredenciais = true;

        /// <summary>
        /// Retorna todos os valores dos parametros Output passados.
        /// </summary>
        public static Dictionary<string, object> Output = new Dictionary<string, object>();

        private static List<SqlParameter> Parametros = new List<SqlParameter>();

        /// <summary>
        /// Conecta com o banco de dados usando as credenciais especificadas anteriormente.
        /// </summary>
        /// <param name="autenticarCasoFalhe">Abre a janela de autenticação caso não consiga conectar. Por padrão false.</param>
        /// <exception cref="Exception">Falha ao conectar com banco de dados ou mensagem específica de erro.</exception>
        public static void Conectar()
        {
            if (Conexao == null)
            {
                Conexao = new SqlConnection();
            }

            try
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }

                Conexao.ConnectionString = string.Format("Initial Catalog={0};Data Source={1};Uid={2};Pwd={3};persist security info={4};TrustServerCertificate=true", Banco, Servidor, Usuario, Senha, PersistirCredenciais);

                CancellationTokenSource tentativaConexao = new CancellationTokenSource();

                CancellationToken tentativaConexaoToken = tentativaConexao.Token;

                tentativaConexao.CancelAfter(5000);

                Task tentativaConexaoTarefa = Conexao.OpenAsync(tentativaConexaoToken);

                tentativaConexaoTarefa.Wait();
            }
            catch (SqlException exc)
            {
                string excMensagem = "";

                switch (exc.Number)
                {
                    case 53:
                        excMensagem = "Falha ao conectar com banco de dados, verifique seu login.";
                        break;
                    case 18456:
                        excMensagem = "Falha ao conectar com banco de dados, verifique seu login.";
                        break;
                    default:
                        excMensagem = exc.Message;
                        break;
                }

                throw new Exception(excMensagem);
            }
            catch (TaskCanceledException)
            {
                throw new Exception("Falha ao conectar com banco de dados, verifique seu login.");
            }
            catch (ObjectDisposedException)
            {
                throw new Exception("Falha ao conectar com banco de dados, verifique seu login.");
            }
            catch (AggregateException)
            {
                throw new Exception("Falha ao conectar com banco de dados, verifique seu login.");
            }
            catch (InvalidOperationException)
            {
                throw new Exception("Servidor não especificado ou conexão já está aberta.");
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        /// <summary>
        /// Limpa a lista de parâmetros usados na execução da stored procedure ou function.
        /// </summary>
        /// <exception cref="Exception">Mensagem específica de erro.</exception>
        public static void LimparParametros()
        {
            try
            {
                Parametros.Clear();
                Output.Clear();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        /// <summary>
        /// Adiciona um parâmetro para executar a stored procedure ou function. Lembre-se de usar LimparParametros antes de começar a inserir os parâmetros.
        /// </summary>
        /// <param name="nome">Nome do parâmetro.</param>
        /// <param name="valor">Valor do parâmetro.</param>
        /// <param name="direcao">Tipo do parâmetro.</param>
        /// <exception cref="Exception">Mensagem específica de erro.</exception>
        public static void AdicionarParametro(string nome, object? valor = null, ParameterDirection direcao = ParameterDirection.Input)
        {
            try
            {
                SqlParameter parametro;

                parametro = new SqlParameter(nome, valor);

                parametro.Direction = direcao;

                Parametros.Add(parametro);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public static void AdicionarParametro(string nome, object valor, string uDT)
        {
            SqlParameter parameter = new SqlParameter(nome, valor);
            parameter.SqlDbType = SqlDbType.Structured;
            parameter.UdtTypeName = uDT;
            Parametros.Add(parameter);
        }

        /// <summary>
        /// Executa o comando SQL e retorna um DataSet contendo o retorno do banco de dados. Lembre-se de usar LimparParametros e AdicionarParametro, se for necessário, antes de executar.
        /// </summary>
        /// <param name="sql">Nome da Stored Procedure ou comando em SQL.</param>
        /// <param name="tipo">Tipo do comando, por padrão Stored Procedure.</param>
        /// <returns>Contém um DataSet com as tabelas acessadas pela propriedade Tables. A propriedade Tables vem vazia (Tables.Count == 0) caso não retorne nada.</returns>
        /// <exception cref="Exception">Banco de dados não conseguiu executar o SQL ou mensagem específica de erro.</exception>
        public static DataSet Executar(string sql, CommandType tipo = CommandType.StoredProcedure)
        {
            Conectar();

            if (Conexao.State != ConnectionState.Open)
            {
                throw new Exception("Conexão não foi aberta.");
            }

            // Comando
            SqlDataAdapter comando = new SqlDataAdapter();
            comando.SelectCommand = new SqlCommand(sql, Conexao);
            comando.SelectCommand.CommandType = tipo;
            comando.SelectCommand.CommandTimeout = 3600; // 3600 segundos = 1 hora

            // Parâmetros
            //int percorrerParametro = 0;
            //while (percorrerParametro < Parametros.Count)
            //{
            comando.SelectCommand.Parameters.AddRange(Parametros.ToArray());

            //    percorrerParametro += 1;
            //}

            // DataSet
            DataSet retorno = new DataSet();

            try
            {
                comando.Fill(retorno);
            }
            catch (SqlException exc)
            {
                throw new Exception(string.Format("{0} - {1}", exc.Message, exc.Procedure));
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("{0}", exc.Message));
            }

            // Output
            try
            {
                Output.Clear();

                int percorrerOutput = 0;
                while (percorrerOutput < Parametros.Count)
                {
                    if (Parametros[percorrerOutput].Direction == ParameterDirection.Output || Parametros[percorrerOutput].Direction == ParameterDirection.InputOutput)
                    {
                        Output.Add(Parametros[percorrerOutput].ParameterName, Parametros[percorrerOutput].Value);
                    }

                    percorrerOutput += 1;
                }
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }

            // Retorno Dataset
            return retorno;
        }
    }
}
