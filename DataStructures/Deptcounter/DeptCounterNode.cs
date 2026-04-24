using BSTProject.Models;
using System;
using System.Collections.Generic;
namespace BSTProject.DataStructures
{
    public class DeptCounterNode
    {
        public string Prefix;
        public int Count;
        public DeptCounterNode Next;

        public DeptCounterNode(string prefix)
        {
            Prefix = prefix;
            Count = 1;
            Next = null;
        }
    }
}