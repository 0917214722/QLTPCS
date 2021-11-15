using QLTPCS.entity;
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
    public partial class frm_tkDiemDanh : Form
    {
        public frm_tkDiemDanh()
        {
            InitializeComponent();
        }
        private void loadDataToTable()
        {
            try
            {
                List<tkdd> lst_diemDanh = new List<tkdd>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = sa123");
                conn.Open();
                string query = "select TenNhanVien, count (MaNhanVien) as SoNgayDiLam from DiemDanh where MONTH(NgayDiLam) = @thang and YEAR(NgayDiLam) = @nam group by TenNhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@thang", txt_thang.Text));
                cmd.Parameters.Add(new SqlParameter("@nam", txt_nam.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tkdd obj = new tkdd(dr);
                    lst_diemDanh.Add(obj);
                }
                conn.Close();
                dgv_tkdd.DataSource = lst_diemDanh;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frm_tkDiemDanh_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_thongKe_Click(object sender, EventArgs e)
        {
            loadDataToTable();
        }
    }
}
