using System;
using System.IO;

namespace StreamWriteProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Rafael\OneDrive\Área de Trabalho\File1.txt";
            string targetPath = @"C:\Users\Rafael\OneDrive\Área de Trabalho\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);//////////read all lines and write in vector

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    Console.WriteLine("");
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper()); //write in doc
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro, " + ex.Message);

            }

        }
    }
}
