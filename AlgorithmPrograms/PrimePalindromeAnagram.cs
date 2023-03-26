using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimePalindromeAnagram
    {
        public void ChekPrime()
        {
            Console.WriteLine("Enter lower limit");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Higher Limit");
            int upper = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[300];
            int flag = 0;
            int k = 0;
            for (int i = lower; i <= upper; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                    flag = 0;
                }
                if (flag == 0 && i != 0 && i != 1)
                {
                    arr[k] = i;
                    k++;
                    if (i != 2 && i != 3 && i != 5 && i != 7)
                        //Console.WriteLine(i);
                    CheckPalindrome(i);
                }               
            }
            CheckAnagram(arr, k);
            
        }
        public void CheckAnagram(int[] arr, int k)
        {
            for (int i = 0; i < k; i++)
            {

                for (int j = i + 1; j < k; j++)
                {
                    string name1 = arr[i].ToString();
                    string name2 = arr[j].ToString();
                    char[] result1 = name1.ToCharArray();
                    Array.Sort(result1);
                    char[] result2 = name2.ToCharArray();
                    Array.Sort(result2);
                    name1 = new String(result1);
                    name2 = new String(result2);
                    if (name1.Equals(name2))
                    {
                        Console.WriteLine(arr[i] + "  " + arr[j] + " are anagram");
                    }
                    else
                        Console.WriteLine("Anagram Not found");

                }
            }

        }
        public void CheckPalindrome(int Number)
        {
            string no1 = Number.ToString();
            char[] result1 = no1.ToCharArray();
            Array.Reverse(result1);
            no1 = new String(result1);
            int reverse = Convert.ToInt32(no1);
            if (reverse == Number)
            {
                Console.WriteLine(Number + " Number is Palindrome");
            }
            else
                Console.WriteLine("Palindrome Numbers Not Found");

        }
    }
}
