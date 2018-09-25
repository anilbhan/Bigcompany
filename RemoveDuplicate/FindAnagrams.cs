using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicate
{
          class FindAnagrams
        {
            static void Main(string[] args)
            {
                //Receive Words from User  
                Console.Write("Enter first word:");
                string word1 = Console.ReadLine();
                Console.Write("Enter second word:");
                string word2 = Console.ReadLine();

                //Add optional validation of input words if needed.  
                //.....  

                //step 1  
                char[] char1 = word1.ToLower().ToCharArray();
                char[] char2 = word2.ToLower().ToCharArray();

                //Step 2  
                Array.Sort(char1);
                Array.Sort(char2);

                //Step 3  
                string NewWord1 = new string(char1);
                string NewWord2 = new string(char2);

                //Step 4  
                //ToLower allows to compare the words in same case, in this case, lower case.  
                //ToUpper will also do exact same thing in this context  
                if (NewWord1 == NewWord2)
                {
                    Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
                }
                else
                {
                    Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
                }

                //Hold Console screen alive to view the results.  
                Console.ReadLine();
            }
        }
    }



/* 

 1. Convert both strings to character arrays.
2. Sort the character arrays in ascending/descending order, but use the same ordering on both of the character sets.
3. Create two strings out of the two sorted character set arrays.
4. Compare the strings.
5. If they are not equal, they are not Anagrams.   
    */
