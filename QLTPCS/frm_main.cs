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
            frm_DiemDanh.MdiParent = this;
            frm_DiemDanh.Show();
        }

        private void thốngKêĐiểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tkDiemDanh frm_tkdd = new frm_tkDiemDanh();
            frm_tkdd.MdiParent = this;
            frm_tkdd.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sanPham frm_tkdd = new frm_sanPham();
            frm_tkdd.MdiParent = this;
            frm_tkdd.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_loaiSanPham frm_tkdd = new frm_loaiSanPham();
            frm_tkdd.MdiParent = this;
            frm_tkdd.Show();
        }

        private void nhàPhânPhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhaPhanPhoi frm_tkdd = new frm_nhaPhanPhoi();
            frm_tkdd.MdiParent = this;
            frm_tkdd.Show();
        }

        private void phếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_phieuNhap frm_tkdd = new frm_phieuNhap();
            frm_tkdd.MdiParent = this;
            frm_tkdd.Show();
        }
    }
}
