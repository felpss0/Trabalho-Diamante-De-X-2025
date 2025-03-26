namespace TrabalhoDiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                Console.Write("Digite um numero impar: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (!ValidarNumero.VerificarNumeroDigitado(numero))
                    continue;

                DesenharDiamante.RealizarDesenho(numero);

                Console.WriteLine("Deseja Continuar? ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                    break;

                Console.ReadLine();

            }

        }
    }
}
