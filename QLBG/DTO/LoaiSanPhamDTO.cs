﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPhamDTO
    {
        public int maLoai { get; set; }
        public string tenLoai { get; set; }
        public bool tinhTrang { get; set; }
        public LoaiSanPhamDTO() 
        {
            this.tinhTrang = true;
        }
        public LoaiSanPhamDTO(int maLoai, string tenLoai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.tinhTrang = true;
        }
    }
}
