using System;
using System.IO;

namespace FileStreamStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Rafael\OneDrive\Área de Trabalho\File1.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    Console.WriteLine(line);
                }
                

            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }

                
            }
        }
    }
}
