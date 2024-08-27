using System;
using System.IO; // Necessário para usar a classe File

namespace Semana03.Exercicio03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "arquivo.txt";
            string texto = "Este é um documento de texto.";

            // Cria e escreve no arquivo
            File.WriteAllText(nomeDoArquivo, texto);

            // Mensagem de sucesso
            Console.WriteLine("Arquivo criado com sucesso!");
            Console.ReadKey(true);
        }
    }
}
