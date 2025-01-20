namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            float media; 
            Console.WriteLine(" digite uma nota: ");    
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" digite outra nota: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            media = (num1 + num2) / 2;
            Console.WriteLine("A média é: " + media); 


        }
    }
}
