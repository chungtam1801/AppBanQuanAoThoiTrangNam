using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class LoaiSPConfiguration : IEntityTypeConfiguration<LoaiSP>
    {
        public void Configure(EntityTypeBuilder<LoaiSP> builder)
        {
            builder.ToTable("LoaiSP");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int");
            builder.HasOne(x => x.LoaiSPCha).WithMany().HasForeignKey(x => x.IDLoaiSPCha);
        }
    }
}
