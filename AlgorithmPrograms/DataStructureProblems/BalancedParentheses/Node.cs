﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProblems.BalancedParentheses
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T value)
        {
            this.data = value;
        }
    }
}
