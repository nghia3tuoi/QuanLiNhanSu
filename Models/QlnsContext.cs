using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace QLNS.Models;

public partial class QlnsContext : IdentityDbContext<IdentityUser>
{
    public QlnsContext()
    {
    }

    public QlnsContext(DbContextOptions<QlnsContext> options)
        : base(options)
    {
    }
    public virtual DbSet<StatusNhanVien> StatusNhanviens { get; set; }
    public virtual DbSet<ChamCong> ChamCongs { get; set; }

    public virtual DbSet<CongViec> CongViecs { get; set; }

    public virtual DbSet<DaoTao> DaoTaos { get; set; }

    public virtual DbSet<HieuSuat> HieuSuats { get; set; }

    public virtual DbSet<HopDongLaoDong> HopDongLaoDongs { get; set; }

    public virtual DbSet<KyLuatAndKhenThuong> KyLuatAndKhenThuongs { get; set; }

    public virtual DbSet<LichSuLuong> LichSuLuongs { get; set; }

    public virtual DbSet<LichSuNghiPhep> LichSuNghiPheps { get; set; }

    public virtual DbSet<Luong> Luongs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<NhanVienShip> NhanVienShips { get; set; }

    public virtual DbSet<NhomNhanVien> NhomNhanViens { get; set; }

    public virtual DbSet<PhongBan> PhongBans { get; set; }

    public virtual DbSet<Pttt> Pttts { get; set; }

    public virtual DbSet<ThongBao> ThongBaos { get; set; }

    public virtual DbSet<TrangThai> TrangThais { get; set; }

    public virtual DbSet<ViTri> ViTris { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=./;Initial Catalog=QLNS;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ChamCong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChamCong__3213E83F6CF0BF27");

            entity.ToTable("ChamCong");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GioRaLam)
                .HasColumnType("datetime")
                .HasColumnName("gioRaLam");
            entity.Property(e => e.GioVaoLam)
                .HasColumnType("datetime")
                .HasColumnName("gioVaoLam");
            entity.Property(e => e.IdNv).HasColumnName("idNV");
            entity.Property(e => e.MaTrangThai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maTrangThai");
            entity.Property(e => e.TongSoGio).HasColumnName("tongSoGio");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.ChamCongs)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("FK__ChamCong__idNV__4BAC3F29");

