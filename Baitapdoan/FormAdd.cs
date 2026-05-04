using Baitapdoan.DataStructures;
using Baitapdoan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitapdoan
{
    public partial class FormAdd : Form
    {
        private BinarySearch _bstNhanViec;
        // Tạo 1 biến để nhớ xem mình đang sửa ai. Trống nghĩa là đang THÊM MỚI.
        private string idCanSua = "";
        public FormAdd()
        {
            InitializeComponent();
        }
        public FormAdd(BinarySearch bstTruyenSang) : this()
        {
            this._bstNhanViec = bstTruyenSang;
            this.Text = "Thêm Mới Hồ Sơ";
        }
        public FormAdd(BinarySearch bstTruyenSang, string idSua) : this()
        {
            this._bstNhanViec = bstTruyenSang;
            this.idCanSua = idSua; // Bỏ ID vào túi để nhớ
            this.Text = "Cập Nhật Hồ Sơ"; // Đổi tiêu đề Form cho ngầu
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idCanSua))
            {
                var nv = _bstNhanViec.FindByID(idCanSua); // Trích xuất hồ sơ
                if (nv != null)
                {
                    // Bơm dữ liệu cũ lên giao diện
                    txtTenNhanVien.Text = nv.TenNhanVien;
                    txtBoPhan.Text = nv.BoPhan;
                    cbGioiTinh.Text = nv.GioiTinh;
                    dtpNgaySinh.Value = nv.NgaySinh;
                    dtpNgayVaoLam.Value = nv.NgayVaoLam;
                    txtGhiChu.Text = nv.GhiChu;

                    // LỆNH KỶ LUẬT: KHÓA CHẾT Ô NGÀY VÀO LÀM! (Không cho bấm sửa)
                    dtpNgayVaoLam.Enabled = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
            {
                MessageBox.Show("Chưa nhập tên mà đòi lưu? Gồng lại ngay!", "Chấn chỉnh");
                return;
            }

            // CHẾ ĐỘ 1: THÊM MỚI
            if (string.IsNullOrEmpty(idCanSua))
            {
                // Gọi phễu đúc Employee (Kiểm tra lại thứ tự các biến trong ngoặc cho khớp với file Employee.cs của nhóm ông nhé)
                Employee nvMoi = new Employee(
                    txtTenNhanVien.Text,
                    cbGioiTinh.Text,
                    dtpNgaySinh.Value,
                    dtpNgayVaoLam.Value,
                    txtBoPhan.Text,
                    txtGhiChu.Text
                );

                _bstNhanViec.Insert(nvMoi); // Bơm tạ vào cây
                MessageBox.Show("Đã thêm hồ sơ mới thành công!", "Thông báo");
            }
            // CHẾ ĐỘ 2: CẬP NHẬT (SỬA)
            else
            {
                var nvCu = _bstNhanViec.FindByID(idCanSua);
                if (nvCu != null)
                {
                    // 1. TỰ TAY CẬP NHẬT TRỰC TIẾP LÊN BẢN GỐC!
                    // (Cứ gán thẳng tay, dữ liệu tự chui vào Node trong Cây mà không làm gãy cây)
                    nvCu.TenNhanVien = txtTenNhanVien.Text;
                    nvCu.BoPhan = txtBoPhan.Text;
                    nvCu.GioiTinh = cbGioiTinh.Text;
                    nvCu.NgaySinh = dtpNgaySinh.Value;
                    nvCu.GhiChu = txtGhiChu.Text;

                    // 2. KỸ THUẬT XỬ LÝ XƯƠNG SỐNG (NGÀY VÀO LÀM)
                    if (nvCu.NgayVaoLam.Date != dtpNgayVaoLam.Value.Date)
                    {
                        // Mượn hàm Update của bà Yến để Rút xương - Thay máu - Ghép lại.
                        // Hàm của bả có 5 cổng: (Mã, Tên, Bộ Phận, Ngày Sinh, Ngày Vào Làm)
                        // Mình chỉ cần đưa Mã và Ngày Vào Làm mới vào. Các cổng kia để null bả sẽ tự lướt qua!
                        _bstNhanViec.Update(idCanSua, null, null, null, dtpNgayVaoLam.Value);
                    }

                    MessageBox.Show("Đã cập nhật hồ sơ nét căng! Cây không lệch một ly!", "Nắn khớp xong");
                }
                else
                {
                    MessageBox.Show("Lỗi! Không tìm thấy dữ liệu gốc để sửa!", "Chấn chỉnh");
                }
            }
            this.Close();
        }
    }
}
