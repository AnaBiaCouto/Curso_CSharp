namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Calculadora");
            Console.WriteLine("**********************");
            Console.WriteLine();
            
            Console.WriteLine("Digite dois números");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            soma(a, b);
            subtracao(a, b);
            multiplicacao(a, b);



           
        }


        static void subtracao(string[] args) 
        {
            Console.WriteLine("Digite dois números para subtair: ");    
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
        }

        static void multipicacao(string[] args) 
        {
            Console.WriteLine("Digite dois números para multiplicar: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            multiplicacao(a, b);

          
        }

        static void divisao(string[] args) 
        {
            Console.WriteLine("Digite dois números para dividr: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            divisao(a, b);

           

        }


        static void soma(double a, double b)
        {
            double resultado = a + b;
            Console.WriteLine("A soma de " + a + " + " + b + " = " + resultado);

        }

        static void subtracao(double a, double b)
        {
            double resultado = a - b;
            Console.WriteLine("A subtração de " + a + " - " + b + " = " + resultado);

        }


        static void multiplicacao(double a, double b)
        {
            double resultado = a * b;
            Console.WriteLine("A multiplicação de " + a + " * " + b + " = " + resultado);

        }

        static void divisao(double a, double b)
        {
            double resultado = a / b;
            Console.WriteLine("A divisão de " + a + " / " + b + " = " + resultado);


        }




    }
}    