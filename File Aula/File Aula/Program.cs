using System;
using System.IO;

namespace File_Aula {
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\file1.txt";
            string path2 = @"c:\temp\file2.txt";

            try {

                string[] lines = File.ReadAllLines(path);

                using (StreamWriter sw = File.AppendText(path2)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            } catch (IOException e) {

                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
