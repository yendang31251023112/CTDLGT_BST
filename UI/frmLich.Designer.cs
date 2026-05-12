namespace Baitapdoan
{
    partial class frmLich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLich));
            label1 = new Label();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnTimKiemNgay = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 220);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 0;
            label1.Text = "Từ Ngày";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 317);
            label2.Name = "label2";
            label2.Size = new Size(148, 30);
            label2.TabIndex = 1;
            label2.Text = "Đến Ngày";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(300, 220);
            dtpTuNgay.Margin = new Padding(3, 4, 3, 4);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(440, 31);
            dtpTuNgay.TabIndex = 2;
            dtpTuNgay.ValueChanged += dtpTuNgay_ValueChanged;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(300, 316);
            dtpDenNgay.Margin = new Padding(3, 4, 3, 4);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(440, 31);
            dtpDenNgay.TabIndex = 3;
            // 
            // btnTimKiemNgay
            // 
            btnTimKiemNgay.BackColor = Color.LightCyan;
            btnTimKiemNgay.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiemNgay.Location = new Point(569, 398);
            btnTimKiemNgay.Margin = new Padding(3, 4, 3, 4);
            btnTimKiemNgay.Name = "btnTimKiemNgay";
            btnTimKiemNgay.Size = new Size(171, 39);
            btnTimKiemNgay.TabIndex = 4;
            btnTimKiemNgay.Text = "Xác Nhận";
            btnTimKiemNgay.UseVisualStyleBackColor = false;
            btnTimKiemNgay.Click += btnTimKiemNgay_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 146);
            label3.Name = "label3";
            label3.Size = new Size(393, 38);
            label3.TabIndex = 5;
            label3.Text = "HÃY NHẬP KHOẢNG NGÀY BẠN MUỐN TÌM";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLich
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(889, 562);
            Controls.Add(label3);
            Controls.Add(btnTimKiemNgay);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLich";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn Khoảng Thời Gian";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnTimKiemNgay;
        private Label label3;
    }
}