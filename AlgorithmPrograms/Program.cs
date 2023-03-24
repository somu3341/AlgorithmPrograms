using AlgorithmPrograms.BinarySearch;
using AlgorithmPrograms.InsertionSort;
using System;
namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose Option to perform\n1.Binary Search for Word \n2.Insertion Sort \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        BinaryWrodSearch search = new BinaryWrodSearch();
                        search.ReadFile(@"D:\BridgeLabs\AlgorithmPrograms\AlgorithmPrograms\BinarySearch\File.txt");
                        break;
                        case 2:
                        InserationSorting sorting = new InserationSorting();
                        sorting.ReadFile(@"D:\BridgeLabs\AlgorithmPrograms\AlgorithmPrograms\BinarySearch\File.txt");
                        break;
                        case 3:
                        flag = false;
                        break;
                }
            }
            
        }
    }
}