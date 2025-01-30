namespace ExercicioTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Calcule a área do triângulo");
            Console.WriteLine();

            Console.Write("Digite a base do triângulo(m):");
            Double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a altura do triângulo (m):");
           Double A= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area(B, A); 
        }


        static void escreva(string texto)
        {
            char caracter = '*';
            int tamanho = texto.Length + 4;
            string linha = new string(caracter, tamanho);
            string textoCentralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho);
            Console.WriteLine(linha);
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha);
        }


        static void area(double Base, double Altura)
        {
            double a = (Base * Altura) / 2;
            double b = (Base * Altura) / 2;
            Console.WriteLine($"A Área do triângulo é:é de {a:F2} m²");

        }
        
            

        

    }
}