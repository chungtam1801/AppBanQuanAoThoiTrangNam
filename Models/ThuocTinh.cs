namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Models
{
    public class ThuocTinh
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public DateTime NgayTao { get; set; }
        public int TrangThai { get; set; }
        public virtual IEnumerable<GiaTri> GiaTris { get; set; }
        public virtual IEnumerable<ThuocTinhSanPham> ThuocTinhSanPhams { get; set; }
    }
}
