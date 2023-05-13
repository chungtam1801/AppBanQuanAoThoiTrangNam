using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class ChiTietKhuyenMaiConfiguration : IEntityTypeConfiguration<ChiTietKhuyenMai>
    {
        public void Configure(EntityTypeBuilder<ChiTietKhuyenMai> builder)
        {
            builder.ToTable("ChiTietKhuyenMai");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.TrangThai).HasColumnType("int");
            builder.HasOne(x => x.KhuyenMai).WithMany(x => x.ChiTietKhuyenMais).HasForeignKey(x => x.IDKhuyenMai);
            builder.HasOne(x => x.BienThe).WithMany(x => x.ChiTietKhuyenMais).HasForeignKey(x => x.IDBienThe);
        }
    }
}
