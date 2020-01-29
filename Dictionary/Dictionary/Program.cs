using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Words = new ArrayList();
            Words.Add("Boat");
            Words.Add("house");
            Words.Add("cat");
            Words.Add("river"); ;
            Words.Add("cupboard");

             Console.WriteLine("Length of array : ");
             Console.WriteLine(Words.Count);
             
             Console.WriteLine("Plural of all words :");

            foreach (string word in Words)
             {

                Console.WriteLine(word + "s");
            }

         Words.Add("Achieve");
         Console.WriteLine("Length of the array after insertion of new element : ");
         Console.WriteLine(Words.Count);



            //Replace Of 2nd word with it's synonym

            
            Words.Insert(1,"Shelter");

            Console.WriteLine("Now House Changed to its synonym :");

            Console.WriteLine(Words[1]);



            //Printing The Words Having Length 7

            Console.WriteLine("Printing the list of words which contains the length of characters as 7");

            for (int i = 0; i < Words.Count; i++)
            {
                 string w = (string)Words[i];
                if (w.Length == 7)
                 {

                    Console.WriteLine(Words[i]);
                }
            }
         Console.WriteLine("Word On 3rd Position :");

            Console.WriteLine(Words[2]);

            //Sorting Of Array In Ascending Order

            Console.WriteLine("After sorting :");

            for (int i = 0; i < Words.Count; i++)

            {
                 Words.Sort();
                 Console.WriteLine(Words[i]);
            }

            //Reverse Of Array

            Console.WriteLine("Reverse Order Of Array :");

            for (int i = 0; i < Words.Count; i++)
             {
                Words.Reverse();
                Console.WriteLine(Words[i]);
                }
                    Console.ReadKey();
             }
         private static void PrintValues(IEnumerable ArrayWords)
        {
            foreach (Object obj in ArrayWords)
                {
                 Console.WriteLine("  {0}", obj);
                    Console.WriteLine();
            }

        }
    }
    
}
