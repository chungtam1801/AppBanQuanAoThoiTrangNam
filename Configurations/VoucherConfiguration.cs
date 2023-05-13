using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.ToTable("Voucher");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(50)");
            builder.Property(x => x.HinhThucGiamGia).HasColumnType("int");
            builder.Property(x => x.SoTienCan).HasColumnType("int");
            builder.Property(x => x.GiaTri).HasColumnType("int");
            builder.Property(x => x.NgayApDung).HasColumnType("datetime");
            builder.Property(x => x.NgayKetThuc).HasColumnType("datetime");
            builder.Property(x => x.SoLuong).HasColumnType("int");
            builder.Property(x => x.MoTa).HasColumnType("nvarchar(50)");
            builder.Property(x => x.TrangThai).HasColumnType("int");
        }
    }
}
