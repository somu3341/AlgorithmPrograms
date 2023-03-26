using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmPrograms.DataStructureProblems.BalancedParentheses
{
    public class LinkedListStack<T>
    {
        private Node<T> top;
        Node<T> head = null;
        public LinkedListStack()
        {
            this.top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public void Dsiplay()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty,Deletion is not possible");
                return;
            }
            Console.WriteLine("value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        public int Size()
        {
            Node<T> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                count++;
            }
            return count;
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty,Deleltion is not Possible");
                return;
            }
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine("value Dequeue is {0}", this.head.data);
                    this.head = this.head.next;
                }
            }
        }
    }
}
