using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class test02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonDoChoiChiTiet_DoChoiChiTiet_IdThuCungCT",
                table: "HoaDonDoChoiChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonThucAnChiTiet_ThucAnChiTiet_IdThuCungCT",
                table: "HoaDonThucAnChiTiet");

            migrationBuilder.RenameColumn(
                name: "IdThuCungCT",
                table: "HoaDonThucAnChiTiet",
                newName: "IdThucAnChiTiet");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDonThucAnChiTiet_IdThuCungCT",
                table: "HoaDonThucAnChiTiet",
                newName: "IX_HoaDonThucAnChiTiet_IdThucAnChiTiet");

            migrationBuilder.RenameColumn(
                name: "IdThuCungCT",
                table: "HoaDonDoChoiChiTiet",
                newName: "IdDoChoiChiTiet");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDonDoChoiChiTiet_IdThuCungCT",
                table: "HoaDonDoChoiChiTiet",
                newName: "IX_HoaDonDoChoiChiTiet_IdDoChoiChiTiet");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonDoChoiChiTiet_DoChoiChiTiet_IdDoChoiChiTiet",
                table: "HoaDonDoChoiChiTiet",
                column: "IdDoChoiChiTiet",
                principalTable: "DoChoiChiTiet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonThucAnChiTiet_ThucAnChiTiet_IdThucAnChiTiet",
                table: "HoaDonThucAnChiTiet",
                column: "IdThucAnChiTiet",
                principalTable: "ThucAnChiTiet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonDoChoiChiTiet_DoChoiChiTiet_IdDoChoiChiTiet",
                table: "HoaDonDoChoiChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonThucAnChiTiet_ThucAnChiTiet_IdThucAnChiTiet",
                table: "HoaDonThucAnChiTiet");

            migrationBuilder.RenameColumn(
                name: "IdThucAnChiTiet",
                table: "HoaDonThucAnChiTiet",
                newName: "IdThuCungCT");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDonThucAnChiTiet_IdThucAnChiTiet",
                table: "HoaDonThucAnChiTiet",
                newName: "IX_HoaDonThucAnChiTiet_IdThuCungCT");

            migrationBuilder.RenameColumn(
                name: "IdDoChoiChiTiet",
                table: "HoaDonDoChoiChiTiet",
                newName: "IdThuCungCT");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDonDoChoiChiTiet_IdDoChoiChiTiet",
                table: "HoaDonDoChoiChiTiet",
                newName: "IX_HoaDonDoChoiChiTiet_IdThuCungCT");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonDoChoiChiTiet_DoChoiChiTiet_IdThuCungCT",
                table: "HoaDonDoChoiChiTiet",
                column: "IdThuCungCT",
                principalTable: "DoChoiChiTiet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonThucAnChiTiet_ThucAnChiTiet_IdThuCungCT",
                table: "HoaDonThucAnChiTiet",
                column: "IdThuCungCT",
                principalTable: "ThucAnChiTiet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
