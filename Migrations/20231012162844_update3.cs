using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNS.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_StatusNhanviens_StatusNhanVienMa",
                table: "NhanVien");

            migrationBuilder.RenameColumn(
                name: "StatusNhanVienMa",
                table: "NhanVien",
                newName: "maStatus");

            migrationBuilder.RenameIndex(
                name: "IX_NhanVien_StatusNhanVienMa",
                table: "NhanVien",
                newName: "IX_NhanVien_maStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_StatusNhanviens_maStatus",
                table: "NhanVien",
                column: "maStatus",
                principalTable: "StatusNhanviens",
                principalColumn: "Ma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_StatusNhanviens_maStatus",
                table: "NhanVien");

            migrationBuilder.RenameColumn(
                name: "maStatus",
                table: "NhanVien",
                newName: "StatusNhanVienMa");

            migrationBuilder.RenameIndex(
                name: "IX_NhanVien_maStatus",
                table: "NhanVien",
                newName: "IX_NhanVien_StatusNhanVienMa");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_StatusNhanviens_StatusNhanVienMa",
                table: "NhanVien",
                column: "StatusNhanVienMa",
                principalTable: "StatusNhanviens",
                principalColumn: "Ma");
        }
    }
}
