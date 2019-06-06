using System;
using CrudUsuarios.Services;
using MySql.Data.MySqlClient;

namespace CrudUsuarios.Entities {
    class Usuario {

        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Setor { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; private set; }

        public Usuario() {
        }

        public Usuario(string nome, string email, string setor, string rg, string cpf) {
            Nome = nome;
            Email = email;
            Setor = setor;
            Rg = rg;
            Cpf = cpf;
        }
    }
}
