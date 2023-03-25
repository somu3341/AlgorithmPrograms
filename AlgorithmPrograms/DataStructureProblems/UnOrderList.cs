using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProblems
{
    public class UnOrderList
    {
        public void ReadFile(string filepath)
        {
            LinkedList<string> list = new LinkedList<string>();
            string readData = File.ReadAllText(filepath);
            string[] words = readData.Split(" ");
            foreach (var data in words)
            {
                list.Add(data);
            }
            string input = Console.ReadLine();
            int result = list.Search(input);
            if (result != -1)
            {
                Console.WriteLine("Found");
                list.DeleteNodeAtParticularPosition(result);
            }
            else
            {
                list.Add(input);
            }
            list.Display();
        }
    }
}