            entity.HasOne(d => d.MaTrangThaiNavigation).WithMany(p => p.ChamCongs)
                .HasForeignKey(d => d.MaTrangThai)
                .HasConstraintName("FK_ChamCong_TrangThai");
        });

        modelBuilder.Entity<CongViec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CongViec__3213E83FFBB292ED");

            entity.ToTable("CongViec");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameCv)
                .HasMaxLength(255)
                .HasColumnName("nameCV");
        });

        modelBuilder.Entity<DaoTao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DaoTao__3213E83FE8BA5769");

            entity.ToTable("DaoTao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdNv).HasColumnName("idNV");
            entity.Property(e => e.IdPbDaoTao).HasColumnName("idPbDaoTao");
            entity.Property(e => e.MaTrangThai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maTrangThai");
            entity.Property(e => e.NdDaoTao).HasColumnType("text");
            entity.Property(e => e.NgayDaoTao).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThucDt)
                .HasColumnType("datetime")
                .HasColumnName("NgayKetThucDT");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.DaoTaos)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("FK__DaoTao__idNV__693CA210");

            entity.HasOne(d => d.IdPbDaoTaoNavigation).WithMany(p => p.DaoTaos)
                .HasForeignKey(d => d.IdPbDaoTao)
                .HasConstraintName("FK__DaoTao__idPbDaoT__6A30C649");

            entity.HasOne(d => d.MaTrangThaiNavigation).WithMany(p => p.DaoTaos)
                .HasForeignKey(d => d.MaTrangThai)
                .HasConstraintName("FK_DaoTao_TrangThai");
        });

        modelBuilder.Entity<HieuSuat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HieuSuat__3213E83FA2B64DE2");

            entity.ToTable("HieuSuat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdNv).HasColumnName("idNV");
            entity.Property(e => e.NoiDung)
                .HasColumnType("text")
                .HasColumnName("noiDung");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.HieuSuats)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("FK__HieuSuat__idNV__5CD6CB2B");
        });

        modelBuilder.Entity<HopDongLaoDong>(entity =>
        {
            entity.HasKey(e => e.IdNv);

            entity.ToTable("HopDongLaoDong");

            entity.Property(e => e.IdNv)
                .ValueGeneratedNever()
                .HasColumnName("idNV");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Deleted)
                .HasColumnType("datetime")
                .HasColumnName("deleted");
            entity.Property(e => e.IdCv).HasColumnName("idCV");
            entity.Property(e => e.IdLuong).HasColumnName("idLuong");
            entity.Property(e => e.IdPb).HasColumnName("idPB");
            entity.Property(e => e.IdVt).HasColumnName("idVT");
            entity.Property(e => e.MaTrangThai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maTrangThai");
            entity.Property(e => e.NgayKetThuc)
                .HasColumnType("datetime")
                .HasColumnName("ngayKetThuc");
            entity.Property(e => e.NgayLamViec)
                .HasColumnType("datetime")
                .HasColumnName("ngayLamViec");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");

            entity.HasOne(d => d.IdCvNavigation).WithMany(p => p.HopDongLaoDongs)
                .HasForeignKey(d => d.IdCv)
                .HasConstraintName("FK__HopDongLao__idCV__59063A47");

            entity.HasOne(d => d.IdNvNavigation).WithOne(p => p.HopDongLaoDong)
                .HasForeignKey<HopDongLaoDong>(d => d.IdNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HopDongLao__idNV__5535A963");

            entity.HasOne(d => d.IdPbNavigation).WithMany(p => p.HopDongLaoDongs)
                .HasForeignKey(d => d.IdPb)
                .HasConstraintName("FK__HopDongLao__idPB__571DF1D5");

            entity.HasOne(d => d.IdVtNavigation).WithMany(p => p.HopDongLaoDongs)
                .HasForeignKey(d => d.IdVt)
                .HasConstraintName("FK__HopDongLao__idVT__59FA5E80");

            entity.HasOne(d => d.MaTrangThaiNavigation).WithMany(p => p.HopDongLaoDongs)
                .HasForeignKey(d => d.MaTrangThai)
                .HasConstraintName("FK_HopDongLaoDong_TrangThai");
        });

        modelBuilder.Entity<KyLuatAndKhenThuong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KyLuatAn__3213E83F8CF48620");

            entity.ToTable("KyLuatAndKhenThuong");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdNv).HasColumnName("idNV");
            entity.Property(e => e.MaTrangThai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maTrangThai");
            entity.Property(e => e.NoiDung)
                .HasColumnType("text")
                .HasColumnName("noiDung");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.KyLuatAndKhenThuongs)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("FK__KyLuatAndK__idNV__656C112C");

            entity.HasOne(d => d.MaTrangThaiNavigation).WithMany(p => p.KyLuatAndKhenThuongs)
                .HasForeignKey(d => d.MaTrangThai)
                .HasConstraintName("FK_KyLuatAndKhenThuong_TrangThai");
        });

        modelBuilder.Entity<LichSuLuong>(entity =>
        {
            entity.ToTable("LichSuLuong");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Deleted)
                .HasColumnType("datetime")
                .HasColumnName("deleted");
            entity.Property(e => e.IdLuong).HasColumnName("idLuong");
            entity.Property(e => e.IdNv).HasColumnName("idNV");
            entity.Property(e => e.IdPttt).HasColumnName("idPTTT");
            entity.Property(e => e.MaTrangThai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maTrangThai");
            entity.Property(e => e.NgayThanhToan)
                .HasColumnType("datetime")
                .HasColumnName("ngayThanhToan");
            entity.Property(e => e.NoiDung)
                .HasColumnType("text")
                .HasColumnName("noiDung");
            entity.Property(e => e.SoNgayNghi).HasColumnName("soNgayNghi");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("updateAt");

            entity.HasOne(d => d.IdLuongNavigation).WithMany(p => p.LichSuLuongs)
                .HasForeignKey(d => d.IdLuong)
                .HasConstraintName("FK_LichSuLuong_Luong");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.LichSuLuongs)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("FK_Table_1_NhanVien");

            entity.HasOne(d => d.MaTrangThaiNavigation).WithMany(p => p.LichSuLuongs)
                .HasForeignKey(d => d.MaTrangThai)
                .HasConstraintName("FK_Table_1_TrangThai");
        });

        modelBuilder.Entity<LichSuNghiPhep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NghiPhep__3213E83F521BAF72");

            entity.ToTable("LichSuNghiPhep");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Deleted)
                .HasColumnType("datetime")
                .HasColumnName("deleted");
            entity.Property(e => e.IdNghiPhep).HasColumnName("idNghiPhep");
            entity.Property(e => e.IdNv).HasColumnName("idNV");
            entity.Property(e => e.MaTrangThai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maTrangThai");
            entity.Property(e => e.NgayKetThucNghi)
                .HasColumnType("date")
                .HasColumnName("ngayKetThucNghi");
            entity.Property(e => e.NgayNghi)
                .HasColumnType("date")
                .HasColumnName("ngayNghi");
            entity.Property(e => e.NoiDung)
                .HasColumnType("ntext")
                .HasColumnName("noiDung");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.LichSuNghiPheps)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("FK_LichSuNghiPhep_NhanVien");
        });

        modelBuilder.Entity<Luong>(entity =>
        {
            entity.HasKey(e => e.IdNv).HasName("PK__Luong__3213E83F23A56B53");

            entity.ToTable("Luong");

            entity.Property(e => e.IdNv)
                .ValueGeneratedNever()
                .HasColumnName("idNV");
            entity.Property(e => e.LuongCb)
                .HasColumnType("money")
                .HasColumnName("luongCB");
            entity.Property(e => e.LuongTong)
                .HasColumnType("money")
                .HasColumnName("luongTong");
            entity.Property(e => e.PhuCap)
                .HasColumnType("money")
                .HasColumnName("phuCap");

            entity.HasOne(d => d.IdNvNavigation).WithOne(p => p.Luong)
                .HasForeignKey<Luong>(d => d.IdNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Luong_NhanVien");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhanVien__3213E83FDA810A26");

            entity.ToTable("NhanVien");

            entity.HasIndex(e => e.MaNv, "unique_maNV").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.ChuyenNganh)
                .HasMaxLength(255)
                .HasColumnName("chuyenNganh");
            entity.Property(e => e.FistName)
                .HasMaxLength(255)
                .HasColumnName("fistName");
            entity.Property(e => e.IdCongViec).HasColumnName("idCongViec");
            entity.Property(e => e.IdVitri).HasColumnName("idVitri");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("lastName");
            entity.Property(e => e.MaNv)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("maNV");
            entity.Property(e => e.NgaySinh)
                .HasColumnType("datetime")
                .HasColumnName("ngaySinh");
            entity.Property(e => e.TrinhDo)
                .HasMaxLength(255)
                .HasColumnName("trinhDo");

            entity.HasOne(d => d.IdCongViecNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdCongViec)
                .HasConstraintName("FK_NhanVien_CongViec");

            entity.HasOne(d => d.IdVitriNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdVitri)
                .HasConstraintName("FK_NhanVien_ViTri");
        });

        modelBuilder.Entity<NhanVienShip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhanVien__3213E83F4AAF3997");

            entity.ToTable("NhanVienShip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdNnv).HasColumnName("idNNV");
            entity.Property(e => e.IdNv).HasColumnName("idNV");

            entity.HasOne(d => d.IdNnvNavigation).WithMany(p => p.NhanVienShips)
                .HasForeignKey(d => d.IdNnv)
                .HasConstraintName("FK__NhanVienS__idNNV__7B5B524B");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.NhanVienShips)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("FK__NhanVienSh__idNV__7A672E12");
        });

        modelBuilder.Entity<NhomNhanVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhomNhan__3213E83F4DCFB09B");

            entity.ToTable("NhomNhanVien");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NoiDung)
                .HasColumnType("ntext")
                .HasColumnName("noiDung");
        });

        modelBuilder.Entity<PhongBan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PhongBan__3213E83FC30D7C7E");

            entity.ToTable("PhongBan");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DuAnThamGia)
                .HasMaxLength(255)
                .HasColumnName("duAnThamGia");
            entity.Property(e => e.IdNguoiQuanLi).HasColumnName("idNguoiQuanLi");
            entity.Property(e => e.NamePb)
                .HasMaxLength(255)
                .HasColumnName("namePB");
            entity.Property(e => e.SoLuongNvtg).HasColumnName("soLuongNVTG");

            entity.HasOne(d => d.IdNguoiQuanLiNavigation).WithMany(p => p.PhongBans)
                .HasForeignKey(d => d.IdNguoiQuanLi)
                .HasConstraintName("FK__PhongBan__idNguo__412EB0B6");
        });

        modelBuilder.Entity<Pttt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PTTT__3213E83FFE114845");

            entity.ToTable("PTTT");

            entity.Property(e => e.Id)
                .HasColumnType("money")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ThongBao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ThongBao__3213E83F57538971");

            entity.ToTable("ThongBao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Deleted)
                .HasColumnType("datetime")
                .HasColumnName("deleted");
            entity.Property(e => e.IdNghiPhep).HasColumnName("idNghiPhep");
        });

        modelBuilder.Entity<TrangThai>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("TrangThai");

            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ViTri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ViTri__3213E83F260821AD");

            entity.ToTable("ViTri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameVt)
                .HasMaxLength(255)
                .HasColumnName("nameVT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
