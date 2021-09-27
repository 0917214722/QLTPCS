using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLTPCS
{
    public partial class frm_diemDanh : Form
    {

        public frm_diemDanh()
        {
            InitializeComponent();
        }
        private bool checkFields()
        {
            if (txt_maNhanVien.Text == "")
            {
                MessageBox.Show("Mời nhập mã nhân viên !!!");
                txt_maNhanVien.Focus();
                return false;
            }
            if (txt_tenNhanVien.Text == "")
            {
                MessageBox.Show("Mời nhập tên nhân viên !!!");
                txt_tenNhanVien.Focus();
                return false;
            }
            return true;
        }
        private void btn_diemDanh_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LJGMEJH;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                    conn.Open();
                    string query = "insert into DiemDanh (MaNhanVien,TenNhanVien,NgayDiLam) values (@ma,@ten,GETDATE())";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@ma", txt_maNhanVien.Text));
                    cmd.Parameters.Add(new SqlParameter("@ten", txt_tenNhanVien.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Điểm danh thành công !!!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
