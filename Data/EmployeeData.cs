using Baitapdoan.Models;
using System;
using System.Collections.Generic;
namespace Baitapdoan.Data
{
    public static class EmployeeData
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee(
                    "Nguyễn Hải Đăng", 
                    "Nam", 
                    new DateTime(1998, 1, 15), 
                    new DateTime(2022, 2, 10), 
                    "IT", 
                    "Lập trình backend"),
                new Employee(
                    "Trần Khánh Linh", 
                    "Nữ", 
                    new DateTime(1999, 4, 20), 
                    new DateTime(2023, 1, 5), 
                    "IT", 
                    "Frontend React"),
                new Employee(
                    "Lê Minh Trí", 
                    "Nam", 
                    new DateTime(1997, 8, 9), 
                    new DateTime(2021, 6, 18), 
                    "IT", 
                    "DevOps"),
                new Employee(
                    "Phạm Thuỳ Dương", 
                    "Nữ", 
                    new DateTime(1996, 12, 30), 
                    new DateTime(2020, 3, 12), 
                    "IT", 
                    "Tester"),
                new Employee(
                    "Đỗ Quang Huy", 
                    "Nam", 
                    new DateTime(1995, 5, 25), 
                    new DateTime(2019, 11, 1), 
                    "IT", 
                    "Team leader"),
                new Employee(
                    "Nguyễn Thị Bích", 
                    "Nữ", 
                    new DateTime(1998, 2, 14), 
                    new DateTime(2022, 5, 21), 
                    "HR", 
                    "Tuyển dụng"),
                new Employee(
                    "Trần Văn Phúc", 
                    "Nam", 
                    new DateTime(1997, 9, 12), 
                    new DateTime(2021, 4, 17), 
                    "HR", 
                    "C&B"),
                new Employee(
                    "Lê Thu Trang", 
                    "Nữ", 
                    new DateTime(1996, 11, 3), 
                    new DateTime(2020, 2, 10), 
                    "HR", 
                    "Đào tạo nội bộ"),
                new Employee(
                    "Phạm Quốc Bảo", 
                    "Nam", 
                    new DateTime(1995, 7, 19), 
                    new DateTime(2019, 8, 22), 
                    "HR", 
                    "HRBP"),
                new Employee(
                    "Võ Mỹ Linh", 
                    "Nữ", 
                    new DateTime(1999, 6, 6), 
                    new DateTime(2023, 3, 15), 
                    "HR", 
                    "Thực tập HR"),
                new Employee(
                    "Nguyễn Thành Nam", 
                    "Nam", 
                    new DateTime(1996, 3, 1), 
                    new DateTime(2020, 9, 9), 
                    "FIN", 
                    "Kế toán tổng hợp"),
                new Employee(
                    "Trần Thị Hạnh", 
                    "Nữ", 
                    new DateTime(1997, 10, 18), 
                    new DateTime(2021, 12, 12), 
                    "FIN", 
                    "Kế toán thuế"),
                new Employee(
                    "Lê Hoàng Phong", 
                    "Nam", 
                    new DateTime(1995, 1, 7), 
                    new DateTime(2019, 7, 7), 
                    "FIN", 
                    "Kiểm soát nội bộ"),
                new Employee(
                    "Phạm Ngọc Mai", 
                    "Nữ", 
                    new DateTime(1998, 8, 28), 
                    new DateTime(2022, 4, 4), 
                    "FIN", 
                    "Phân tích tài chính"),
                new Employee(
                    "Đỗ Minh Quân", 
                    "Nam", 
                    new DateTime(1999, 2, 2), 
                    new DateTime(2023, 6, 1), 
                    "FIN", 
                    "Thực tập tài chính"),
                new Employee(
                    "Nguyễn Thảo Vy", 
                    "Nữ", 
                    new DateTime(1999, 5, 17), 
                    new DateTime(2023, 2, 20), 
                    "MKT", 
                    "Content marketing"),
                new Employee(
                    "Trần Gia Hưng", 
                    "Nam", 
                    new DateTime(1998, 3, 14), 
                    new DateTime(2022, 10, 1), 
                    "MKT", 
                    "Digital Ads"),
                new Employee(
                    "Lê Bảo Ngọc", 
                    "Nữ", 
                    new DateTime(1997, 7, 27), 
                    new DateTime(2021, 5, 5), 
                    "MKT", 
                    "Branding"),
                new Employee(
                    "Phạm Đức Anh", 
                    "Nam", 
                    new DateTime(1996, 9, 11), 
                    new DateTime(2020, 1, 19), 
                    "MKT", 
                    "SEO specialist"),
                new Employee(
                    "Võ Thanh Trúc", 
                    "Nữ", 
                    new DateTime(1995, 12, 12), 
                    new DateTime(2019, 3, 30), 
                    "MKT", 
                    "PR"),
                new Employee(
                    "Nguyễn Quốc Khánh", 
                    "Nam", 
                    new DateTime(1997, 4, 4), 
                    new DateTime(2021, 9, 9), 
                    "OPS", 
                    "Quản lý kho"),
                new Employee(
                    "Trần Thu Hà", 
                    "Nữ", 
                    new DateTime(1998, 6, 6), 
                    new DateTime(2022, 7, 7), 
                    "OPS", 
                    "Điều phối vận hành"),
                new Employee(
                    "Lê Văn Sơn", 
                    "Nam", 
                    new DateTime(1996, 1, 23), 
                    new DateTime(2020, 5, 16), 
                    "OPS", 
                    "Giám sát sản xuất"),
                new Employee(
                    "Phạm Thị Ngân", 
                    "Nữ", 
                    new DateTime(1995, 10, 10), 
                    new DateTime(2019, 12, 12), 
                    "OPS", 
                    "Quản lý chất lượng"),
                new Employee(
                    "Đỗ Tuấn Kiệt", 
                    "Nam", 
                    new DateTime(1999, 8, 8), 
                    new DateTime(2023, 8, 1), 
                    "OPS", 
                    "Nhân viên vận hành"),
                new Employee(
                    "Nguyễn Thị Hồng", 
                    "Nữ", 
                    new DateTime(1998, 11, 11), 
                    new DateTime(2022, 3, 3), 
                    "SAL", 
                    "Sales online"),
                new Employee(
                    "Trần Minh Tuấn", 
                    "Nam", 
                    new DateTime(1997, 2, 20), 
                    new DateTime(2021, 1, 10), 
                    "SAL", 
                    "Sales B2B"),
                new Employee(
                    "Lê Thị Ánh", 
                    "Nữ", 
                    new DateTime(1996, 5, 5), 
                    new DateTime(2020, 6, 6), 
                    "SAL", 
                    "Chăm sóc khách hàng"),
                new Employee(
                    "Phạm Văn Nam", 
                    "Nam", 
                    new DateTime(1995, 9, 9), 
                    new DateTime(2019, 4, 4), 
                    "SAL", 
                    "Trưởng nhóm sales"),
                new Employee(
                    "Võ Ngọc Hân", 
                    "Nữ", 
                    new DateTime(1999, 7, 7), 
                    new DateTime(2023, 5, 5), 
                    "SAL", 
                    "Telesales")
            };
        }
    }
}