using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.CreateTable(
                name: "HoaDonThuCungChiTiet",
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
                    table.PrimaryKey("PK_HoaDonThuCungChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonThuCungChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonThuCungChiTiet_ThuCungChiTiet_IdThuCungCT",
                        column: x => x.IdThuCungCT,
                        principalTable: "ThuCungChiTiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonThuCungChiTiet_IdHoaDon",
                table: "HoaDonThuCungChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonThuCungChiTiet_IdThuCungCT",
                table: "HoaDonThuCungChiTiet",
                column: "IdThuCungCT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonThuCungChiTiet");

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdThuCungCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<decimal>(type: "Decimal", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ThuCungChiTiet_IdThuCungCT",
                        column: x => x.IdThuCungCT,
                        principalTable: "ThuCungChiTiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdThuCungCT",
                table: "HoaDonChiTiet",
                column: "IdThuCungCT");
        }
    }
}
