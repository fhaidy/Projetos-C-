using System;
using System.Data;
using CrudUsuarios.Entities;
using CrudUsuarios.Services;
namespace CrudUsuarios {
    class Program {
        static void Main(string[] args) {

            BD banco = new BD();

            int? controlePrincipal = null;
            int? controleSecundario = null;

            while (controlePrincipal != 0) {
                Console.Clear();
                Console.WriteLine("*********** Menu Inicial ***********");
                Console.WriteLine();
                Console.WriteLine("1 - Acessar Ambiente de Usuários");
                Console.WriteLine("2 - Acessar Ambiente de Clientes");
                Console.WriteLine("0 - Sair do Sistema");
                Console.Write("Escolha uma opção: ");
                controlePrincipal = int.Parse(Console.ReadLine());
                controleSecundario = null;
                switch (controlePrincipal) {
                    
                    case 1:
                        while (controleSecundario != 0 && controleSecundario != 9) {

                            Console.Clear();
                            Console.WriteLine("*********** Menu de Usuários ***********");
                            Console.WriteLine();
                            Console.WriteLine("1 - Inserir Usuário");
                            Console.WriteLine("2 - Atualizar Usuário");
                            Console.WriteLine("3 - Remover Usuário");
                            Console.WriteLine("4 - Buscar Usuário");
                            Console.WriteLine("5 - Listar Usuários");
                            Console.WriteLine("9 - Voltar para o Menu Inicial");
                            Console.WriteLine("0 - Sair do Sistema");
                            Console.Write("Escolha uma opção: ");

                            controleSecundario = int.Parse(Console.ReadLine());
                            int retorno = 0;
                            switch (controleSecundario) {
                                case 1:
                                    while (retorno == 0) {
                                        Console.Clear();
                                        Console.WriteLine("*********** Menu de Inserção de Usuários ***********");
                                        Console.WriteLine();

                                        Console.Write("Nome: ");
                                        string nome = Console.ReadLine();

                                        Console.Write("E-mail: ");
                                        string email = Console.ReadLine();

                                        Console.Write("Setor: ");
                                        string setor = Console.ReadLine();

                                        Console.Write("RG: ");
                                        string rg = Console.ReadLine();

                                        Console.Write("CPF: ");
                                        string cpf = Console.ReadLine();

                                        Usuario usuario = new Usuario(nome, email, setor, rg, cpf);

                                        string query = "insert into usuario (nome, email, setor, rg, cpf) " +
                                                        "Values(" +
                                                            "'" + usuario.Nome + "', " +
                                                            "'" + usuario.Email + "', " +
                                                            "'" + usuario.Setor + "', " +
                                                            "'" + usuario.Rg + "', " +
                                                            "'" + usuario.Cpf + "'" +
                                                        ")";

                                        retorno = banco.Set(query);

                                        if (retorno >= 1) {
                                            Console.WriteLine();
                                            Console.WriteLine("Usuário inserido com sucesso! Pressione Enter para continuar");
                                            Console.ReadLine();
                                        } else {
                                            Console.WriteLine();
                                            Console.WriteLine("Ocorreu um erro ao inserir o usuário, deseja tentar novamente? (0 = Sim, 1 = Não)");
                                            retorno = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    break;
                                case 2:
                                    retorno = 0;
                                    while (retorno == 0) {
                                        Console.Clear();
                                        Console.WriteLine("*********** Menu de Atualização de Usuários ***********");
                                        Console.WriteLine();
                                        Console.Write("Digite o CPF do usuário que deseja atualizar: ");
                                        string cpf = Console.ReadLine();

                                        Console.Write("Nome: ");
                                        string nome = Console.ReadLine();

                                        Console.Write("E-mail: ");
                                        string email = Console.ReadLine();

                                        Console.Write("Setor: ");
                                        string setor = Console.ReadLine();

                                        Console.Write("RG: ");
                                        string rg = Console.ReadLine();

                                        Usuario usuario = new Usuario(nome, email, setor, rg, cpf);
                                        string query = "update usuario " +
                                                        "set " +
                                                            "nome = '" + usuario.Nome + "', " +
                                                            "email = '" + usuario.Email + "', " +
                                                            "setor = '" + usuario.Setor + "', " +
                                                            "rg = '" + usuario.Rg + "'" +
                                                        "WHERE cpf = '" + usuario.Cpf + "';";

                                        retorno = banco.Set(query);

                                        if (retorno >= 1) {
                                            Console.WriteLine();
                                            Console.WriteLine("Usuário atualizado com sucesso! Pressione Enter para continuar");
                                            Console.ReadLine();
                                        } else {
                                            Console.WriteLine();
                                            Console.WriteLine("Ocorreu um erro ao atualizar o usuário, deseja tentar novamente? (0 = Sim, 1 = Não)");
                                            retorno = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    break;
                                case 3:
                                    retorno = 0;
                                    while (retorno == 0) {
                                        Console.Clear();
                                        Console.WriteLine("*********** Menu de Remoção de Usuários ***********");
                                        Console.WriteLine();
                                        Console.Write("Digite o CPF do usuário que deseja remover: ");
                                        string cpf = Console.ReadLine();

                                        string query = "delete from usuario where cpf = '" + cpf + "'";

                                        retorno = banco.Set(query);

                                        if (retorno >= 1) {
                                            Console.WriteLine();
                                            Console.WriteLine("Usuário removido com sucesso! Pressione Enter para continuar");
                                            Console.ReadLine();
                                        } else {
                                            Console.WriteLine();
                                            Console.WriteLine("Ocorreu um erro ao remover o usuário, deseja tentar novamente? (0 = Sim, 1 = Não)");
                                            retorno = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    break;
                                case 4:
                                    retorno = 0;
                                    while (retorno == 0) {
                                        Console.Clear();
                                        Console.WriteLine("*********** Menu de Consulta de Usuários ***********");
                                        Console.WriteLine();
                                        Console.Write("Digite o CPF do usuário que deseja buscar: ");
                                        string cpf = Console.ReadLine();

                                        string query = "select nome, email, setor, rg, cpf " +
                                                        "from usuario " +
                                                        "where cpf = '" + cpf + "';";

                                        DataTable table = banco.Get(query);

                                        if (table.Rows.Count > 0 && table != null) {
                                            foreach (DataRow row in table.Rows) {
                                                Console.WriteLine("Nome: " + row["nome"].ToString());
                                                Console.WriteLine("Email: " + row["email"].ToString());
                                                Console.WriteLine("Setor: " + row["setor"].ToString());
                                                Console.WriteLine("RG: " + row["rg"].ToString());
                                                Console.WriteLine("CPF: " + row["cpf"].ToString());
                                                Console.WriteLine();
                                            }
                                        } else {
                                            Console.WriteLine("Não há nenhum registro na tabela. Pressione enter para continuar");
                                            Console.ReadLine();
                                            retorno = 1;
                                        }


                                        Console.WriteLine();
                                        Console.WriteLine("Deseja buscar outro usuário? (0 = Sim, 1 = Não)");
                                        retorno = int.Parse(Console.ReadLine());

                                    }
                                    break;
                                case 5:
                                    retorno = 0;
                                    while (retorno == 0) {
                                        Console.Clear();
                                        Console.WriteLine("*********** Listagem de Usuários ***********");
                                        Console.WriteLine();

                                        string query = "SELECT * FROM usuario";
                                        DataTable table = banco.Get(query);

                                        if (table.Rows.Count > 0 && table != null) {
                                            foreach (DataRow row in table.Rows) {
                                                Console.WriteLine("Nome: " + row["nome"].ToString());
                                                Console.WriteLine("Email: " + row["email"].ToString());
                                                Console.WriteLine("Setor: " + row["setor"].ToString());
                                                Console.WriteLine("RG: " + row["rg"].ToString());
                                                Console.WriteLine("CPF: " + row["cpf"].ToString());
                                                Console.WriteLine();
                                            }
                                        } else {
                                            Console.WriteLine("Não há nenhum registro na tabela. Pressione enter para continuar");
                                            Console.ReadLine();
                                            retorno = 1;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("Deseja listar novamente? (0 = Sim, 1 = Não)");
                                        retorno = int.Parse(Console.ReadLine());

                                    }
                                    break;
                                case 0:
                                    controlePrincipal = 0;
                                    break;
                                case 9:
                                    controlePrincipal = null;
                                    break;

                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Opção inválida tente novamente");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        while (controleSecundario != 0 && controleSecundario != 9) {

                            Console.Clear();
                            Console.WriteLine("*********** Menu de Clientes ***********");
                            Console.WriteLine();
                            Console.WriteLine("1 - Inserir Cliente");
                            Console.WriteLine("2 - Atualizar Cliente");
                            Console.WriteLine("3 - Remover Cliente");
                            Console.WriteLine("4 - Buscar Cliente");
                            Console.WriteLine("5 - Listar Clientes");
                            Console.WriteLine("9 - Voltar para o menu anterior");
                            Console.WriteLine("0 - Sair do Sistema");
                            Console.Write("Escolha uma opção: ");

                            controleSecundario = int.Parse(Console.ReadLine());
                            int retorno = 0;
                            switch (controleSecundario) {
                                case 1:
                                    while (retorno == 0) {
                                        Console.Clear();
                                        Console.WriteLine("*********** Menu de Inserção de Clientes ***********");
                                        Console.WriteLine();
                                        Console.Write("Nome: ");
                                        string nome = Console.ReadLine();

                                        Console.Write("Endereco: ");
                                        string endereco = Console.ReadLine();

                                        Console.Write("Bairro: ");
                                        string bairro = Console.ReadLine();

                                        Console.Write("Cidade: ");
                                        string cidade = Console.ReadLine();

                                        Console.Write("Telefone: ");
                                        string telefone = Console.ReadLine();

                                        Console.Write("CPF: ");
                                        string cpf = Console.ReadLine();

                                        Cliente cliente = new Cliente(nome, endereco, bairro, cidade, telefone, cpf);

                                        string query = "insert into cliente (nome, endereco, bairro, cidade, telefone, cpf) " +
                                                        "Values(" +
                                                            "'" + cliente.Nome + "', " +
                                                            "'" + cliente.Endereco + "', " +
                                                            "'" + cliente.Bairro + "', " +
                                                            "'" + cliente.Cidade + "', " +
                                                            "'" + cliente.Telefone + "', " +
                                                            "'" + cliente.Cpf + "'" +
                                                        ")";

                                        retorno = banco.Set(query);

                                        if (retorno >= 1) {
                                            Console.WriteLine();
                                            Console.WriteLine("Cliente inserido com sucesso! Pressione Enter para continuar");
                                            Console.ReadLine();
                                        } else {
                                            Console.WriteLine();
                                            Console.WriteLine("Ocorreu um erro ao inserir o cliente, deseja tentar novamente? (0 = Sim, 1 = Não)");
                                            retorno = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    break;
                                case 2:
                                    retorno = 0;
                                    while (retorno == 0) {
                                        Console.Clear();
                                        Console.WriteLine("*********** Menu de Atualização de Clientes ***********");
                                        Console.WriteLine();
                                        Console.Write("Digite o CPF do cliente que deseja atualizar: ");
                                        string cpf = Console.ReadLine();

                                        Console.Write("Nome: ");
                                        string nome = Console.ReadLine();

                                        Console.Write("Endereco: ");
                                        string endereco = Console.ReadLine();

                                        Console.Write("Bairro: ");
                                        string bairro = Console.ReadLine();

                                        Console.Write("Cidade: ");
                                        string cidade = Console.ReadLine();

                                        Console.Write("Telefone: ");
                                        string telefone = Console.ReadLine();

                                        Cliente cliente = new Cliente(nome, endereco, bairro, cidade, telefone, cpf);
                                        string query = "update cliente " +
                                                        "set " +
                                                            "nome = '" + cliente.Nome + "', " +
                                                            "endereco = '" + cliente.Endereco + "', " +
                                                            "bairro = '" + cliente.Bairro + "', " +
                                                            "cidade = '" + cliente.Cidade + "'," +
                                                            "telefone = '" + cliente.Telefone + "' " +
                                                        "WHERE cpf = '" + cliente.Cpf + "';";
                                        retorno = banco.Set(query);
                                        if (retorno >= 1) {
                                            Console.WriteLine();
                                            Console.WriteLine("Cliente atualizado com sucesso! Pressione Enter para continuar");
                                            Console.ReadLine();
                                        } else {
                                            Console.WriteLine();
                                            Console.WriteLine("Ocorreu um erro ao atualizar o cliente, deseja tentar novamente? (0 = Sim, 1 = Não)");
                                            retorno = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    break;
                                case 3:
                                    retorno = 0;
                                    while (retorno == 0) {
                                        Console.Clear();
                                        Console.WriteLine("*********** Menu de Remoção de Clientes ***********");
                                        Console.WriteLine();
                                        Console.Write("Digite o CPF do cliente que deseja remover: ");
                                        string cpf = Console.ReadLine();
                                        string query = "delete from cliente where cpf = '" + cpf + "'";
                                        retorno = banco.Set(query);

                                        if (retorno >= 1) {
                                            Console.WriteLine();
                                            Console.WriteLine("Cliente removido com sucesso! Pressione Enter para continuar");
                                            Console.ReadLine();
                                        } else {
                                            Console.WriteLine();
                                            Console.WriteLine("Ocorreu um erro ao remover o cliente, deseja tentar novamente? (0 = Sim, 1 = Não)");
                                            retorno = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    break;
                                case 4:
                                    retorno = 0;
                                    while (retorno == 0) {
                                        Console.Clear();
                                        Console.WriteLine("*********** Menu de Consulta de Clientes ***********");
                                        Console.WriteLine();
                                        Console.Write("Digite o CPF do usuário que deseja buscar: ");
                                        string cpf = Console.ReadLine();

                                        string query = "select nome, endereco, bairro, cidade, telefone, cpf " +
                                                        "from cliente " +
                                                        "where cpf = '" + cpf + "';";
                                        DataTable table = banco.Get(query);

                                        if (table.Rows.Count > 0 && table != null) {
                                            foreach (DataRow row in table.Rows) {
                                                Console.WriteLine("Nome: " + row["nome"].ToString());
                                                Console.WriteLine("Endereço: " + row["endereco"].ToString());
                                                Console.WriteLine("Bairro: " + row["bairro"].ToString());
                                                Console.WriteLine("Cidade: " + row["cidade"].ToString());
                                                Console.WriteLine("Telefone: " + row["telefone"].ToString());
                                                Console.WriteLine("CPF: " + row["cpf"].ToString());
                                                Console.WriteLine();
                                            }
                                        } else {
                                            Console.WriteLine("Não há nenhum registro na tabela. Pressione enter para continuar");
                                            Console.ReadLine();
                                            retorno = 1;
                                        }

                                        Console.WriteLine();
                                        Console.WriteLine("Deseja buscar outro cliente? (0 = Sim, 1 = Não)");
                                        retorno = int.Parse(Console.ReadLine());

                                    }
                                    break;
                                case 5:
                                    retorno = 0;
                                    while (retorno == 0) {
                                        Console.Clear();
                                        Console.WriteLine("*********** Listagem de Clientes ***********");
                                        Console.WriteLine();

                                        string query = "SELECT * FROM cliente";
                                        DataTable table = banco.Get(query);

                                        if (table.Rows.Count > 0 && table != null) {
                                            foreach (DataRow row in table.Rows) {
                                                Console.WriteLine("Nome: " + row["nome"].ToString());
                                                Console.WriteLine("Endereço: " + row["endereco"].ToString());
                                                Console.WriteLine("Bairro: " + row["bairro"].ToString());
                                                Console.WriteLine("Cidade: " + row["cidade"].ToString());
                                                Console.WriteLine("Telefone: " + row["telefone"].ToString());
                                                Console.WriteLine("CPF: " + row["cpf"].ToString());
                                                Console.WriteLine();
                                            }
                                        } else {
                                            Console.WriteLine("Não há nenhum registro na tabela. Pressione enter para continuar");
                                            Console.ReadLine();
                                            retorno = 1;
                                        }

                                        Console.WriteLine();
                                        Console.WriteLine("Deseja listar novamente? (0 = Sim, 1 = Não)");
                                        retorno = int.Parse(Console.ReadLine());

                                    }
                                    break;
                                case 0:
                                    controlePrincipal = 0;
                                    break;
                                case 9: break;

                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Opção inválida tente novamente");
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
