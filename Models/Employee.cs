using System;
using System.Collections.Generic;
using Baitapdoan.DataStructures;
namespace Baitapdoan.Models
{
    public class Employee
    {
        private static DeptCounterList deptCounter = new DeptCounterList();
        public string MaNhanVien { get; private set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string BoPhan { get; set; }
        public string GhiChu { get; set; }

        public Employee(string name, string gender, DateTime birth, DateTime start, string dept, string note)
        {
            MaNhanVien = GenerateID(dept);
            TenNhanVien = name;
            GioiTinh = gender;
            NgaySinh = birth;
            NgayVaoLam = start;
            BoPhan = dept;
            GhiChu = note;
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
