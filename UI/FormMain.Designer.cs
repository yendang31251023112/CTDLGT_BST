namespace Baitapdoan
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpNgayXoa = new DateTimePicker();
            cbKieuXoa = new ComboBox();
            dtpTimNgay = new DateTimePicker();
            btnLamMoi = new Button();
            btnSua = new Button();
            txtTuKhoa = new TextBox();
            cbKieuTimKiem = new ComboBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            label4 = new Label();
            btnSapXep = new Button();
            cbKieuSapXep = new ComboBox();
            lblTong = new Label();
            dgvNhanVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(lblTong);
            splitContainer1.Panel2.Controls.Add(dgvNhanVien);
            splitContainer1.Size = new Size(1061, 657);
            splitContainer1.SplitterDistance = 235;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer2.Panel1.BackgroundImage");
            splitContainer2.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(dtpNgayXoa);
            splitContainer2.Panel1.Controls.Add(cbKieuXoa);
            splitContainer2.Panel1.Controls.Add(dtpTimNgay);
            splitContainer2.Panel1.Controls.Add(btnLamMoi);
            splitContainer2.Panel1.Controls.Add(btnSua);
            splitContainer2.Panel1.Controls.Add(txtTuKhoa);
            splitContainer2.Panel1.Controls.Add(cbKieuTimKiem);
            splitContainer2.Panel1.Controls.Add(btnThem);
            splitContainer2.Panel1.Controls.Add(btnXoa);
            splitContainer2.Panel1.Controls.Add(btnTimKiem);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer2.Panel2.BackgroundImage");
            splitContainer2.Panel2.Controls.Add(label4);
            splitContainer2.Panel2.Controls.Add(btnSapXep);
            splitContainer2.Panel2.Controls.Add(cbKieuSapXep);
            splitContainer2.Size = new Size(1061, 235);
            splitContainer2.SplitterDistance = 853;
            splitContainer2.TabIndex = 7;
            // 
            // label3
            // 
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Times New Roman", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(660, 30);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 12;
            label3.Text = "CHỌN KIỂU XÓA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Times New Roman", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(421, 30);
            label2.Name = "label2";
            label2.Size = new Size(191, 30);
            label2.TabIndex = 11;
            label2.Text = "CHỌN KIỂU TÌM KIẾM";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Times New Roman", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(377, 30);
            label1.TabIndex = 10;
            label1.Text = "HÃY NHẬP THÔNG TIN BẠN MUỐN TÌM KIẾM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpNgayXoa
            // 
            dtpNgayXoa.Format = DateTimePickerFormat.Short;
            dtpNgayXoa.Location = new Point(660, 95);
            dtpNgayXoa.Name = "dtpNgayXoa";
            dtpNgayXoa.Size = new Size(146, 31);
            dtpNgayXoa.TabIndex = 9;
            dtpNgayXoa.Visible = false;
            // 
            // cbKieuXoa
            // 
            cbKieuXoa.FormattingEnabled = true;
            cbKieuXoa.Items.AddRange(new object[] { "Xóa Theo Mã NV", "Xóa Theo Ngày" });
            cbKieuXoa.Location = new Point(660, 59);
            cbKieuXoa.Name = "cbKieuXoa";
            cbKieuXoa.Size = new Size(146, 33);
            cbKieuXoa.TabIndex = 8;
            cbKieuXoa.SelectedIndexChanged += cbKieuXoa_SelectedIndexChanged;
            // 
            // dtpTimNgay
            // 
            dtpTimNgay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpTimNgay.Format = DateTimePickerFormat.Short;
            dtpTimNgay.Location = new Point(22, 59);
            dtpTimNgay.Name = "dtpTimNgay";
            dtpTimNgay.Size = new Size(377, 31);
            dtpTimNgay.TabIndex = 7;
            dtpTimNgay.Visible = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLamMoi.BackColor = Color.LightCyan;
            btnLamMoi.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            btnLamMoi.Location = new Point(466, 178);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(146, 34);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click_1;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSua.BackColor = Color.LightCyan;
            btnSua.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            btnSua.Location = new Point(244, 178);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(146, 34);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa Nhân Viên";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click_1;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTuKhoa.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTuKhoa.ForeColor = Color.Gray;
            txtTuKhoa.Location = new Point(23, 63);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(377, 26);
            txtTuKhoa.TabIndex = 0;
            txtTuKhoa.Text = "Nhập tên muốn tìm kiếm";
            txtTuKhoa.Enter += txtTimKiem_Enter;
            txtTuKhoa.Leave += txtTuKhoa_Leave;
            // 
            // cbKieuTimKiem
            // 
            cbKieuTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbKieuTimKiem.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKieuTimKiem.FormattingEnabled = true;
            cbKieuTimKiem.Items.AddRange(new object[] { "Theo Tên", "Theo Khoảng Ngày", "Theo Mã NV", "Theo Ngày Cụ Thể", "Nhân Viên Cũ Nhất", "Nhân Viên Mới Nhất" });
            cbKieuTimKiem.Location = new Point(421, 63);
            cbKieuTimKiem.Name = "cbKieuTimKiem";
            cbKieuTimKiem.Size = new Size(191, 27);
            cbKieuTimKiem.TabIndex = 1;
            cbKieuTimKiem.SelectedIndexChanged += cbKieuTimKiem_SelectedIndexChanged;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnThem.BackColor = Color.LightCyan;
            btnThem.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            btnThem.Location = new Point(23, 178);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(146, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm Nhân Viên";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnXoa.BackColor = Color.LightCyan;
            btnXoa.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            btnXoa.Location = new Point(660, 178);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(146, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa Nhân Viên";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTimKiem.BackColor = Color.LightCyan;
            btnTimKiem.Font = new Font("Times New Roman", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(421, 97);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(191, 30);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // label4
            // 
            label4.BackColor = Color.LightCyan;
            label4.Font = new Font("Times New Roman", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 29);
            label4.Name = "label4";
            label4.Size = new Size(170, 30);
            label4.TabIndex = 2;
            label4.Text = "CHỌN KIỂU SẮP XẾP";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSapXep
            // 
            btnSapXep.BackColor = Color.LightCyan;
            btnSapXep.Font = new Font("Times New Roman", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSapXep.Location = new Point(31, 178);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(146, 34);
            btnSapXep.TabIndex = 1;
            btnSapXep.Text = "Sắp Xếp";
            btnSapXep.UseVisualStyleBackColor = false;
            btnSapXep.Click += btnSapXep_Click;
            // 
            // cbKieuSapXep
            // 
            cbKieuSapXep.FormattingEnabled = true;
            cbKieuSapXep.Items.AddRange(new object[] { "Theo Tên", "Theo Bộ Phận" });
            cbKieuSapXep.Location = new Point(31, 57);
            cbKieuSapXep.Name = "cbKieuSapXep";
            cbKieuSapXep.Size = new Size(146, 33);
            cbKieuSapXep.TabIndex = 0;
            // 
            // lblTong
            // 
            lblTong.BackColor = Color.DarkGray;
            lblTong.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTong.ForeColor = Color.Red;
            lblTong.Location = new Point(817, 374);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(232, 35);
            lblTong.TabIndex = 8;
            lblTong.Text = "Tổng số nhân viên: 0";
            lblTong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.RowTemplate.Height = 28;
            dgvNhanVien.Size = new Size(1061, 418);
            dgvNhanVien.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.z7777715315044_a033934c54562ff3a9d36181e20c5bb3;
            ClientSize = new Size(1061, 657);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giao Diện Quản Lý";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbKieuTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.ComboBox cbKieuSapXep;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.DateTimePicker dtpTimNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayXoa;
        private System.Windows.Forms.ComboBox cbKieuXoa;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}