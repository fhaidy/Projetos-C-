using System;
using System.Data;
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


        public int Set(string query) {
            MySqlConnection conexao = new BD().Conectar();
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Connection = conexao;
            conexao.Open();
            int linhas = comando.ExecuteNonQuery();
            comando.Connection.Close();

            return linhas;
        }

        public DataTable Get(string query) {
            MySqlConnection conexao = new BD().Conectar();
            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            comando.Connection = conexao;
            conexao.Open();
            DataTable table = new DataTable();
            adapter.Fill(table);
            comando.Connection.Close();
            return table;
        }
    }
}
