using System;
using System.IO;

namespace semana2_aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] perguntas = new string[10];
            string[] respostas = new string[10];
            string[] Perguntas = File.ReadAllLines(@"C:\Users\FIC\Desktop\semana2_aula5\Perguntas.txt");
            string[] Respostas = new string[perguntas.Length];

            for (int i = 0; i < perguntas.Length; i ++)
            {
                Console.WriteLine("Qual é o seu/sua" + perguntas[i]);
                respostas[i] = Console.ReadLine();
            }
        }
    }
}
