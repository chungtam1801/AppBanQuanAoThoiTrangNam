using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class ThuocTinhLoaiSPConfiguration : IEntityTypeConfiguration<ThuocTinhLoaiSP>
    {
        public void Configure(EntityTypeBuilder<ThuocTinhLoaiSP> builder)   
        {
            builder.ToTable("ThuocTinhSanPham");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.ThuocTinh).WithMany(x => x.ThuocTinhLoaiSPs).HasForeignKey(x => x.IDThuocTinh);
            builder.HasOne(x => x.LoaiSP).WithMany(x => x.ThuocTinhLoaiSPs).HasForeignKey(x => x.IDLoaiSP);
        }
    }
}
