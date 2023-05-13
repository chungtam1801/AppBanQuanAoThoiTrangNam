namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Models
{
    public class ChiTietGioHang
    {
        public Guid ID { get; set; }
        public int SoLuong { get; set; }
        public Guid IDBienThe { get; set; }
        public Guid IDNguoiDung { get; set; }
        public virtual BienThe BienThe { get; set; }
        public virtual GioHang GioHang { get; set; }
    }
}
