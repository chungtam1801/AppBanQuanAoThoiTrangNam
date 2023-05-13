namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Models
{
    public class ChiTietBienThe
    {
        public Guid ID { get; set; }
        public int TrangThai { get; set; }
        public Guid IDBienThe { get; set; }
        public Guid IDGiaTri { get; set; }
        public Guid? IDThuocTinhSanPham { get; set; }
        public virtual BienThe BienThe { get; set; }
        public virtual GiaTri GiaTri { get; set; }
        public virtual ThuocTinhSanPham ThuocTinhSanPham { get; set; }
    }
}
