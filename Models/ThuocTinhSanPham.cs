namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Models
{
    public class ThuocTinhSanPham
    {
        public Guid ID { get; set; }
        public Guid IDThuocTinh { get; set; }
        public Guid IDSanPham { get; set; }
        public virtual IEnumerable<ChiTietBienThe> ChiTietBienThes { get; set; }
        public virtual ThuocTinh ThuocTinh { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
