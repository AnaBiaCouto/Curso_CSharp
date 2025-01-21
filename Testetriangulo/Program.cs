using System.ComponentModel.Design;

namespace Testetriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;
            Console.Write("Digite o valor do ladoA: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do ladoB: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do ladoC: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os valores informados formam um triângulo.");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("E ele é um triângulo equilátero");
                }
                else if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
                {
                    Console.WriteLine("E ele é um triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("E ele é um triângulo escaleno");
                }

                
               
            }
            else
            {
                Console.WriteLine("Os valores informados não formam um triângulo.");
            }





        }
         
    }
}
