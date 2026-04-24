using BSTProject.Models;
using System;
using System.Collections.Generic;
namespace BSTProject.DataStructures
{
    public class DeptCounterList
    {
        private DeptCounterNode head;
        public int GetNextNumber(string prefix)
        {
            // nếu list rỗng → tạo node đầu tiên
            if (head == null)
            {
                head = new DeptCounterNode(prefix);
                return 1;
            }

            DeptCounterNode current = head;

            // tìm bộ phận đã tồn tại chưa
            while (current != null)
            {
                if (current.Prefix == prefix)
                {
                    int number = current.Count;
                    current.Count++;
                    return number;
                }

                // tới node cuối mà chưa thấy → tạo mới
                if (current.Next == null)
                    break;

                current = current.Next;
            }

            // thêm bộ phận mới vào cuối list
            current.Next = new DeptCounterNode(prefix);
            return 1;
        }
    }
}