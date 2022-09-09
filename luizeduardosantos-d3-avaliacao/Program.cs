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

                if (opcao == "2" || opcao == "cancelar") break;

                else if (opcao == "1" || opcao == "acessar")
                {
                    Console.WriteLine("Digite seu email\n");
                    string email = Console.ReadLine();

                    Console.WriteLine("Digite sua senha\n");
                    string senha = Console.ReadLine();



                }

                else
                {
                    Console.WriteLine("opcao invalida");
                }

            }
        }
    }
}