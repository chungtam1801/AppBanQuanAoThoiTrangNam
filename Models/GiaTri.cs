﻿namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Models
{
    public class GiaTri
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public Guid IdThuocTinh { get; set; }
        public virtual IEnumerable<ChiTietBienThe> ChiTietBienThes { get; set; }
        public virtual ThuocTinh ThuocTinh { get; set; }
    }
}
