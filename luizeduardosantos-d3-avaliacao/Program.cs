using luizeduardosantos_d3_avaliacao.Repositories;

namespace luizeduardosantos_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            while (true)
            {
                Console.WriteLine("Escolha uma opcao:\n");
                Console.WriteLine("1 - acessar\n");
                Console.WriteLine("2 - cancelar\n");

                string opcao = Console.ReadLine();
                string opcao2 = string.Empty;

                if (opcao == "2" || opcao == "cancelar") break;

                else if (opcao == "1" || opcao == "acessar")
                {
                    
                    do
                    {
                        
                        Console.WriteLine("Digite seu email");
                        string email = Console.ReadLine();

                        Console.WriteLine("Digite sua senha");
                        string senha = Console.ReadLine();

                        bool sucesso = UserRepository.LookUp(email, senha);  

                        if (sucesso == true)
                        {
                            Console.WriteLine("Escolha uma opcao:\n");
                            Console.WriteLine("1 - deslogar\n");
                            Console.WriteLine("2 - encerrar sistema\n");

                            opcao2 = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Senha ou usuario invalido\n");
                            opcao2 = "invalido";
                        }
                    } while (opcao2 == "invalido");

                }

                else
                {
                    Console.WriteLine("opcao invalida");
                }

                if (opcao2 == "encerrar sistema" || opcao2 == "2") break;


            }
        }
    }
}