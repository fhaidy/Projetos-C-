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

        

        public void ListarClientes(string table) { 
            BD banco = new BD();
            banco.Listar("cliente");
        }




    }
}
