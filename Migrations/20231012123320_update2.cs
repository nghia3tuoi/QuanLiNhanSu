using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNS.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_StatusNhanVien_StatusNhanVienMa",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusNhanVien",
                table: "StatusNhanVien");

            migrationBuilder.RenameTable(
                name: "StatusNhanVien",
                newName: "StatusNhanviens");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusNhanviens",
                table: "StatusNhanviens",
                column: "Ma");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_StatusNhanviens_StatusNhanVienMa",
                table: "NhanVien",
                column: "StatusNhanVienMa",
                principalTable: "StatusNhanviens",
                principalColumn: "Ma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_StatusNhanviens_StatusNhanVienMa",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusNhanviens",
                table: "StatusNhanviens");

            migrationBuilder.RenameTable(
                name: "StatusNhanviens",
                newName: "StatusNhanVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusNhanVien",
                table: "StatusNhanVien",
                column: "Ma");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_StatusNhanVien_StatusNhanVienMa",
                table: "NhanVien",
                column: "StatusNhanVienMa",
                principalTable: "StatusNhanVien",
                principalColumn: "Ma");
        }
    }
}
