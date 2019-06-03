using System;
using MySql.Data.MySqlClient;

namespace CrudUsuarios.Services {
    class BD {
        public string Server { get; private set; }
        public string Database { get; private set; }
        public string Usuario { get; private set; }
        public string Senha { get; private set; }

        public BD() {
            Server = "localhost";
            Database = "trabalho_b2";
            Usuario = "root";
            Senha = "";
        }

        public MySqlConnection Conectar() {
            string connString = "Server=" + Server + ";Database=" + Database + ";Uid=" + Usuario + ";Pwd=" + Senha;
            MySqlConnection connection = new MySqlConnection(connString);
            return connection;
        }

        public int Inserir(string query) {
            MySqlConnection conexao = new BD().Conectar();
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Connection = conexao;
            conexao.Open();
            int linhas = comando.ExecuteNonQuery();
            comando.Connection.Close();

            return linhas;
        }

        public int Remover(string query) {
            MySqlConnection conexao = new BD().Conectar();
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Connection = conexao;
            conexao.Open();
            int linhas = comando.ExecuteNonQuery();
            comando.Connection.Close();

            return linhas;
        }

        public int Atualizar(string query) {
            MySqlConnection conexao = new BD().Conectar();
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Connection = conexao;
            conexao.Open();
            int linhas = comando.ExecuteNonQuery();
            comando.Connection.Close();

            return linhas;
        }

        public void Listar(string table) {
            
            string query = "SELECT * FROM "+table;

            MySqlConnection conexao = new BD().Conectar();
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Connection = conexao;
            conexao.Open();
            var leitor = comando.ExecuteReader();

            while (leitor.Read()) {

                switch (table) {
                    case "cliente":
                        Console.WriteLine("Nome: " + leitor["nome"]);
                        Console.WriteLine("Endereco: " + leitor["endereco"]);
                        Console.WriteLine("Bairro: " + leitor["bairro"]);
                        Console.WriteLine("Cidade: " + leitor["cidade"]);
                        Console.WriteLine("Telefone: " + leitor["telefone"]);
                        Console.WriteLine("CPF: " + leitor["cpf"]);
                        Console.WriteLine();
                        break;
                    case "usuario":
                        Console.WriteLine("Nome: " + leitor["nome"]);
                        Console.WriteLine("Email: " + leitor["email"]);
                        Console.WriteLine("Setor: " + leitor["setor"]);
                        Console.WriteLine("RG: " + leitor["rg"]);
                        Console.WriteLine("CPF: " + leitor["cpf"]);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Tabela inexistente, impossível listar.");
                        break;
                }
            }
        }

        public MySqlDataReader Consultar(string query, string table) {
            MySqlConnection conexao = new BD().Conectar();
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Connection = conexao;
            conexao.Open();
            MySqlDataReader indice = comando.ExecuteReader();

            switch (table) {
                case "cliente":
                    while (indice.Read()) {
                        Console.WriteLine("Nome: " + indice.GetString(0));
                        Console.WriteLine("Endereco: " + indice.GetString(1));
                        Console.WriteLine("Bairro: " + indice.GetString(2));
                        Console.WriteLine("Cidade: " + indice.GetString(3));
                        Console.WriteLine("Telefone: " + indice.GetString(4));
                    }
                    break;
                case "usuario":
                    while (indice.Read()) {
                        Console.WriteLine("Nome: " + indice.GetString(0));
                        Console.WriteLine("Email: " + indice.GetString(1));
                        Console.WriteLine("Setor: " + indice.GetString(2));
                        Console.WriteLine("RG: " + indice.GetString(3));
                    }
                    break;
                default:
                    Console.WriteLine("Tabela inexistente, impossível buscar.");
                    break;
            }

            comando.Connection.Close();

            return indice;
        }
    }
}
