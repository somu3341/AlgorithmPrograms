using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.BinarySearch
{
    public class BinaryWrodSearch
    {
        public void ReadFile(string filepath)
        {
            string readData =File.ReadAllText(filepath);
            string[] words = readData.Split(" ");
            foreach (var data in words)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Enter word to search");
            string search = Console.ReadLine();
            foreach (var data in words)
            {
                if (data.Equals(search))
                {
                    Console.WriteLine("Found");
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }
    }
}
