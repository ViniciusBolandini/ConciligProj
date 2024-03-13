﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

        // Método para fazer Querys
        public void ExecuteQuery(string sql)
        {
            AbrirConexao();

            // recebe o comando Sql
            string consultaSql = sql;

            // objeto que recebe o comando e a conexao
            SqlCommand comando = new SqlCommand(consultaSql, conexao);

            try
            {
                // Classe (DataReader) recebe os dados, ExecuteReader aplica o comando no Sql
                SqlDataReader leitor = comando.ExecuteReader();

                // Verifica se há linhas retornadas pela consulta
                if (leitor.HasRows)
                {
                    // Itera sobre as linhas retornadas
                    while (leitor.Read())
                    {
                        // Recupera os valores das colunas pelo nome ou índice
                        int id = leitor.GetInt32(0); // Exemplo: obtendo o valor da primeira coluna como inteiro
                        string nome = leitor.GetString(1); // Exemplo: obtendo o valor da segunda coluna como string

                        // Faça o que desejar com os dados recuperados, como exibir na tela
                        Console.WriteLine($"ID: {id}, Nome: {nome}");
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
                    // Itera sobre as linhas retornadas
                    while (leitor.Read())
                    {
                        // Recupera os valores das colunas pelo nome ou índice
                        int id = leitor.GetInt32(0); // Exemplo: obtendo o valor da primeira coluna como inteiro
                        

                        // Faça o que desejar com os dados recuperados, como exibir na tela
                        Console.WriteLine($"ID: {id}");
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

    }
}