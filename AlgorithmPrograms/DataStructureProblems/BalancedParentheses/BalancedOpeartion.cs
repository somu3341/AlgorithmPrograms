using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProblems.BalancedParentheses
{
    public class BalancedOpeartion
    {
        public void ReadFile(string filepath)
        {
            LinkedListStack<String> list = new LinkedListStack<String>();
            string readData = File.ReadAllText(filepath);
            string[] words = readData.Split(" ");
            foreach (var data in words)
            {
                if (data.Equals('('))
                    list.Push(data);
                if (data.Equals(')'))
                    list.Pop();
            }
            list.Peek();
        }
    }
}
