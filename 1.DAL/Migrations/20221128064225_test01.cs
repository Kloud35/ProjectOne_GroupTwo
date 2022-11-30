using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class test01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_DoChoiChiTiet_IdDoChoiCT",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_ThucAnChiTiet_IdThucAnCT",
                table: "HoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiet_IdDoChoiCT",
                table: "HoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiet_IdThucAnCT",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "IdDoChoiCT",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "IdThucAnCT",
                table: "HoaDonChiTiet");

            migrationBuilder.CreateTable(
                name: "HoaDonDoChoiChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdThuCungCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "Decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonDoChoiChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonDoChoiChiTiet_DoChoiChiTiet_IdThuCungCT",
                        column: x => x.IdThuCungCT,
                        principalTable: "DoChoiChiTiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonDoChoiChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonThucAnChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdThuCungCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "Decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonThucAnChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonThucAnChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonThucAnChiTiet_ThucAnChiTiet_IdThuCungCT",
                        column: x => x.IdThuCungCT,
                        principalTable: "ThucAnChiTiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonDoChoiChiTiet_IdHoaDon",
                table: "HoaDonDoChoiChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonDoChoiChiTiet_IdThuCungCT",
                table: "HoaDonDoChoiChiTiet",
                column: "IdThuCungCT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonThucAnChiTiet_IdHoaDon",
                table: "HoaDonThucAnChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonThucAnChiTiet_IdThuCungCT",
                table: "HoaDonThucAnChiTiet",
                column: "IdThuCungCT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonDoChoiChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDonThucAnChiTiet");

            migrationBuilder.AddColumn<Guid>(
                name: "IdDoChoiCT",
                table: "HoaDonChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdThucAnCT",
                table: "HoaDonChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdDoChoiCT",
                table: "HoaDonChiTiet",
                column: "IdDoChoiCT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdThucAnCT",
                table: "HoaDonChiTiet",
                column: "IdThucAnCT");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_DoChoiChiTiet_IdDoChoiCT",
                table: "HoaDonChiTiet",
                column: "IdDoChoiCT",
                principalTable: "DoChoiChiTiet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_ThucAnChiTiet_IdThucAnCT",
                table: "HoaDonChiTiet",
                column: "IdThucAnCT",
                principalTable: "ThucAnChiTiet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
