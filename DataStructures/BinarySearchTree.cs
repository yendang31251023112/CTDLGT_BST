using EmployeeBST.Models;
using System;
using System.Collections.Generic;
namespace EmployeeBST.DataStructures
{
        public class BinarySearch
        {
            public Node Root { get; set; }

            public BinarySearch()
            {
                Root = null;
            }

            //thêm nhân viên mới
            public bool Insert(Employee emp)
            {
                Node newNode = new Node(emp);

                if (Root == null)
                {
                    Root = newNode;
                    return true;
                }

                Node current = Root;
                Node parent = null;

                while (current != null)
                {
                    parent = current;

                    if (emp.NgayVaoLam <= current.Data.NgayVaoLam)
                        current = current.Left;
                    else
                        current = current.Right;
                }

                if (emp.NgayVaoLam <= parent.Data.NgayVaoLam)
                    parent.Left = newNode;
                else
                    parent.Right = newNode;

                return true;
            }

            //tìm theo tên
            public List<Employee> FindByName(string name)
            {
                List<Employee> result = new List<Employee>();
                SearchName(Root, name, result);
                return result;
            }
            private void SearchName(Node node, string name, List<Employee> result)
            {
                if (node == null) return;

                SearchName(node.Left, name, result);

                if (node.Data.TenNhanVien.ToLower().Contains(name.ToLower()))
                    result.Add(node.Data);

                SearchName(node.Right, name, result);
            }

            //tìm theo mã nhân viên
            public Employee FindByID(string id)
            {
                return SearchByID(Root, id);
            }
            private Employee SearchByID(Node node, string id)
            {
                if (node == null) return null;

                if (node.Data.MaNhanVien == id)
                    return node.Data;

                Employee leftResult = SearchByID(node.Left, id);
                if (leftResult != null)
                    return leftResult;

                return SearchByID(node.Right, id);
            }
            
            //tìm theo ngày cụ thể vào làm
            public List<Employee> FindByDate(DateTime targetDate)
            {
                List<Employee> result = new List<Employee>();
                SearchByDate(Root, targetDate, result);
                return result;
            }
            private void SearchByDate(Node node, DateTime targetDate, List<Employee> result)
            {
                if (node == null) return;

                DateTime date = node.Data.NgayVaoLam;

                if (targetDate < date)
                    SearchByDate(node.Left, targetDate, result);
                else if (targetDate > date)
                    SearchByDate(node.Right, targetDate, result);
                else
                {
                    result.Add(node.Data);
                    SearchByDate(node.Left, targetDate, result);
                }
            }

            //tìm theo khoảng thời gian vào làm
            public List<Employee> FindByDateRange(DateTime start, DateTime end)
            {
                List<Employee> result = new List<Employee>();
                SearchDateRange(Root, start, end, result);
                return result;
            }
            private void SearchDateRange(Node node, DateTime start, DateTime end, List<Employee> result)
            {
                if (node == null) return;

                DateTime date = node.Data.NgayVaoLam;

                if (date >= start)
                    SearchDateRange(node.Left, start, end, result);

                if (date >= start && date <= end)
                    result.Add(node.Data);

                if (date < end)
                    SearchDateRange(node.Right, start, end, result);
            }

            //sắp xếp theo bộ phận
            public List<Employee> SortByDepartment()
            {
                List<Employee> list = GetAllAscending();

                // Insertion Sort theo bộ phận (nếu trùng thì theo ngày vào làm)
                for (int i = 1; i < list.Count; i++)
                {
                    Employee key = list[i];
                    int j = i - 1;

                    while (j >= 0 && CompareEmployee(list[j], key) > 0)
                    {
                        list[j + 1] = list[j];
                        j--;
                    }
                    list[j + 1] = key;
                }

                return list;
            }
            private int CompareEmployee(Employee a, Employee b)
            {
                int deptCompare = a.BoPhan.CompareTo(b.BoPhan);

                if (deptCompare == 0)
                    return a.NgayVaoLam.CompareTo(b.NgayVaoLam);

                return deptCompare;
            }

            //đếm tổng số nhân viên
            public int Count()
            {
                return Count(Root);
            }
            private int Count(Node node)
            {
                if (node == null)
                    return 0;
                return 1 + Count(node.Left) + Count(node.Right);
            }

