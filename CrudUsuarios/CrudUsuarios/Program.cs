using System;
using CrudUsuarios.Entities;
using CrudUsuarios.Services;
namespace CrudUsuarios {
    class Program {
        static void Main(string[] args) {
            Cliente cliente = new Cliente("Fhaidy Maciel", "meu endereco", "meu bairro", "minha cidade", "meu fone", "meu cpf2");
            Usuario usuario = new Usuario("Fhaidy", "email2", "setor2", "rg2", "cpf123");

            BD banco = new BD();
            /* linhas2 = cliente.RemoverCliente("meu cpf2");
            if (linhas2 >= 1) {
                Console.WriteLine("Removeu com sucesso");
            } else {
                Console.WriteLine("Deu ruim");
            }

            int linhas = cliente.InserirCliente(cliente);

            if (linhas >= 1) {
                Console.WriteLine("Inseriu com sucesso");
            } else {
                Console.WriteLine("Deu ruim");
            }*/

            //int linhas3 = cliente.AtualizarCliente(cliente);

            /*if (linhas3 >= 1) {
                Console.WriteLine("Atualizou com sucesso");
            } else {
                Console.WriteLine("Deu ruim");
            }*/

            //cliente.ConsultarCliente("meu cpf2");

            //usuario.ConsultarUsuario("cpf123");

        }
    }
}
