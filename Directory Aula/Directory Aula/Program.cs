using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_Aula {
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\myFolder";
            try {

                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string folder in folders) {
                    Console.WriteLine(folder);
                }

                Console.WriteLine();

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string file in files) {
                    Console.WriteLine(file);
                }

                Console.WriteLine();

                Directory.CreateDirectory(path + @"\newFolder");

            } catch (IOException e) {

                Console.WriteLine(e.Message);
            }
        }
    }
}
