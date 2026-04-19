using EmployeeBST.Models;
using System;
using System.Collections.Generic;
public class Node
        {
            public Employee Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(Employee emp)
            {
                Data = emp;
                Left = null;
                Right = null;
            }
        }