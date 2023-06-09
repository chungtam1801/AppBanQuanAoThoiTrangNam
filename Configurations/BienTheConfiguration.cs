﻿using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class BienTheConfiguration : IEntityTypeConfiguration<BienThe>
    {
        public void Configure(EntityTypeBuilder<BienThe> builder)
        {
            builder.ToTable("BienThe");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(x => x.GiaBan).HasColumnType("int");
            builder.Property(x => x.NgayTao).HasColumnType("Datetime");
            builder.Property(x => x.TrangThai).HasColumnType("int");
            builder.HasOne(x => x.SanPham).WithMany(x => x.BienThes).HasForeignKey(x => x.IDSanPham);
        }
    }
}
