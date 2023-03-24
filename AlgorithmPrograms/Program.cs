using AlgorithmPrograms.BinarySearch;
using System;
namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryWrodSearch search = new BinaryWrodSearch();
            search.ReadFile(@"D:\BridgeLabs\AlgorithmPrograms\AlgorithmPrograms\BinarySearch\File.txt");
        }
    }
}