﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL_DA.Model1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LichHen> LichHens { get; set; }
        public virtual DbSet<Thuoc_> Thuoc_ { get; set; }
        public virtual DbSet<ToaThuoc> ToaThuocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.MaBenhNhan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.BenhNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BenhNhan>()
                .HasMany(e => e.LichHens)
                .WithRequired(e => e.BenhNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BenhNhan>()
                .HasMany(e => e.ToaThuocs)
                .WithRequired(e => e.BenhNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaDichVu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaToa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaBenhNhan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaDichVu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LichHen>()
                .Property(e => e.MaLichHen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LichHen>()
                .Property(e => e.MaBenhNhan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LichHen>()
                .Property(e => e.MaDichVu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc_>()
                .Property(e => e.MaThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc_>()
                .HasMany(e => e.ToaThuocs)
                .WithRequired(e => e.Thuoc_)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ToaThuoc>()
                .Property(e => e.MaToa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ToaThuoc>()
                .Property(e => e.MaThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ToaThuoc>()
                .Property(e => e.MaBenhNhan)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