            //Tìm NV cũ nhất (bên trái)
            public Employee GetOldest()
            {
                if (Root == null)
                    return null;

                Node current = Root;
                while (current.Left != null) current = current.Left;
                return current.Data;
            }

            //tìm nv mới nhất (bên phải)
            public Employee GetNewest()
            {
                if (Root == null)
                    return null;

                Node current = Root;
                while (current.Right != null) current = current.Right;
                return current.Data;
            }

            //lấy toàn bộ danh sách tăng dần theo date vào làm
            public List<Employee> GetAllAscending()
            {
                List<Employee> result = new List<Employee>();
                GetAllAscending(Root, result);
                return result;
            }
            public void GetAllAscending(Node node, List<Employee> list)
            {
                if (node == null) return;

                GetAllAscending(node.Left, list);
                list.Add(node.Data);
                GetAllAscending(node.Right, list);
            }

            //lấy toàn bộ danh sách giảm dần theo date vào làm
            public List<Employee> GetAllDescending()
            {
                List<Employee> result = new List<Employee>();
                GetAllDescending(Root, result);
                return result;
            }
            public void GetAllDescending(Node node, List<Employee> list)
            {
                if (node == null) return;

                GetAllDescending(node.Right, list);
                list.Add(node.Data);
                GetAllDescending(node.Left, list);
            }

            //Cập nhật thông tin nhân viên theo mã nhân viên
            public bool Update(string maNV,
                string tenMoi = null,
                string boPhanMoi = null,
                DateTime? ngaySinhMoi = null,
                DateTime? ngayVaoLamMoi = null)
            {
                Node nvCanSua = FindByID(Root, maNV);
                if (nvCanSua == null) return false;

                if (tenMoi != null)
                    nvCanSua.Data.TenNhanVien = tenMoi;

                if (boPhanMoi != null)
                    nvCanSua.Data.BoPhan = boPhanMoi;

                if (ngaySinhMoi != null)
                    nvCanSua.Data.NgaySinh = ngaySinhMoi.Value;

                if (ngayVaoLamMoi != null)
                {
                    Employee temp = nvCanSua.Data;
                    DeleteByID(maNV);
                    temp.NgayVaoLam = ngayVaoLamMoi.Value;
                    Insert(temp);
                }

                return true;
            }

            //tìm theo mã nhân viên
            private Node FindByID(Node root, string id)
            {
                if (root == null) return null;
                if (root.Data.MaNhanVien == id) return root;

                Node res = FindByID(root.Left, id);
                if (res != null) return res;

                return FindByID(root.Right, id);
            }

            //xoá đệ quy
            private Node DeleteRecursive(Node root, DateTime date)
            {
                if (root == null) return null;

                if (date < root.Data.NgayVaoLam)
                    root.Left = DeleteRecursive(root.Left, date);
                else if (date > root.Data.NgayVaoLam)
                    root.Right = DeleteRecursive(root.Right, date);
                else
                {
                    if (root.Left == null) return root.Right;
                    if (root.Right == null) return root.Left;

                    Node temp = root.Right;
                    while (temp.Left != null) temp = temp.Left;

                    root.Data = temp.Data;
                    root.Right = DeleteRecursive(root.Right, temp.Data.NgayVaoLam);
                }

                return root;
            }

            //xóa nhân viên theo ngày vào làm
            private void DeleteByDate(DateTime date)
            {
                Root = DeleteRecursive(Root, date);
            }
            public void DeleteAllByDate(DateTime date)
            {
                while (FindByDate(date).Count > 0)
                    DeleteByDate(date);
            }

            //xóa nhân viên theo mã nhân viên
            public void DeleteByID(string id)
            {
                Root = DeleteByIDRecursive(Root, id);
            }
            private Node DeleteByIDRecursive(Node root, string id)
            {
                if (root == null) return null;

                if (root.Data.MaNhanVien == id)
                {
                    if (root.Left == null) return root.Right;
                    if (root.Right == null) return root.Left;

                    Node temp = root.Right;
                    while (temp.Left != null) temp = temp.Left;

                    root.Data = temp.Data;
                    root.Right = DeleteRecursive(root.Right, temp.Data.NgayVaoLam);
                    return root;
                }

                root.Left = DeleteByIDRecursive(root.Left, id);
                root.Right = DeleteByIDRecursive(root.Right, id);
                return root;
            }
    }
}
