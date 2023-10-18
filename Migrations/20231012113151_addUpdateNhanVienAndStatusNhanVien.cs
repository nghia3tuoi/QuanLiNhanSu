using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNS.Migrations
{
    /// <inheritdoc />
    public partial class addUpdateNhanVienAndStatusNhanVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_TrangThai_TrangThaiMa",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_TrangThaiMa",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TrangThaiMa",
                table: "NhanVien");

            migrationBuilder.AddColumn<string>(
                name: "StatusNhanVienMa",
                table: "NhanVien",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StatusNhanVien",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusNhanVien", x => x.Ma);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_StatusNhanVienMa",
                table: "NhanVien",
                column: "StatusNhanVienMa");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_StatusNhanVien_StatusNhanVienMa",
                table: "NhanVien",
                column: "StatusNhanVienMa",
                principalTable: "StatusNhanVien",
                principalColumn: "Ma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_StatusNhanVien_StatusNhanVienMa",
                table: "NhanVien");

            migrationBuilder.DropTable(
                name: "StatusNhanVien");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_StatusNhanVienMa",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "StatusNhanVienMa",
                table: "NhanVien");

            migrationBuilder.AddColumn<string>(
                name: "TrangThaiMa",
                table: "NhanVien",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_TrangThaiMa",
                table: "NhanVien",
                column: "TrangThaiMa");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_TrangThai_TrangThaiMa",
                table: "NhanVien",
                column: "TrangThaiMa",
                principalTable: "TrangThai",
                principalColumn: "ma");
        }
    }
}
