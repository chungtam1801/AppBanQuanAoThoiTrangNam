namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Models
{
    public class ThuocTinhLoaiSP
    {
        public Guid ID { get; set; }
        public Guid IDThuocTinh { get; set; }
        public Guid IDLoaiSP { get; set; }
        public virtual ThuocTinh ThuocTinh { get; set; }
        public virtual LoaiSP LoaiSP { get; set; }
    }
}
