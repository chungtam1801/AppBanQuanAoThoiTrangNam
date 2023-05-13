using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(50)");
            builder.Property(x => x.MoTa).HasColumnType("nvarchar(50)");
            builder.Property(x => x.TrangThai).HasColumnType("int");
            builder.HasOne(x => x.LoaiSP).WithMany(x => x.SanPhams).HasForeignKey(x => x.IDLoaiSP);
        }
    }
}
