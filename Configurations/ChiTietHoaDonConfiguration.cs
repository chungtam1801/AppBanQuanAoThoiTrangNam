using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class ChiTietHoaDonConfiguration : IEntityTypeConfiguration<ChiTietHoaDon>
    {
        public void Configure(EntityTypeBuilder<ChiTietHoaDon> builder)
        {
            builder.ToTable("ChiTietHoaDon");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.DonGia).HasColumnType("int");
            builder.Property(x => x.SoLuong).HasColumnType("int");
            builder.Property(x => x.TrangThai).HasColumnType("int");
            builder.HasOne(x => x.HoaDon).WithMany(x => x.ChiTietHoaDons).HasForeignKey(x => x.IDHoaDon);
            builder.HasOne(x => x.BienThe).WithMany(x => x.ChiTietHoaDons).HasForeignKey(x => x.IDBienThe);
        }
    }
}
