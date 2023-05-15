using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class ChiTietBienTheConfiguration : IEntityTypeConfiguration<ChiTietBienThe>
    {
        public void Configure(EntityTypeBuilder<ChiTietBienThe> builder)
        {
            builder.ToTable("ChiTietBienThe");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.BienThe).WithMany(x => x.ChiTietBienThes).HasForeignKey(x => x.IDBienThe);
            builder.HasOne(x => x.GiaTri).WithMany(x => x.ChiTietBienThes).HasForeignKey(x => x.IDGiaTri);
        }
    }
}

