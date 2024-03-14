using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace ProjetoConci
{
    public class clsConexao
    {
        private string stringConexao;
        private SqlConnection conexao;

        //Construtor
        public clsConexao()
        {
            // String que conecta com o banco de dados
            stringConexao = @"Data Source=DESKTOP-DU016LO\SQLEXPRESS;Initial Catalog=ConciligBanco;Integrated Security=True";
            conexao = new SqlConnection(stringConexao);
        }

        // Método para abrir a conexão
        public void AbrirConexao()
        {
            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao abrir conexão: " + ex.Message);
            }
        }

        // Método para fechar a conexão
        public void FecharConexao()
        {
            try
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada com sucesso!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao fechar conexão: " + ex.Message);
            }
        }

        // Método para verificar usuario/login
        public bool Login(string username, string password)
        {
            bool result = false;

            AbrirConexao();

            // comando Sql
            string consultaSql = $"SELECT * FROM USUARIO WHERE SENHA = '{password}' AND NOME = '{username}'";

            // objeto que recebe o comando e a conexao
            SqlCommand comando = new SqlCommand(consultaSql, conexao);

            try
            {
                
                // Classe (DataReader) recebe os dados, ExecuteReader aplica o comando no Sql
                SqlDataReader leitor = comando.ExecuteReader();

                // Verifica se há linhas retornadas pela consulta
                if (leitor.HasRows)
                {
                    result = true;
                }

                // Fecha o leitor de dados
                leitor.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao executar consulta: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
            return result;
        }

   
        // Método para cadastrar usuario
        public bool Cadastrar(string username, string password)
        {
            bool result = false;

            AbrirConexao();

            // comando Sql
            string consultaSql = $"INSERT INTO USUARIO (NOME, SENHA) VALUES ('{username}', '{password}');";

            // objeto que recebe o comando e a conexao
            SqlCommand comando = new SqlCommand(consultaSql, conexao);


            int linhasAfetadas = comando.ExecuteNonQuery();

            // Verificaçao
            if (linhasAfetadas > 0)
            {
                Console.WriteLine("Dados inseridos com sucesso.");
                result = true;
            }
            else
            {
                Console.WriteLine("Falha ao inserir dados.");
            }

            FecharConexao();
            return result;
        }

        // Método para pegar o ID do usuario ao logar
        public int PegarID(string username, string password)
        {
            AbrirConexao();

            // recebe o comando Sql
            string consultaSql = $"SELECT USUARIOID FROM USUARIO WHERE SENHA = '{password}' AND NOME = '{username}'";

            // objeto que recebe o comando e a conexao
            SqlCommand comando = new SqlCommand(consultaSql, conexao);

            try
            {
                // Classe (DataReader) recebe os dados, ExecuteReader aplica o comando no Sql
                SqlDataReader leitor = comando.ExecuteReader();

                // Verifica se há linhas retornadas pela consulta
                if (leitor.HasRows)
                {
                    // Percorrer as linhas retornadas
                    while (leitor.Read())
                    {
                        // Recupera os valores das colunas pelo nome ou índice
                        int id = leitor.GetInt32(0); // recebe o valor da primeira coluna

                        return id;
                    }
                }
                else
                {
                    Console.WriteLine("Não foram encontrados registros.");
                }

                // Fecha o leitor de dados
                leitor.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao executar consulta: " + ex.Message);
            }
            finally
            {
                FecharConexao(); // Fecha a conexão
            }
            return -1;
        }

        // Método para importar tabela
        public bool ImportarTabela(string caminho, string nomeDoUsuario)
        {

            string nomeArquivo = Path.GetFileName(caminho);

            bool result = false;

            AbrirConexao();

            // comando Sql
            string consultaSql = $"BULK INSERT IMPORT FROM '{caminho}' WITH (FIELDTERMINATOR = ';',FIRSTROW = 2,CODEPAGE = 'ACP');" 
                + $"INSERT INTO GERAL (NOME,CPF,CONTRATO,PRODUTO,VENCIMENTO,VALOR,NOME_ARQUIVO,USUARIO_IMP) SELECT NOME, CPF, CAST(CONTRATO AS INT), PRODUTO, CONVERT(DATE,VENCIMENTO,103), CAST(REPLACE(VALOR,',','.') AS MONEY), '{nomeArquivo}', '{nomeDoUsuario}'  FROM IMPORT;" 
                + $"DELETE IMPORT;";

            // objeto que recebe o comando e a conexao
            SqlCommand comando = new SqlCommand(consultaSql, conexao);


            int linhasAfetadas = comando.ExecuteNonQuery();

            // Verificaçao
            if (linhasAfetadas > 0)
            {
                Console.WriteLine("Dados inseridos com sucesso.");
                result = true;
            }
            else
            {
                Console.WriteLine("Falha ao inserir dados.");
            }

            FecharConexao();
            return result;
        }

        public DataTable BuscaDados(string sql)
        {
            var dataTable = new DataTable();

            AbrirConexao();


            // recebe o comando Sql
            string consultaSql = sql;

            // objeto que recebe o comando e a conexao
            SqlCommand comando = new SqlCommand(consultaSql, conexao);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(dataTable);


            FecharConexao(); // Fecha a conexão

            return dataTable;
            
        }

        // Método para pegar a soma dos contratos do cliente
        public decimal PegarSoma(string nome, string cpf)
        {
            AbrirConexao();

            // recebe o comando Sql
            string consultaSql = $"SELECT SUM(VALOR) FROM GERAL WHERE NOME = '{nome}' AND CPF = '{cpf}';";

            // objeto que recebe o comando e a conexao
            SqlCommand comando = new SqlCommand(consultaSql, conexao);

            try
            {
                // Classe (DataReader) recebe os dados, ExecuteReader aplica o comando no Sql
                SqlDataReader leitor = comando.ExecuteReader();

                // Verifica se há linhas retornadas pela consulta
                if (leitor.HasRows)
                {
                    // Percorre sobre as linhas retornadas
                    while (leitor.Read())
                    {
                        // Recupera os valores das colunas pelo nome ou índice
                        decimal soma = leitor.GetDecimal(0);

                        return soma;
                    }
                }
                else
                {
                    Console.WriteLine("Não foram encontrados registros.");
                }

                // Fecha o leitor de dados
                leitor.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao executar consulta: " + ex.Message);
            }
            finally
            {
                FecharConexao(); // Fecha a conexão
            }
            return -1;
        }


        // Método para pegar a diferença entre os dias dos contratos do cliente
        public int PegarDifDias(string nome, string cpf)
        {
            AbrirConexao();

            // recebe o comando Sql
            string consultaSql = $"SELECT MAX(DATEDIFF(day, VENCIMENTO, GETDATE())) FROM GERAL WHERE NOME = '{nome}' AND CPF = '{cpf}';";

            // objeto que recebe o comando e a conexao
            SqlCommand comando = new SqlCommand(consultaSql, conexao);

            try
            {
                // Classe (DataReader) recebe os dados, ExecuteReader aplica o comando no Sql
                SqlDataReader leitor = comando.ExecuteReader();

                // Verifica se há linhas retornadas pela consulta
                if (leitor.HasRows)
                {
                    // Percorre sobre as linhas retornadas
                    while (leitor.Read())
                    {
                        // Recupera os valores das colunas pelo nome ou índice
                        int diasDif = leitor.GetInt32(0);
                        return diasDif;
                    }
                }
                else
                {
                    Console.WriteLine("Não foram encontrados registros.");
                }

                // Fecha o leitor de dados
                leitor.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao executar consulta: " + ex.Message);
            }
            finally
            {
                FecharConexao(); // Fecha a conexão
            }
            return -1;
        }

        // Método para verificar se o usuario ja existe
        public bool ChecarCadastro(string username)
        {
            bool result = false;

            AbrirConexao();

            // comando Sql
            string consultaSql = $"SELECT * FROM USUARIO WHERE NOME = '{username}'";

            // objeto que recebe o comando e a conexao
            SqlCommand comando = new SqlCommand(consultaSql, conexao);

            try
            {

                // Classe (DataReader) recebe os dados, ExecuteReader aplica o comando no Sql
                SqlDataReader leitor = comando.ExecuteReader();

                // Verifica se há linhas retornadas pela consulta
                if (leitor.HasRows)
                {
                    result = true;
                }

                // Fecha o leitor de dados
                leitor.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao executar consulta: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
            return result;
        }

    }
}
