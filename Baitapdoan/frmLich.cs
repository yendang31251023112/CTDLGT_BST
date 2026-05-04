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
    public partial class frmLich : Form
    {
        
        public DateTime TuNgay { get; private set; }
        public DateTime DenNgay { get; private set; }
        public bool DaChonXong { get; private set; } = false;
        public frmLich()
        {
            InitializeComponent();
        }

        

        

        

        private void btnTimKiemNgay_Click(object sender, EventArgs e)
        {
            DateTime start = dtpTuNgay.Value.Date;
            DateTime end = dtpDenNgay.Value.Date;

            
            if (start > end)
            {
                MessageBox.Show("'Từ Ngày' không thể lớn hơn 'Đến Ngày'? Không hợp lệ!", "Sai logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            // Gán dữ liệu 
            TuNgay = start;
            DenNgay = end;
            DaChonXong = true; 

            // Tự sát Form này, trả quyền điều khiển về lại cho lệnh ShowDialog() bên Form Main
            this.Close();
        }

       
    }
    
}
