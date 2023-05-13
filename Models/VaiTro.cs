namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Models
{
    public class VaiTro
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public int TrangThai { get; set; }
        public virtual IEnumerable<NguoiDung> NguoiDungs { get; set; }
    }
}
