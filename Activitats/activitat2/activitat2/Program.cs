/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF3
 * v1. 28/01/2024
 * Activitat 2. Implementa un programa que mostri per consola només la primera línia del document de text introduït per teclat. Aquest contindrà el següent text (cal mantenir el format):
 *
 */


using System;

namespace MyApplication
{

    public class Hola
    {
        public static void Main()
        {

            const string MsgFileText = "Introdueix el nom del fitxer (amb l'extensió): ";

            string file;

            Console.WriteLine(MsgFileText);
            file = Console.ReadLine();

            FileHandling(file);

        }

        public static void FileHandling(string file)
        {
            try
            {
                string path = Path.GetFullPath(@"..\..\..\files\" + file);

                using StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();

                Console.WriteLine(line);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}
