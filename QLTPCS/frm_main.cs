using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTPCS
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhanVien frm_NhanVien = new frm_nhanVien();
            frm_NhanVien.MdiParent = this;
            frm_NhanVien.Show();
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_khachHang frm_KhachHang = new frm_khachHang();
            frm_KhachHang.MdiParent = this;
            frm_KhachHang.Show();
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_diemDanh frm_DiemDanh = new frm_diemDanh();
            
            frm_DiemDanh.Show();
        }

        private void thốngKêĐiểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tkDiemDanh frm_tkdd = new frm_tkDiemDanh();
            frm_tkdd.Show();
        }
    }
}
