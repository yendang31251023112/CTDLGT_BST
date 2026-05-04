using Baitapdoan.DataStructures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baitapdoan.Models;
using Baitapdoan.Data;

namespace Baitapdoan
{
    public partial class FormMain : Form
    {
        public BinarySearch bst = new BinarySearch();

        public FormMain()
        {
            InitializeComponent();
            // Lấy nguyên (nhân viên) từ kho ra
            List<Employee> danhSachMau = EmployeeData.GetEmployees();

            // Bơm từng người một vào BST của ông
            foreach (Employee emp in danhSachMau)
            {
                bst.Insert(emp);
            }
            LoadBang();
        }

        void LoadBang()
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = bst.GetAllAscending();
            lblTong.Text = "Tổng số nhân viên: " + bst.Count().ToString();
        }

        

        // NÚT SỬA
        

        // NÚT XÓA 
        

        // NÚT TÌM KIẾM
        

        // NÚT LÀM MỚI
        

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "Nhập tên muốn tìm kiếm...")
            {
                txtTuKhoa.Text = "";
                txtTuKhoa.ForeColor = Color.Black;
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string kieu = cbKieuTimKiem.Text;
            string tuKhoa = txtTuKhoa.Text.Trim();
            bool checkTuKhoaRong = (tuKhoa == "Nhập tên muốn tìm kiếm..." || string.IsNullOrWhiteSpace(tuKhoa));

            
            dgvNhanVien.DataSource = null;

            switch (kieu)
            {
                case "Theo Tên":
                    if (checkTuKhoaRong)
                    {
                        MessageBox.Show("Vui lòng nhập tên cần tìm", "Chấn chỉnh");
                        LoadBang();
                        return;
                    }
                    dgvNhanVien.DataSource = bst.FindByName(tuKhoa);
                    break;

                case "Theo Mã NV":
                    if (checkTuKhoaRong)
                    {
                        MessageBox.Show("Vui lòng nhập mã nhân viên cần tìm", "Chấn chỉnh");
                        LoadBang();
                        return;
                    }
                    Employee empID = bst.FindByID(tuKhoa.ToUpper());
                    if (empID != null)
                        dgvNhanVien.DataSource = new List<Employee> { empID }; // Phải bọc vào List thì DataGridView mới chịu nhận
                    else
                        MessageBox.Show("Mã này không tồn tại trong hệ thống!", "Báo cáo");
                    break;

                case "Theo Ngày Cụ Thể":
                   
                    DateTime ngayTim = dtpTimNgay.Value.Date;
                    List<Employee> kqDate = bst.FindByDate(ngayTim);

                    if (kqDate.Count > 0)
                        dgvNhanVien.DataSource = kqDate;
                    else
                    {
                        MessageBox.Show($"Không có ai vào làm ngày {ngayTim:dd/MM/yyyy}", "Thông báo");
                        LoadBang(); // Không có ai thì trả lại bảng đầy đủ
                    }
                    break;

                case "Nhân Viên Cũ Nhất":
                    Employee oldest = bst.GetOldest();
                    if (oldest != null)
                        dgvNhanVien.DataSource = new List<Employee> { oldest };
                    else
                        MessageBox.Show("Hệ thống đang chưa có ai!", "Thông báo");
                    break;

                case "Nhân Viên Mới Nhất":
                    Employee newest = bst.GetNewest();
                    if (newest != null)
                        dgvNhanVien.DataSource = new List<Employee> { newest };
                    else
                        MessageBox.Show("Hệ thống đang chưa có ai!", "Thông báo");
                    break;

                case "Theo Khoảng Ngày":
                    MessageBox.Show("Mục này ông phải bấm trực tiếp từ menu xổ xuống để nó bật cái Lịch lên!", "Nhắc nhở");
                    LoadBang();
                    break;

                default:
                    MessageBox.Show("Vui lòng chọn kiểu tìm kiếm trong hộp xổ xuống!", "Nhắc nhở");
                    LoadBang();
                    break;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormAdd frmThem = new FormAdd(this.bst);
            frmThem.ShowDialog();
            LoadBang();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trong bảng!", "Nhắc nhở");
                return;
            }

            // Lấy Mã NV từ dòng đang chọn để truyền sang Form Sửa
            string idCanSua = dgvNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();

            FormAdd frmSua = new FormAdd(this.bst, idCanSua);
            frmSua.ShowDialog();
            LoadBang();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            // Cảnh cáo nếu chưa chọn kiểu xóa
            if (string.IsNullOrWhiteSpace(cbKieuXoa.Text))
            {
                MessageBox.Show("Vui lòng chọn kiểu muốn xóa", "Chấn chỉnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (cbKieuXoa.Text == "Xóa Theo Mã NV")
            {
                if (dgvNhanVien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một người trên bảng để lấy ID xóa", "Chấn chỉnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idCanXoa = dgvNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                string tenCanXoa = dgvNhanVien.CurrentRow.Cells["TenNhanVien"].Value.ToString();

                if (MessageBox.Show($"Chắc chắn muốn loại bỏ: {tenCanXoa} (Mã: {idCanXoa})?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    bst.DeleteByID(idCanXoa);
                    LoadBang();
                    MessageBox.Show("Đã xóa thành công!", "Báo cáo");
                }
            }
           
            else if (cbKieuXoa.Text == "Xóa Theo Ngày")
            {
                DateTime ngayCanXoa = dtpNgayXoa.Value.Date;
                List<Employee> dsBiXoa = bst.FindByDate(ngayCanXoa);

                if (dsBiXoa.Count == 0)
                {
                    MessageBox.Show($"Không có ai vào làm ngày {ngayCanXoa:dd/MM/yyyy}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show($"BÁO ĐỘNG ĐỎ: Chắc chắn muốn xóa SẠCH {dsBiXoa.Count} nhân viên vào làm ngày {ngayCanXoa:dd/MM/yyyy} chứ?",
                    "Xác nhận thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bst.DeleteAllByDate(ngayCanXoa);
                    LoadBang();
                    MessageBox.Show("Xóa hoàn tất!", "Báo cáo");
                }
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            LoadBang();
        }

        

        private void txtTuKhoa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTuKhoa.Text))
            {
                txtTuKhoa.Text = "Nhập tên muốn tìm kiếm...";
                txtTuKhoa.ForeColor = Color.Gray; // Chữ xám mờ
            }
        }

        private void cbKieuTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbKieuTimKiem.Text == "Theo Khoảng Ngày")
            {
                txtTuKhoa.Enabled = false;
                dtpTimNgay.Visible = false; // Giấu lịch đơn

                frmLich formChonNgay = new frmLich();
                formChonNgay.ShowDialog();

                if (formChonNgay.DaChonXong == true)
                {
                    DateTime tuNgay = formChonNgay.TuNgay;
                    DateTime denNgay = formChonNgay.DenNgay;
                    List<Employee> ketQua = bst.FindByDateRange(tuNgay, denNgay);
                    dgvNhanVien.DataSource = null;
                    if (ketQua.Count > 0) dgvNhanVien.DataSource = ketQua;
                    else MessageBox.Show("Không có ai vào làm trong khoảng thời gian này!");
                }
            }
            
            else if (cbKieuTimKiem.Text == "Theo Ngày Cụ Thể")
            {
                txtTuKhoa.Visible = false; 
                dtpTimNgay.Visible = true; // Hiện bộ lịch lên
            }
            
            else
            {
                txtTuKhoa.Visible = true;  // Trả lại ô chữ
                txtTuKhoa.Enabled = true;
                dtpTimNgay.Visible = false; // Giấu lịch đi
            }
        }

        

        

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (cbKieuSapXep.Text == "Theo Tên")
            {
                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = bst.SortByName();
            }
            else if (cbKieuSapXep.Text == "Theo Bộ Phận")
            {
                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = bst.SortByDepartment();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu sắp xếp!", "Nhắc nhở");
            }
        }

        

       

        private void cbKieuXoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbKieuXoa.Text == "Xóa Theo Ngày")
            {
                dtpNgayXoa.Visible = true;
            }
            
            else
            {
                dtpNgayXoa.Visible = false;
            }
        }
    }
}
