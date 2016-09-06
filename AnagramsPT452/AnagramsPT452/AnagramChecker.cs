using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramsPT452
{
    public class AnagramChecker
    {
        public static string[] words;
        static void Main(string[] args)
        {
            int totalno = 0;
            int z = 1;
            //Input number of words to check anagrams
            
            try {
                Console.WriteLine("Input number of words to check anagrams");
                totalno = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input should be integer");

            }
                string[] words = new string[totalno];
            for (int i = 0; i < totalno; i++)
            {
                //Take words from user to check anagrams
                Console.WriteLine("Enter word" + " " + z++);
                words[i] = Console.ReadLine();
                char[] d = {' ', '\t' };
                words[i] = words[i].Trim(d);
            }
            List<string> result = new List<string>();
            bool match = false;

            //trim all spaces from the input words
            for (int i = 0; i < words.Count(); i++)
                words[i] = words[i].Trim();

            //loop through array starting with first word
            for (int i = 0; i < words.Count(); i++)
            {
                result.Add(words[i]);
                //loop through array starting with the next word in line
                for (int c = i + 1; c < words.Count(); c++)
                {
                    //only see if words match, if number of letters matches
                    if (words[i].Length == words[c].Length && words[i] != "")
                    {
                        //convert both words to charArray
                        char[] a = words[i].ToUpper().ToCharArray();
                        char[] b = words[c].ToUpper().ToCharArray();
                        Array.Sort(a);
                        Array.Sort(b);

                        match = false;
                        int counter = 0;

                        //loop throu each letter in both words
                        foreach (char x in a)
                        {
                            if (x == b[counter])
                                match = true;
                            else
                            {
                                match = false;
                                break;
                            }
                            counter++;
                        }
                        //if all letters match, add the words to the list
                        if (match)
                        {
                            result.Add(words[c]);
                            words[c] = "";
                        }
                    }
                }

                //if list is equal to 1, no match was found
                if (result.Count() > 0 && result[0] != "")
                {
                    Console.Write("Anagrams: ");
                    foreach (string s in result)
                        Console.Write(s + " ");
                    Console.WriteLine();
                    Console.WriteLine(result.Count);
                }
                //reset the list
                result.Clear();
            }
            Console.ReadKey();
        }
        public static void CheckAnagramWords(string[] paramWords)
        {
            string[] words = paramWords;

            List<string> result = new List<string>();
            bool match = false;

            //trim all spaces from the input words
            for (int i = 0; i < words.Count(); i++)
                words[i] = words[i].Trim();

            //loop through array starting with first word
            for (int i = 0; i < words.Count(); i++)
            {
                result.Add(words[i]);
                //loop through array starting with the next word in line
                for (int c = i + 1; c < words.Count(); c++)
                {
                    //only see if words match, if number of letters matches
                    if (words[i].Length == words[c].Length && words[i] != "")
                    {
                        //convert both words to charArray
                        char[] a = words[i].ToUpper().ToCharArray();
                        char[] b = words[c].ToUpper().ToCharArray();
                        Array.Sort(a);
                        Array.Sort(b);

                        match = false;
                        int counter = 0;

                        //loop throu each letter in both words
                        foreach (char x in a)
                        {
                            if (x == b[counter])
                                match = true;
                            else
                            {
                                match = false;
                                break;
                            }
                            counter++;
                        }
                        //if all letters match, add the words to the list
                        if (match)
                        {
                            result.Add(words[c]);
                            words[c] = "";
                        }
                    }
                }

                //if list is equal to 1, no match was found
                if (result.Count() > 0 && result[0] != "")
                {
                    Console.Write("Anagrams: ");
                    foreach (string s in result)
                        Console.Write(s + " ");
                    Console.WriteLine();
                    Console.WriteLine(result.Count);
                }
                //reset the list
                result.Clear();
            }
            Console.ReadKey();
        }
    }
}