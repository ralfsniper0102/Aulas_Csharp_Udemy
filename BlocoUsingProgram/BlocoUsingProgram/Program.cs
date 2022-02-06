using System;
using System.IO;

namespace BlocoUsingProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Rafael\OneDrive\Área de Trabalho\File1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro,  " + ex.Message);
            }

            try
            {

            }
            catch
            {

            }

        }
    }
}
