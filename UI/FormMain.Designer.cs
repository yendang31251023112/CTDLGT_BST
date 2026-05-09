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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dtpNgayXoa = new System.Windows.Forms.DateTimePicker();
            this.cbKieuXoa = new System.Windows.Forms.ComboBox();
            this.dtpTimNgay = new System.Windows.Forms.DateTimePicker();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.cbKieuTimKiem = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.cbKieuSapXep = new System.Windows.Forms.ComboBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.lblTong);
            this.splitContainer1.Panel2.Controls.Add(this.dgvNhanVien);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 657);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dtpNgayXoa);
            this.splitContainer2.Panel1.Controls.Add(this.cbKieuXoa);
            this.splitContainer2.Panel1.Controls.Add(this.dtpTimNgay);
            this.splitContainer2.Panel1.Controls.Add(this.btnLamMoi);
            this.splitContainer2.Panel1.Controls.Add(this.btnSua);
            this.splitContainer2.Panel1.Controls.Add(this.txtTuKhoa);
            this.splitContainer2.Panel1.Controls.Add(this.cbKieuTimKiem);
            this.splitContainer2.Panel1.Controls.Add(this.btnThem);
            this.splitContainer2.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer2.Panel1.Controls.Add(this.btnTimKiem);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnSapXep);
            this.splitContainer2.Panel2.Controls.Add(this.cbKieuSapXep);
            this.splitContainer2.Size = new System.Drawing.Size(1061, 235);
            this.splitContainer2.SplitterDistance = 853;
            this.splitContainer2.TabIndex = 7;
            // 
            // dtpNgayXoa
            // 
            this.dtpNgayXoa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXoa.Location = new System.Drawing.Point(654, 58);
            this.dtpNgayXoa.Name = "dtpNgayXoa";
            this.dtpNgayXoa.Size = new System.Drawing.Size(146, 26);
            this.dtpNgayXoa.TabIndex = 9;
            this.dtpNgayXoa.Visible = false;
            // 
            // cbKieuXoa
            // 
            this.cbKieuXoa.FormattingEnabled = true;
            this.cbKieuXoa.Items.AddRange(new object[] {
            "Xóa Theo Mã NV",
            "Xóa Theo Ngày"});
            this.cbKieuXoa.Location = new System.Drawing.Point(654, 92);
            this.cbKieuXoa.Name = "cbKieuXoa";
            this.cbKieuXoa.Size = new System.Drawing.Size(146, 28);
            this.cbKieuXoa.TabIndex = 8;
            this.cbKieuXoa.SelectedIndexChanged += new System.EventHandler(this.cbKieuXoa_SelectedIndexChanged);
            // 
            // dtpTimNgay
            // 
            this.dtpTimNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTimNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimNgay.Location = new System.Drawing.Point(23, 60);
            this.dtpTimNgay.Name = "dtpTimNgay";
            this.dtpTimNgay.Size = new System.Drawing.Size(388, 26);
            this.dtpTimNgay.TabIndex = 7;
            this.dtpTimNgay.Visible = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(401, 165);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(146, 47);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(213, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(146, 47);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa Nhân Viên";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.ForeColor = System.Drawing.Color.Gray;
            this.txtTuKhoa.Location = new System.Drawing.Point(23, 58);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(388, 26);
            this.txtTuKhoa.TabIndex = 0;
            this.txtTuKhoa.Text = "Nhập tên muốn tìm kiếm";
            this.txtTuKhoa.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTuKhoa.Leave += new System.EventHandler(this.txtTuKhoa_Leave);
            // 
            // cbKieuTimKiem
            // 
            this.cbKieuTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKieuTimKiem.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKieuTimKiem.FormattingEnabled = true;
            this.cbKieuTimKiem.Items.AddRange(new object[] {
            "Theo Tên",
            "Theo Khoảng Ngày",
            "Theo Mã NV",
            "Theo Ngày Cụ Thể",
            "Nhân Viên Cũ Nhất",
            "Nhân Viên Mới Nhất"});
            this.cbKieuTimKiem.Location = new System.Drawing.Point(417, 92);
            this.cbKieuTimKiem.Name = "cbKieuTimKiem";
            this.cbKieuTimKiem.Size = new System.Drawing.Size(130, 27);
            this.cbKieuTimKiem.TabIndex = 1;
            this.cbKieuTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbKieuTimKiem_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(23, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(146, 47);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm Nhân Viên";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(654, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 47);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa Nhân Viên";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(417, 58);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(130, 30);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Location = new System.Drawing.Point(18, 165);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(146, 47);
            this.btnSapXep.TabIndex = 1;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // cbKieuSapXep
            // 
            this.cbKieuSapXep.FormattingEnabled = true;
            this.cbKieuSapXep.Items.AddRange(new object[] {
            "Theo Tên",
            "Theo Bộ Phận"});
            this.cbKieuSapXep.Location = new System.Drawing.Point(18, 92);
            this.cbKieuSapXep.Name = "cbKieuSapXep";
            this.cbKieuSapXep.Size = new System.Drawing.Size(146, 28);
            this.cbKieuSapXep.TabIndex = 0;
            // 
            // lblTong
            // 
            this.lblTong.BackColor = System.Drawing.Color.DarkGray;
            this.lblTong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.Red;
            this.lblTong.Location = new System.Drawing.Point(817, 374);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(232, 35);
            this.lblTong.TabIndex = 8;
            this.lblTong.Text = "Tổng số nhân viên: 0";
            this.lblTong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(1061, 418);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Baitapdoan.Properties.Resources.z7777715315044_a033934c54562ff3a9d36181e20c5bb3;
            this.ClientSize = new System.Drawing.Size(1061, 657);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện Quản Lý";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

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
    }
}