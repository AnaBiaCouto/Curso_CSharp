using System.Security.Cryptography.X509Certificates;

namespace Tabuadafor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            Console.WriteLine("Digite um número");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
            }

        }
    }
}
