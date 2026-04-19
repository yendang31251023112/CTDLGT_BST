using System;
using System.Collections.Generic;
namespace EmployeeBST.Models
{
    public class Employee
    {
        private static Dictionary<string, int> deptCounter = new Dictionary<string, int>();
        public string MaNhanVien { get; private set; }
        public string TenNhanVien { get; set; }
        public string BoPhan { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayVaoLam { get; set; }

        public Employee(string name, string dept, DateTime birth, DateTime start)
        {
            MaNhanVien = GenerateID(dept);
            TenNhanVien = name;
            BoPhan = dept;
            NgaySinh = birth;
            NgayVaoLam = start;
        }
        
        //tự động cập nhật mã nhân viên
        private string GenerateID(string dept)
        {
            string prefix = dept.Length >= 2
                            ? dept.Substring(0, 2).ToUpper()
                            : dept.ToUpper();

            if (!deptCounter.ContainsKey(prefix))
                deptCounter[prefix] = 1;

            string number = deptCounter[prefix].ToString("D3");
            deptCounter[prefix]++;

            return prefix + number;
        }
    }
}