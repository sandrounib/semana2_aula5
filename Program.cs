using System;
using System.IO;

namespace semana2_aula5
{
    class Program
    {
        static void Main(string[] args)
        {                        
            string[] perguntas = File.ReadAllLines(@"C:\Users\FIC\Desktop\semana2_aula5\Perguntas.txt");            
            string[] respostas = new string [perguntas.Length];        

            for (int i = 0; i < perguntas.Length; i ++)
            {
                Console.WriteLine("Qual é o seu/sua: " + perguntas[i]);
                respostas[i] = Console.ReadLine();            
            }         

            bool arquivoExiste = File.Exists("Respostas.csv");
            StreamWriter sw = new StreamWriter (@"C:\Users\FIC\Desktop\semana2_aula5\Respostas.csv");                       
           
                for (int i = 0; i < perguntas.Length; i ++)
                {
                    sw.Write(perguntas[i] + ";");
                } 
                sw.NewLine();
                for (int i = 0; i < respostas.Length; i ++)
                {
                    if (arquivoExiste)
                    {
                        sw.Write(respostas[i] + ";");
                    }                   
                } 
                sw.NewLine();
                sw.Close();          
               
        }
    }
}
