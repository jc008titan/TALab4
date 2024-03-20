using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        /*public static string RemoveSpecialCharacters(string myString)
        {
            var pattern = new Regex("[:!@#$%^&*()}{|\":?><\\[]\\;'/.,~]\\G");
            Console.WriteLine(pattern);
            if(myString!=null)
            myString=pattern.Replace(myString, " ");
            return myString;
        }*/
        static void Main(string[] args)
        {
            string[] cuvinte = new string[] { };
            using (StreamReader streamReader = new StreamReader("TextFile1.txt"))
            {
                string linieFisier;
                /* citeste cate o linie si creaza un obiect de tip Student
                pe baza datelor din linia citita */
                while ((linieFisier = /*RemoveSpecialCharacters(*/streamReader.ReadLine()) != null)
                {
                    char[] separator = { ' ' };
                    string[] cuvintelinie = linieFisier.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var c in cuvintelinie)
                    {
                        Array.Resize(ref cuvinte, cuvinte.Length + 1);
                        cuvinte[cuvinte.Length - 1] = c;
                    }
                    // verificare pentru nrStudenti < NR_MAX_STUDENTI!
                }
            }




            
            string[][] dictionar = new string[26][];
            string alfabet = "abcdefghijklmnopqrtsuvwxyz";

            for (int i = 0; i < 26; i++)
            {

                dictionar[i] = new string[] { };
                foreach (var cuvant in cuvinte)
                { 
                    if (cuvant[0].ToString().ToUpper() == alfabet[i].ToString().ToUpper())
                    {
                        Array.Resize(ref dictionar[i], dictionar[i].Length + 1);
                        dictionar[i][dictionar[i].Length - 1] = cuvant;
                    }
                }
            }
                for (int i = 0; i < dictionar.Length; i++)
                {
                if (dictionar[i] != null)
                {
                    Console.Write($"{alfabet[i].ToString().ToUpper()}: ");
                    for (int j = 0; j < dictionar[i].Length; j++)


                    {
                        Console.Write($"{dictionar[i][j]} ");
                    }

                    if (dictionar[i].Length == 0) Console.Write("-");
                    Console.WriteLine();
                }
            }
            
            Console.Read();
            //preia array variabil, il citeste, il scrie pe ecran si in text, se inchide apicatia
        }
    }
}
