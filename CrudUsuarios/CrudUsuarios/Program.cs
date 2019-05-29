using System;
using CrudUsuarios.Entities;
using CrudUsuarios.Services;
namespace CrudUsuarios {
    class Program {
        static void Main(string[] args) {
            //Cliente cliente = new Cliente("Fhaidy Maciel", "meu endereco", "meu bairro", "minha cidade", "meu fone", "meu cpf2");
            //Usuario usuario = new Usuario("Fhaidy", "email2", "setor2", "rg2", "cpf123");

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
                                        retorno = usuario.InserirUsuario(usuario);

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
                                        retorno = usuario.AtualizarUsuario(usuario);

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

                                        Usuario usuario = new Usuario();
                                        retorno = usuario.RemoverUsuario(cpf);

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

                                        Usuario usuario = new Usuario();
                                        usuario.ConsultarUsuario(cpf);

                                        Console.WriteLine();
                                        Console.WriteLine("Deseja buscar outro usuário? (0 = Sim, 1 = Não)");
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
                                        retorno = cliente.InserirCliente(cliente);

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
                                        retorno = cliente.AtualizarCliente(cliente);

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

                                        Cliente cliente = new Cliente();
                                        retorno = cliente.RemoverCliente(cpf);

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

                                        Cliente cliente = new Cliente();
                                        cliente.ConsultarCliente(cpf);

                                        Console.WriteLine();
                                        Console.WriteLine("Deseja buscar outro cliente? (0 = Sim, 1 = Não)");
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
