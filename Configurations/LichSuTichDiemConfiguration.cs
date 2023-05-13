using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class LichSuTichDiemConfiguration : IEntityTypeConfiguration<LichSuTichDiem>
    {
        public void Configure(EntityTypeBuilder<LichSuTichDiem> builder)
        {
            builder.ToTable("LichSuTichDiem");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Diem).HasColumnType("int");
            builder.Property(x => x.TrangThai).HasColumnType("int");
            builder.HasOne(x => x.NguoiDung).WithMany(x => x.LichSuTichDiems).HasForeignKey(x => x.IDNguoiDung);
            builder.HasOne(x => x.QuyDoiDiem).WithMany(x => x.LichSuTichDiems).HasForeignKey(x => x.IDQuyDoiDiem);
            builder.HasOne(x => x.HoaDon).WithMany(x => x.LichSuTichDiems).HasForeignKey(x => x.IDHoaDon);
        }
    }
}
