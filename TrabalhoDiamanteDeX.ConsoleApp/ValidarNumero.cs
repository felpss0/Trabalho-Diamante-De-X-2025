
namespace TrabalhoDiamanteDeX.ConsoleApp
{
    class ValidarNumero
    {
        public static bool VerificarNumeroDigitado(int numero)
        {

            if (numero % 2 == 0)
            {
                Console.WriteLine("Digite um numero valido");
                return false;
            }
            return true;

        }
    }
}
