namespace Impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Ana Beatriz Oliveira Couto");
            Console.WriteLine(); // pula linha

            escreva("Seja Bem Vindo!");
            Console.WriteLine(); // pula linha

            escreva("Oi");
            Console.WriteLine(); // pula linha


            escreva("Curso C#");
            Console.WriteLine(); // pula linha


        }


        static void escreva(string texto)
        {// método que imprime um texto centralizado entre duas linhas de caracteres
            char caracter = '*'; // caractere que será impresso
            int tamanho = texto.Length + 4; // tamanho da linha
            string linha = new string(caracter, tamanho); // linha de caracteres
            string textoCentralizado =texto.PadLeft(2 + texto.Length).PadRight(tamanho);// texto centralizado
            Console.WriteLine(linha);       // imprime linha
            Console.WriteLine(textoCentralizado); // imprime texto centralizado
            Console.WriteLine(linha);   // imprime linha

        }
    }









}
