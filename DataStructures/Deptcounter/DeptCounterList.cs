using System;
using System.Collections.Generic;
namespace BSTProject.DataStructures
{
    public class DeptCounterList
    {
        private DeptCounterNode head;
        public int GetNextNumber(string prefix)
        {
            // nếu list rỗng thì tạo node đầu tiên
            if (head == null)
            {
                head = new DeptCounterNode(prefix);
                head.Count++;          
                return head.Count;     
            }

            DeptCounterNode current = head;

            // tìm bộ phận đã tồn tại chưa
            while (current != null)
            {
                if (current.Prefix == prefix)
                {
                    current.Count++;        
                    return current.Count;   
                }

                // tới node cuối mà chưa thấy thì tạo mới
                if (current.Next == null)
                    break;

                current = current.Next;
            }

            // thêm bộ phận mới vào cuối list
            current.Next = new DeptCounterNode(prefix);
            current.Next.Count++;
            return current.Next.Count;
        }
    }
}