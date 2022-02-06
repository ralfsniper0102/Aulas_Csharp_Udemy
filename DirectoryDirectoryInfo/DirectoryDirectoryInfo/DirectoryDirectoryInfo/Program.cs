using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Rafael\OneDrive\Área de Trabalho\MyFolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //List all folders
                Console.WriteLine("FOLDERS:");
                foreach(string folderItem in folders) //write all folders
                {
                    Console.WriteLine(folderItem);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //list all files
                Console.WriteLine("FILES:");
                foreach (string filesItem in files) ///write all files
                {
                    Console.WriteLine(filesItem);
                }

                Directory.CreateDirectory(path + "\\newfolder"); // create folder

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
