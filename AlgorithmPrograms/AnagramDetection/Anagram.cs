using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.AnagramDetection
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter word to check Anagram");
            string word1=Convert.ToString(Console.ReadLine());
            string word2=Convert.ToString(Console.ReadLine());
            if (word1.Length != word2.Length)
            {
                Console.WriteLine("Given word is not a Anagram");
            }
            else
            {
                char[] result1 = word1.ToCharArray();
                Array.Sort(result1);
                word1 = new string(result1);
                char[] result2 = word2.ToCharArray();
                Array.Sort(result2);
                word2 = new string(result2);
                if (word1.Equals(word2))
                    Console.WriteLine("It is a Anagram");
                else
                    Console.WriteLine("It is not a Anagram");
            }
        }
    }
}
