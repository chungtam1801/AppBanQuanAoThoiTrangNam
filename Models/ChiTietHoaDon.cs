namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Models
{
    public class ChiTietHoaDon
    {
        public Guid ID { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
        public Guid IDBienThe { get; set; }
        public Guid IDHoaDon { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual BienThe BienThe { get; set; }
    }
}
