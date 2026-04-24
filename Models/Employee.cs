using System;
using System.Collections.Generic;
using BSTProject.DataStructures;
namespace BSTProject.Models
{
    public class Employee
    {
        private static DeptCounterList deptCounter = new DeptCounterList();
        public string MaNhanVien { get; private set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string BoPhan { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string Ghichu { get; set; }

        public Employee(string name, string dept, DateTime birth, DateTime start, string gioiTinh, string gc)
        {
            MaNhanVien = GenerateID(dept);
            TenNhanVien = name;
            BoPhan = dept;
            NgaySinh = birth;
            NgayVaoLam = start;
            GioiTinh = gioiTinh;
            Ghichu = gc;
        }

        private string GenerateID(string dept)
        {
            string prefix = dept.Length >= 2
                ? dept.Substring(0, 2).ToUpper()
                : dept.ToUpper();

            int number = deptCounter.GetNextNumber(prefix);

            return prefix + number.ToString("D3");
        }
    }
}
