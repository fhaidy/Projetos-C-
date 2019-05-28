using System;
using CrudUsuarios.Services;
using MySql.Data.MySqlClient;

namespace CrudUsuarios.Entities {
    class Cliente {
        public int Id { get; private set; }
        public string Nome{ get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; private set; }

        public Cliente() {
        }

        public Cliente(string nome, string endereco, string bairro, string cidade, string telefone, string cpf) {
            Nome = nome;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            Telefone = telefone;
            Cpf = cpf;
        }

       public int InserirCliente(Cliente cliente) {
            string query = "insert into cliente (nome, endereco, bairro, cidade, telefone, cpf) " +
                            "Values(" +
                                "'" + cliente.Nome + "', " +
                                "'" + cliente.Endereco + "', " +
                                "'" + cliente.Bairro + "', " +
                                "'" + cliente.Cidade + "', " +
                                "'" + cliente.Telefone + "', " +
                                "'" + cliente.Cpf + "'" +
                            ")";
            Console.WriteLine(query);
            BD banco = new BD();
            int linhas = banco.Inserir(query);
            return linhas;
        }

        public int RemoverCliente(string cpf) {
            string query = "delete from cliente where cpf = '" + cpf + "'";
            Console.WriteLine(query);
            BD banco = new BD();
            int linhas = banco.Remover(query);
            return linhas;
        }

        public int AtualizarCliente(Cliente cliente) {
            string query = "update cliente " +
                            "set " +
                                "nome = '"+ cliente.Nome + "', " +
                                "endereco = '" + cliente.Endereco + "', " +
                                "bairro = '"+ cliente.Bairro + "', " +
                                "cidade = '" + cliente.Cidade + "'," +
                                "telefone = '" + cliente.Telefone + "' " +
                            "WHERE cpf = '"+ cliente.Cpf + "';";
            Console.WriteLine(query);
            BD banco = new BD();
            int linhas = banco.Atualizar(query);
            return linhas;
        }

        public void ConsultarCliente (string cpf) {
            string query = "select nome, endereco, bairro, cidade, telefone " +
                            "from cliente " +
                            "where cpf = '" + cpf + "';";
            Console.WriteLine(query);
            BD banco = new BD();
            banco.Consultar(query, "cliente");
        }




    }
}
