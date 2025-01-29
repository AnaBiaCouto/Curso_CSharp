namespace formatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.54821;
            double num2 = 54781.65874;

            Console.WriteLine($"{num1:F2}"); //duas casas decimais
            Console.WriteLine($" {num2:N2}"); //formato de numero
            Console.WriteLine($"{num1:C2}"); //formato de moeda
            Console.WriteLine($"{num2:E2}"); //notação cientifica
            Console.WriteLine($"{num1:P2}"); //formato porcentagem 



        }
    }
}
