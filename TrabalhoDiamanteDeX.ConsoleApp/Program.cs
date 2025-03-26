namespace TrabalhoDiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {

                Console.Write("Digite um numero impar: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Digite um numero valido");
                    continue;
                }

                int meio = numero / 2;
                
                for (int linhas = 0; linhas <= meio; linhas++) 
                {
                    
                    Console.Write(new string(' ', meio - linhas));
                    Console.WriteLine(new string('X', 2 * linhas + 1));
                    
                }

                for (int linhas = meio - 1; linhas >=0; linhas--)
                {
                    Console.Write(new string(' ', meio - linhas));
                    Console.WriteLine(new string('X', 2 * linhas + 1));
                    
                }


                Console.WriteLine("Deseja Continuar? ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                    break;

                Console.ReadLine();

            }

        }
    }
}
