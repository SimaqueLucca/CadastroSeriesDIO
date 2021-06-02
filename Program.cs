using System;

namespace CadastroSeriesDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = OpcaoSelecionada();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "C":
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static string OpcaoSelecionada()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("Menu de opções");

            System.Console.WriteLine("");
            System.Console.WriteLine("[1] - Listar contas");
            System.Console.WriteLine("[2] - Inserir nova conta");
            System.Console.WriteLine("[3] - Depositar");
            System.Console.WriteLine("[4] - Sacar");
            System.Console.WriteLine("[5] - Transferir");
            System.Console.WriteLine("[C] - Limpar a tela");
            System.Console.WriteLine("[X] - Sair");
            System.Console.WriteLine("");

            System.Console.Write("Digite o número da opção: ");
            string opcao = Console.ReadLine();

            System.Console.WriteLine("");

            return opcao;
        }
    }
}
