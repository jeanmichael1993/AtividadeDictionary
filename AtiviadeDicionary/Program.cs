using System;
using System.Collections.Generic;
using System.IO;

namespace AtividadeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path:");
            string path = Console.ReadLine();
            Dictionary<string, int> dy = new Dictionary<string, int>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vet = sr.ReadLine().Split(',');
                        string nome = vet[0];
                        int qtd = int.Parse(vet[1]);

                        if (dy.ContainsKey(nome))
                        {
                            dy[nome] += qtd;
                        }
                        else
                        {
                            dy[nome] = qtd;
                        }
                    }
                }
                foreach (var item in dy)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro qualquer");
            }
        }
    }
}
