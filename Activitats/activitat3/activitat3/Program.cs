/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF3
 * v1. 28/01/2024
 * Activitat 3. Implementa un programa que demani el nom d’un fitxer de text i que retorni per consola el nombre de línies que aquest conté.
 *
 */


using System;

namespace MyApplication
{

    public class CountLines
    {
        public static void Main()
        {

            const string MsgFileName = "Introdueix el nom del fitxer (amb l'extensió .txt): ";

            string fileName;

            Console.WriteLine(MsgFileName);
            fileName = Console.ReadLine();

            FileHandling(fileName);

        }

        public static void FileHandling(string file)
        {
            string path = Path.GetFullPath(@"..\..\..\files\" + file);
            using StreamReader sr = new StreamReader(path);

            int numLines = 0;


            while (sr.ReadLine() != null)
            {
                numLines++;
            }

            Console.WriteLine(numLines);
        }
    }

}
