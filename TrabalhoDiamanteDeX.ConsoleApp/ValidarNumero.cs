
namespace TrabalhoDiamanteDeX.ConsoleApp
{
    class ValidarNumero
    {
        public static bool VerificarNumeroDigitado(int numero)
        {

            if (numero % 2 == 0)
            {
                Console.WriteLine("!!NUMERO INVALIDO. Aperte ENTER para continuar e digite um numero valido");
                Console.ReadLine();
                return false;
                
            }
            return true;
           

        }
    
    }
}
