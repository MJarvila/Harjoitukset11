using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj11Teht1
{
    class Program
    {
        public delegate string TextSort(string word);

        static void Main(string[] args)
        {

            TextSorter sorter = new TextSorter();
            TextSort TextToUpper = new TextSort(sorter.ToUpperCase);
            TextSort TextToLower = new TextSort(sorter.ToLowerCase);
            TextSort TextToTitle = new TextSort(sorter.ToTitle);
            TextSort ReverseText = new TextSort(sorter.Reverse);

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Anna tekstiä:");
                string text = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Mitä haluat tekstille tehtävän?");
                Console.WriteLine("1) KAIKKI KOLOSSAALISEKSI");
                Console.WriteLine("2) kaikki pienellä");
                Console.WriteLine("3) Alkukirjaimet Isoiksi");
                Console.WriteLine("4) nirepakat");
                Console.WriteLine("0) lopettaa");
                Console.WriteLine();
                string operations = Console.ReadLine();

                switch (operations)
                {
                    case "0":
                        loop = false;
                        break;
                    case "1":
                        Console.WriteLine(TextToUpper(text));
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine(TextToLower(text));
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine(TextToTitle(text));
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine(ReverseText(text));
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
