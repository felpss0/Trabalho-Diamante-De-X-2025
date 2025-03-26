

namespace TrabalhoDiamanteDeX.ConsoleApp
{
    class DesenharDiamante
    {
        public static void RealizarDesenho(int numero) 
        {
            int meio = numero / 2;

            for (int linhas = 0; linhas <= meio; linhas++)
            {

                Console.Write(new string(' ', meio - linhas));
                Console.WriteLine(new string('X', 2 * linhas + 1));

            }

            for (int linhas = meio - 1; linhas >= 0; linhas--)
            {
                Console.Write(new string(' ', meio - linhas));
                Console.WriteLine(new string('X', 2 * linhas + 1));

            }

        }

    }
}
