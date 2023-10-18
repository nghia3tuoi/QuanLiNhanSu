using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNS.Migrations
{
    /// <inheritdoc />
    public partial class addTrangThaiInTableNhanVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
