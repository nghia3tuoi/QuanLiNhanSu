using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNS.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CongViec",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameCV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CongViec__3213E83FFBB292ED", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NhomNhanVien",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    noiDung = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhomNhan__3213E83F4DCFB09B", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PTTT",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "money", nullable: false),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PTTT__3213E83FFE114845", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ThongBao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idNghiPhep = table.Column<int>(type: "int", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    deleted = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ThongBao__3213E83F57538971", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TrangThai",
                columns: table => new
                {
                    ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThai", x => x.ma);
                });

            migrationBuilder.CreateTable(
                name: "ViTri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameVT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ViTri__3213E83F260821AD", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maNV = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fistName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ngaySinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    trinhDo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    chuyenNganh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    idVitri = table.Column<int>(type: "int", nullable: true),
                    idCongViec = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhanVien__3213E83FDA810A26", x => x.id);
                    table.ForeignKey(
                        name: "FK_NhanVien_CongViec",
                        column: x => x.idCongViec,
                        principalTable: "CongViec",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_NhanVien_ViTri",
                        column: x => x.idVitri,
                        principalTable: "ViTri",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ChamCong",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idNV = table.Column<int>(type: "int", nullable: true),
                    maTrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    gioVaoLam = table.Column<DateTime>(type: "datetime", nullable: true),
                    gioRaLam = table.Column<DateTime>(type: "datetime", nullable: true),
                    tongSoGio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChamCong__3213E83F6CF0BF27", x => x.id);
                    table.ForeignKey(
                        name: "FK_ChamCong_TrangThai",
                        column: x => x.maTrangThai,
                        principalTable: "TrangThai",
                        principalColumn: "ma");
                    table.ForeignKey(
                        name: "FK__ChamCong__idNV__4BAC3F29",
                        column: x => x.idNV,
                        principalTable: "NhanVien",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "HieuSuat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idNV = table.Column<int>(type: "int", nullable: true),
                    noiDung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HieuSuat__3213E83FA2B64DE2", x => x.id);
                    table.ForeignKey(
                        name: "FK__HieuSuat__idNV__5CD6CB2B",
                        column: x => x.idNV,
                        principalTable: "NhanVien",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "KyLuatAndKhenThuong",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idNV = table.Column<int>(type: "int", nullable: true),
                    maTrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    noiDung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KyLuatAn__3213E83F8CF48620", x => x.id);
                    table.ForeignKey(
                        name: "FK_KyLuatAndKhenThuong_TrangThai",
                        column: x => x.maTrangThai,
                        principalTable: "TrangThai",
                        principalColumn: "ma");
                    table.ForeignKey(
                        name: "FK__KyLuatAndK__idNV__656C112C",
                        column: x => x.idNV,
                        principalTable: "NhanVien",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "LichSuNghiPhep",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idNV = table.Column<int>(type: "int", nullable: true),
                    idNghiPhep = table.Column<int>(type: "int", nullable: true),
                    noiDung = table.Column<string>(type: "ntext", nullable: true),
                    ngayNghi = table.Column<DateTime>(type: "date", nullable: true),
                    ngayKetThucNghi = table.Column<DateTime>(type: "date", nullable: true),
                    maTrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    deleted = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NghiPhep__3213E83F521BAF72", x => x.id);
                    table.ForeignKey(
                        name: "FK_LichSuNghiPhep_NhanVien",
                        column: x => x.idNV,
                        principalTable: "NhanVien",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Luong",
                columns: table => new
                {
                    idNV = table.Column<int>(type: "int", nullable: false),
                    luongCB = table.Column<decimal>(type: "money", nullable: true),
                    phuCap = table.Column<decimal>(type: "money", nullable: true),
                    luongTong = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Luong__3213E83F23A56B53", x => x.idNV);
                    table.ForeignKey(
                        name: "FK_Luong_NhanVien",
                        column: x => x.idNV,
                        principalTable: "NhanVien",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "NhanVienShip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idNV = table.Column<int>(type: "int", nullable: true),
                    idNNV = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhanVien__3213E83F4AAF3997", x => x.id);
                    table.ForeignKey(
                        name: "FK__NhanVienS__idNNV__7B5B524B",
                        column: x => x.idNNV,
                        principalTable: "NhomNhanVien",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__NhanVienSh__idNV__7A672E12",
                        column: x => x.idNV,
                        principalTable: "NhanVien",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "PhongBan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idNguoiQuanLi = table.Column<int>(type: "int", nullable: true),
                    namePB = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    duAnThamGia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    soLuongNVTG = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PhongBan__3213E83FC30D7C7E", x => x.id);
                    table.ForeignKey(
                        name: "FK__PhongBan__idNguo__412EB0B6",
                        column: x => x.idNguoiQuanLi,
                        principalTable: "NhanVien",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "LichSuLuong",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idNV = table.Column<int>(type: "int", nullable: true),
                    idLuong = table.Column<int>(type: "int", nullable: true),
                    idPTTT = table.Column<int>(type: "int", nullable: true),
                    soNgayNghi = table.Column<int>(type: "int", nullable: true),
                    noiDung = table.Column<string>(type: "text", nullable: true),
                    ngayThanhToan = table.Column<DateTime>(type: "datetime", nullable: true),
                    maTrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updateAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuLuong", x => x.id);
                    table.ForeignKey(
                        name: "FK_LichSuLuong_Luong",
                        column: x => x.idLuong,
                        principalTable: "Luong",
                        principalColumn: "idNV");
                    table.ForeignKey(
                        name: "FK_Table_1_NhanVien",
                        column: x => x.idNV,
                        principalTable: "NhanVien",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Table_1_TrangThai",
                        column: x => x.maTrangThai,
                        principalTable: "TrangThai",
                        principalColumn: "ma");
                });

            migrationBuilder.CreateTable(
                name: "DaoTao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idNV = table.Column<int>(type: "int", nullable: true),
                    maTrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    idPbDaoTao = table.Column<int>(type: "int", nullable: true),
                    NgayDaoTao = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayKetThucDT = table.Column<DateTime>(type: "datetime", nullable: true),
                    NdDaoTao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DaoTao__3213E83FE8BA5769", x => x.id);
                    table.ForeignKey(
                        name: "FK_DaoTao_TrangThai",
                        column: x => x.maTrangThai,
                        principalTable: "TrangThai",
                        principalColumn: "ma");
                    table.ForeignKey(
                        name: "FK__DaoTao__idNV__693CA210",
                        column: x => x.idNV,
                        principalTable: "NhanVien",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__DaoTao__idPbDaoT__6A30C649",
                        column: x => x.idPbDaoTao,
                        principalTable: "PhongBan",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "HopDongLaoDong",
                columns: table => new
                {
                    idNV = table.Column<int>(type: "int", nullable: false),
                    idLuong = table.Column<int>(type: "int", nullable: true),
                    idPB = table.Column<int>(type: "int", nullable: true),
                    maTrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    idCV = table.Column<int>(type: "int", nullable: true),
                    idVT = table.Column<int>(type: "int", nullable: true),
                    ngayLamViec = table.Column<DateTime>(type: "datetime", nullable: true),
                    ngayKetThuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDongLaoDong", x => x.idNV);
                    table.ForeignKey(
                        name: "FK_HopDongLaoDong_TrangThai",
                        column: x => x.maTrangThai,
                        principalTable: "TrangThai",
                        principalColumn: "ma");
                    table.ForeignKey(
                        name: "FK__HopDongLao__idCV__59063A47",
                        column: x => x.idCV,
                        principalTable: "CongViec",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__HopDongLao__idNV__5535A963",
                        column: x => x.idNV,
                        principalTable: "NhanVien",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__HopDongLao__idPB__571DF1D5",
                        column: x => x.idPB,
                        principalTable: "PhongBan",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__HopDongLao__idVT__59FA5E80",
                        column: x => x.idVT,
                        principalTable: "ViTri",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChamCong_idNV",
                table: "ChamCong",
                column: "idNV");

            migrationBuilder.CreateIndex(
                name: "IX_ChamCong_maTrangThai",
                table: "ChamCong",
                column: "maTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_DaoTao_idNV",
                table: "DaoTao",
                column: "idNV");

            migrationBuilder.CreateIndex(
                name: "IX_DaoTao_idPbDaoTao",
                table: "DaoTao",
                column: "idPbDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_DaoTao_maTrangThai",
                table: "DaoTao",
                column: "maTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_HieuSuat_idNV",
                table: "HieuSuat",
                column: "idNV");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongLaoDong_idCV",
                table: "HopDongLaoDong",
                column: "idCV");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongLaoDong_idPB",
                table: "HopDongLaoDong",
                column: "idPB");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongLaoDong_idVT",
                table: "HopDongLaoDong",
                column: "idVT");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongLaoDong_maTrangThai",
                table: "HopDongLaoDong",
                column: "maTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_KyLuatAndKhenThuong_idNV",
                table: "KyLuatAndKhenThuong",
                column: "idNV");

            migrationBuilder.CreateIndex(
                name: "IX_KyLuatAndKhenThuong_maTrangThai",
                table: "KyLuatAndKhenThuong",
                column: "maTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuLuong_idLuong",
                table: "LichSuLuong",
                column: "idLuong");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuLuong_idNV",
                table: "LichSuLuong",
                column: "idNV");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuLuong_maTrangThai",
                table: "LichSuLuong",
                column: "maTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuNghiPhep_idNV",
                table: "LichSuNghiPhep",
                column: "idNV");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_idCongViec",
                table: "NhanVien",
                column: "idCongViec");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_idVitri",
                table: "NhanVien",
                column: "idVitri");

            migrationBuilder.CreateIndex(
                name: "unique_maNV",
                table: "NhanVien",
                column: "maNV",
                unique: true,
                filter: "[maNV] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVienShip_idNNV",
                table: "NhanVienShip",
                column: "idNNV");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVienShip_idNV",
                table: "NhanVienShip",
                column: "idNV");

            migrationBuilder.CreateIndex(
                name: "IX_PhongBan_idNguoiQuanLi",
                table: "PhongBan",
                column: "idNguoiQuanLi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChamCong");

            migrationBuilder.DropTable(
                name: "DaoTao");

            migrationBuilder.DropTable(
                name: "HieuSuat");

            migrationBuilder.DropTable(
                name: "HopDongLaoDong");

            migrationBuilder.DropTable(
                name: "KyLuatAndKhenThuong");

            migrationBuilder.DropTable(
                name: "LichSuLuong");

            migrationBuilder.DropTable(
                name: "LichSuNghiPhep");

            migrationBuilder.DropTable(
                name: "NhanVienShip");

            migrationBuilder.DropTable(
                name: "PTTT");

            migrationBuilder.DropTable(
                name: "ThongBao");

            migrationBuilder.DropTable(
                name: "PhongBan");

            migrationBuilder.DropTable(
                name: "Luong");

            migrationBuilder.DropTable(
                name: "TrangThai");

            migrationBuilder.DropTable(
                name: "NhomNhanVien");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "CongViec");

            migrationBuilder.DropTable(
                name: "ViTri");
        }
    }
}
