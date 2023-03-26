using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProblems.BankingCashCounter
{
    public class BankingOpeartion
    {
        LinkedListQueue<string> queue = new LinkedListQueue<string>();
        int amount = 1000;
        public BankingOpeartion()
        {
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Display();
        }
        public void Opeartion()
        {
            int count = queue.Size();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enetr an option to operate \n1.Withdraw \n2.Deposit \n3.CheckBalance");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        WithDraw();
                        break;
                        case 2:
                        Deposit();
                        break;
                        case 3:
                        CheckBalance();
                        break;                       
                }
                queue.Dequeue();
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine(amount);
        }
        public void WithDraw()
        {
            Console.WriteLine("Enter amount to with draw");
            int withdraw=Convert.ToInt32(Console.ReadLine());
            if (amount >= withdraw)
                amount -= withdraw;
            else
                Console.WriteLine("Insufficient Balance, Please try after some time");
        }
        public void Deposit()
        {
            Console.WriteLine("Enter amount to Deposit");
            int deposit=Convert.ToInt32(Console.ReadLine());
            amount += deposit;
        }
    }
}
