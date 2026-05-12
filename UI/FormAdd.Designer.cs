namespace Baitapdoan
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            lblTenNhanVien = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTenNhanVien = new TextBox();
            txtBoPhan = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            dtpNgayVaoLam = new DateTimePicker();
            cbGioiTinh = new ComboBox();
            txtGhiChu = new TextBox();
            btnLuu = new Button();
            SuspendLayout();
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.BackColor = Color.LightCyan;
            lblTenNhanVien.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            lblTenNhanVien.Location = new Point(229, 56);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(133, 31);
            lblTenNhanVien.TabIndex = 0;
            lblTenNhanVien.Text = "Tên Nhân Viên:";
            lblTenNhanVien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label2.Location = new Point(229, 117);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 1;
            label2.Text = "Bộ Phận:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label3.Location = new Point(229, 179);
            label3.Name = "label3";
            label3.Size = new Size(133, 31);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.LightCyan;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label4.Location = new Point(229, 243);
            label4.Name = "label4";
            label4.Size = new Size(133, 31);
            label4.TabIndex = 3;
            label4.Text = "Ngày Vào Làm:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.LightCyan;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label5.Location = new Point(229, 305);
            label5.Name = "label5";
            label5.Size = new Size(133, 31);
            label5.TabIndex = 4;
            label5.Text = "Giới Tính";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.LightCyan;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label6.Location = new Point(229, 366);
            label6.Name = "label6";
            label6.Size = new Size(133, 31);
            label6.TabIndex = 5;
            label6.Text = "Ghi Chú:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(362, 56);
            txtTenNhanVien.Margin = new Padding(3, 4, 3, 4);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(326, 31);
            txtTenNhanVien.TabIndex = 6;
            // 
            // txtBoPhan
            // 
            txtBoPhan.Location = new Point(362, 117);
            txtBoPhan.Margin = new Padding(3, 4, 3, 4);
            txtBoPhan.Name = "txtBoPhan";
            txtBoPhan.Size = new Size(326, 31);
            txtBoPhan.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(362, 179);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(326, 31);
            dtpNgaySinh.TabIndex = 8;
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Location = new Point(362, 243);
            dtpNgayVaoLam.Margin = new Padding(3, 4, 3, 4);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new Size(326, 31);
            dtpNgayVaoLam.TabIndex = 9;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGioiTinh.Location = new Point(362, 304);
            cbGioiTinh.Margin = new Padding(3, 4, 3, 4);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(326, 33);
            cbGioiTinh.TabIndex = 10;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(362, 366);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(326, 32);
            txtGhiChu.TabIndex = 11;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LightCyan;
            btnLuu.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(512, 468);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(176, 44);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(889, 562);
            Controls.Add(btnLuu);
            Controls.Add(txtGhiChu);
            Controls.Add(cbGioiTinh);
            Controls.Add(dtpNgayVaoLam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtBoPhan);
            Controls.Add(txtTenNhanVien);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTenNhanVien);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdd";
            Text = "FormAdd";
            Load += FormAdd_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtBoPhan;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLuu;
    }
}