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

        public int InserirUsuario(Usuario usuario) {
            string query = "insert into usuario (nome, email, setor, rg, cpf) " +
                            "Values(" +
                                "'" + usuario.Nome + "', " +
                                "'" + usuario.Email + "', " +
                                "'" + usuario.Setor + "', " +
                                "'" + usuario.Rg + "', " +
                                "'" + usuario.Cpf + "'" +
                            ")";
            BD banco = new BD();
            int linhas = banco.Inserir(query);
            return linhas;
        }

        public int RemoverUsuario(string cpf) {
            string query = "delete from usuario where cpf = '" + cpf + "'";
            BD banco = new BD();
            int linhas = banco.Remover(query);
            return linhas;
        }

        public int AtualizarUsuario(Usuario usuario) {
            string query = "update usuario " +
                            "set " +
                                "nome = '" + usuario.Nome + "', " +
                                "email = '" + usuario.Email + "', " +
                                "setor = '" + usuario.Setor + "', " +
                                "rg = '" + usuario.Rg + "'" +
                            "WHERE cpf = '" + usuario.Cpf + "';";
            BD banco = new BD();
            int linhas = banco.Atualizar(query);
            return linhas;
        }

        public void ConsultarUsuario(string cpf) {
            string query = "select nome, email, setor, rg " +
                            "from usuario " +
                            "where cpf = '" + cpf + "';";
            BD banco = new BD();
            banco.Consultar(query, "usuario");
            
        }
    }
}
