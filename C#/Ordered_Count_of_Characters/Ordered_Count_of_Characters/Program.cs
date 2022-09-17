// Count the number of occurrences of each character and return it as a list of tuples in order of appearance.
// For empty output return an empty list.

// ordered_count("abracadabra") == [('a', 5), ('b', 2), ('r', 2), ('c', 1), ('d', 1)]


using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Solution
{
    public class Kata
    {
        public static List<Tuple<char, int>>OrderedCount(string input)
        {
            List<Tuple<char, int>> result = new List<Tuple<char, int>>();
            List<char> fullLetters = new List<char>();

            // makes a list of lettere
            for (int i = 0; i < input.Length; i++)
            {
                fullLetters.Add(input[i]);
            }

            // loop through the letter from string
            for (int i = 0; i < input.Length; i++)
            {
                int Count = 0;

                // loop through the list of letters
                for (int j = 0; j < fullLetters.Count; j++)
                {
                    // compair the letter from each list and keep count
                    if(input[i] == fullLetters[j])
                    {
                        Count++;
                    }
                }
                // add to list 
                result.Add(Tuple.Create(input[i], Count));
                Count = 0;
            }
            
            // remove doubles from list
            result = result.Distinct().ToList();

            return result;
        }

        // main
        static public void Main(String[] args)
        {
            List<Tuple<char, int>> a = OrderedCount("abracadabra");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("\n\n");

            List<Tuple<char, int>> b = OrderedCount("Code Wars");
            for (int i = 0; i < b.Count; i++)
            {
                Console.WriteLine(b[i]);
            }

        }
    }

    
}
