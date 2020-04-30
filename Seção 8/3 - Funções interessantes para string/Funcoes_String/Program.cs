using System;

namespace Funcoes_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper(); // Converter para maíusculo
            string s2 = original.ToLower(); // Converter para minúsculo
            string s3 = original.Trim(); // Apagar espaços em branco depois e na frente do string

            int n1 = original.IndexOf("bc"); // Procurar a primeira posição
            int n2 = original.LastIndexOf("bc"); // Procurar a última posição

            string s4 = original.Substring(3); // Cortar a string a partir de uma posição e considerar o resto
            string s5 = original.Substring(3, 5); // Cortar a string a partir de uma posição e exibir um tamanho 
                                                  // específico depois daquela posição

            string s6 = original.Replace('a', 'x'); // Substituir um caractere pelo outro
            string s7 = original.Replace("abc", "xy"); // Trocar uma string por outra

            bool b1 = String.IsNullOrEmpty(original); // Testar se é nulo ou vazio
            bool b2 = string.IsNullOrWhiteSpace(original); // Testar se é nulo ou se é espaço em branco

            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"ToUpper: -{s1}-");
            Console.WriteLine($"ToLower: -{s2}-");
            Console.WriteLine($"Trim: -{s3}-");
            Console.WriteLine($"IndexOf('bc'): {n1}");
            Console.WriteLine($"LastIndexOf('bc'): {n2}");
            Console.WriteLine($"Substring(3): -{s4}-");
            Console.WriteLine($"Substring(3, 5): -{s5}-");
            Console.WriteLine($"Replace('a', 'x'): -{s6}-");
            Console.WriteLine($"Replace('abc', 'xy'): -{s7}-");
            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");
        }
    }
}
