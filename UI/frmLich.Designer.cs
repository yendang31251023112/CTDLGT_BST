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
            label1 = new Label();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnTimKiemNgay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 121);
            label1.Name = "label1";
            label1.Size = new Size(163, 54);
            label1.TabIndex = 0;
            label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 282);
            label2.Name = "label2";
            label2.Size = new Size(163, 54);
            label2.TabIndex = 1;
            label2.Text = "Đến Ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(167, 205);
            dtpTuNgay.Margin = new Padding(3, 4, 3, 4);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(534, 31);
            dtpTuNgay.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(167, 370);
            dtpDenNgay.Margin = new Padding(3, 4, 3, 4);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(534, 31);
            dtpDenNgay.TabIndex = 3;
            // 
            // btnTimKiemNgay
            // 
            btnTimKiemNgay.Location = new Point(643, 471);
            btnTimKiemNgay.Margin = new Padding(3, 4, 3, 4);
            btnTimKiemNgay.Name = "btnTimKiemNgay";
            btnTimKiemNgay.Size = new Size(232, 76);
            btnTimKiemNgay.TabIndex = 4;
            btnTimKiemNgay.Text = "Xác Nhận";
            btnTimKiemNgay.UseVisualStyleBackColor = true;
            btnTimKiemNgay.Click += btnTimKiemNgay_Click;
            // 
            // frmLich
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 562);
            Controls.Add(btnTimKiemNgay);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLich";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn Khoảng Thời Gian";
            Load += frmLich_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnTimKiemNgay;
    }
}