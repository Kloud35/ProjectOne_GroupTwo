using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoChoi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoChoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiongLoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    XuatXu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiongLoai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKH = table.Column<string>(type: "varchar(50)", nullable: false),
                    HoKH = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TenDemKH = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "Datetime", nullable: false),
                    SĐT = table.Column<string>(type: "varchar(20)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThucAn",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(10)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucAn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThuCung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuCung", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TenDem = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "DateTime", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCuaHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanVien_CuaHang_IdCuaHang",
                        column: x => x.IdCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoChoiChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDoChoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GiaNhap = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    Nsx = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoChoiChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoChoiChiTiet_DoChoi_IdDoChoi",
                        column: x => x.IdDoChoi,
                        principalTable: "DoChoi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThucAnChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdThucAn = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GiaNhap = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GiaBan = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SoLuongTon = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Nsx = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucAnChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThucAnChiTiet_ThucAn_IdThucAn",
                        column: x => x.IdThucAn,
                        principalTable: "ThucAn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThuCungChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdThuCung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGiongLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CanNang = table.Column<decimal>(type: "decimal", nullable: false),
                    ChieuDai = table.Column<decimal>(type: "decimal", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<decimal>(type: "decimal", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal", nullable: false),
                    Image = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuCungChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThuCungChiTiet_GiongLoai_IdGiongLoai",
                        column: x => x.IdGiongLoai,
                        principalTable: "GiongLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThuCungChiTiet_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThuCungChiTiet_ThuCung_IdThuCung",
                        column: x => x.IdThuCung,
                        principalTable: "ThuCung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(30)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "Datetime", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "Datetime", nullable: false),
                    NgayGiaoHang = table.Column<DateTime>(type: "Datetime", nullable: false),
                    NgayNhan = table.Column<DateTime>(type: "Datetime", nullable: false),
                    TienCoc = table.Column<decimal>(type: "decimal", nullable: false),
                    TienShip = table.Column<decimal>(type: "decimal", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    TinhTrang = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "varchar(100)", nullable: false),
                    Sdt = table.Column<string>(type: "varchar(11)", nullable: false),
                    PhanTramGiamGia = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdThuCungCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdThucAnCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDoChoiCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "Decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_DoChoiChiTiet_IdDoChoiCT",
                        column: x => x.IdDoChoiCT,
                        principalTable: "DoChoiChiTiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ThucAnChiTiet_IdThucAnCT",
                        column: x => x.IdThucAnCT,
                        principalTable: "ThucAnChiTiet",
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
                name: "IX_DoChoiChiTiet_IdDoChoi",
                table: "DoChoiChiTiet",
                column: "IdDoChoi");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdDoChoiCT",
                table: "HoaDonChiTiet",
                column: "IdDoChoiCT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdThucAnCT",
                table: "HoaDonChiTiet",
                column: "IdThucAnCT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdThuCungCT",
                table: "HoaDonChiTiet",
                column: "IdThuCungCT");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCuaHang",
                table: "NhanVien",
                column: "IdCuaHang");

            migrationBuilder.CreateIndex(
                name: "IX_ThucAnChiTiet_IdThucAn",
                table: "ThucAnChiTiet",
                column: "IdThucAn");

            migrationBuilder.CreateIndex(
                name: "IX_ThuCungChiTiet_IdGiongLoai",
                table: "ThuCungChiTiet",
                column: "IdGiongLoai");

            migrationBuilder.CreateIndex(
                name: "IX_ThuCungChiTiet_IdMauSac",
                table: "ThuCungChiTiet",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_ThuCungChiTiet_IdThuCung",
                table: "ThuCungChiTiet",
                column: "IdThuCung");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "DoChoiChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "ThucAnChiTiet");

            migrationBuilder.DropTable(
                name: "ThuCungChiTiet");

            migrationBuilder.DropTable(
                name: "DoChoi");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ThucAn");

            migrationBuilder.DropTable(
                name: "GiongLoai");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "ThuCung");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "CuaHang");
        }
    }
}
