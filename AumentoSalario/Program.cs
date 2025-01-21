namespace AumentoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do seu salario?");
            double salario;
            salario = Convert.ToDouble(Console.ReadLine());
            double aumento;

            if (salario > 2500)
            {
                aumento = salario * 0.05;
            }
            else if (salario > 1250)
            {
                aumento = salario * 0.10;
            }
            else
            {
                aumento = salario * 0.15;
            }

            Console.WriteLine("O aumento do seu salario é de: {0}", aumento + salario);







        }
    }
}
