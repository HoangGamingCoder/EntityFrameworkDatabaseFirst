using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Models;

public partial class QuanLySinhVienContext : DbContext
{
    public QuanLySinhVienContext()
    {
    }

    public QuanLySinhVienContext(DbContextOptions<QuanLySinhVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=HOANGTHUYLINK\\HUYHOANG;Initial Catalog=QuanLySinhVien;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.KhoaId).HasName("PK__Khoa__42EDDFF4E89D46EE");

            entity.ToTable("Khoa");

            entity.Property(e => e.KhoaId).ValueGeneratedNever();
            entity.Property(e => e.TenKhoa).HasMaxLength(100);
        });

        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.LopId).HasName("PK__Lop__40585D2BCD9E9AAD");

            entity.ToTable("Lop");

            entity.Property(e => e.LopId).ValueGeneratedNever();
            entity.Property(e => e.TenLop).HasMaxLength(100);

            entity.HasOne(d => d.Khoa).WithMany(p => p.Lops)
                .HasForeignKey(d => d.KhoaId)
                .HasConstraintName("FK__Lop__KhoaId__398D8EEE");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.SinhVienId).HasName("PK__SinhVien__F3CF814E54E96BC8");

            entity.ToTable("SinhVien");

            entity.Property(e => e.SinhVienId).ValueGeneratedNever();
            entity.Property(e => e.Ten).HasMaxLength(100);

            entity.HasOne(d => d.Lop).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.LopId)
                .HasConstraintName("FK__SinhVien__LopId__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
