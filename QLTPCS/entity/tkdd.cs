﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLTPCS.entity
{
    class tkdd
    {
        string _TenNhanVien;
        string _SoNgayDiLam;

        public tkdd(SqlDataReader dr)
        {
            this.TenNhanVien = dr["TenNhanVien"].ToString();
            this.SoNgayDiLam = dr["SoNgayDiLam"].ToString();
        }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public string SoNgayDiLam { get => _SoNgayDiLam; set => _SoNgayDiLam = value; }
    }
}
