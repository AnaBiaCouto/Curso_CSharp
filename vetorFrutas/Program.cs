namespace vetorFrutas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Banana", "Maçã", "Manga", "Morango", "Uva", "Melão", "Melancia", "Abacaxi", "Laranja", "Abacate" };
            int[] preços = { 12, 8, 15, 10, 20, 10, 15, 8, 5, 10 };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("O preço do Kg da " + frutas[i] + " é R$" + preços[i] + ",00");
            }

            Console.WriteLine();


            int maior_preco = preços.Max();
            int menor_preco = preços.Min();
            Console.WriteLine("A fruta mais cara é:R$ "+ maior_preco + ",00");
            Console.WriteLine("A fruta mais barata é:R$ "+ menor_preco + ",00"); 

            Console.WriteLine();

            string nome_primeiro = frutas.Min();
            string nome_ultimo = frutas.Max();
            Console.WriteLine("A primeira fruta em ordem alfabética é: " + nome_primeiro);
            Console.WriteLine("A última fruta em ordem alfabética é: " + nome_ultimo);



        }
    }
}
