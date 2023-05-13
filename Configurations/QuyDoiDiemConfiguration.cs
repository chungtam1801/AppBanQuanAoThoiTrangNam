using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class QuyDoiDiemConfiguration : IEntityTypeConfiguration<QuyDoiDiem>
    {
        public void Configure(EntityTypeBuilder<QuyDoiDiem> builder)
        {
            builder.ToTable("QuyDoiDiem");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.SoDiem).HasColumnType("int");
            builder.Property(x => x.TiLeTichDiem).HasColumnType("int");
            builder.Property(x => x.TiLeTieuDiem).HasColumnType("int");
            builder.Property(x => x.TrangThai).HasColumnType("int");
        }
    }
}
