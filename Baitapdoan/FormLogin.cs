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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        

        

        

        

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string users = txtTenDangNhap.Text;
            string pass = txtMatKhau.Text;
            if (users == "admin" && pass == "123")
            {
                this.Hide();
                // 2. Mở Form Quản Lý ra sàn
                FormMain frmMain = new FormMain();
                frmMain.ShowDialog(); // Lệnh này sẽ giữ FormMain ở trên màn hình
                                      
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu! ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
