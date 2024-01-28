using System;
using System.IO;

namespace FileHandling
{
    public class Program
    {
        public static void Main()
        {

            const string MsgFileName = "Introdueix el nom del fitxer (amb extensió .txt): ";

            string file;

            do
            {

                Console.WriteLine(MsgFileName);
                file = Console.ReadLine();

            } while (!ValidFileName(file));

            FileHandling(file);

        }

        public static void FileHandling(string file)
        {
            const string MsgText = "Introdueix el text a inserir: ";
            string text;

            Console.WriteLine(MsgText);
            text = Console.ReadLine();

            try
            {
                string path = Path.GetFullPath(@"..\..\..\files\" + file);

                using StreamWriter sw = new StreamWriter(path, append: true);
                sw.WriteLine(text);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static bool ValidFileName(string fileName)
        {
            return fileName.EndsWith(".txt");
        }
    }
}