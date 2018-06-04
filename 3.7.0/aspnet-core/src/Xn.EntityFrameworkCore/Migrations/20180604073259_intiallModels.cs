using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Xn.Migrations
{
    public partial class intiallModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiphiDts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IdDoitac = table.Column<int>(nullable: false),
                    KeyUser = table.Column<string>(nullable: true),
                    Loai = table.Column<string>(nullable: true),
                    LoiNhuan = table.Column<double>(nullable: false),
                    NgayGhi = table.Column<DateTime>(nullable: false),
                    SoTien = table.Column<double>(nullable: false),
                    TenChiPhi = table.Column<string>(nullable: false),
                    TenDt = table.Column<string>(nullable: true),
                    TenNvGhi = table.Column<string>(nullable: true),
                    TenTx = table.Column<string>(nullable: true),
                    TenXe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiphiDts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChiPhis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    KeyUser = table.Column<string>(nullable: false),
                    NgayGhi = table.Column<DateTime>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    SoTien = table.Column<double>(nullable: false),
                    TenCp = table.Column<string>(nullable: true),
                    TenNv = table.Column<string>(nullable: true),
                    TenNvGhi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChiPhiTxes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IdUser = table.Column<string>(nullable: true),
                    KeyUser = table.Column<string>(nullable: false),
                    Logfile = table.Column<string>(nullable: true),
                    NgayGhi = table.Column<string>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    Sotien = table.Column<double>(nullable: false),
                    TenCp = table.Column<string>(nullable: true),
                    TenNvghi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhiTxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IdScurity = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    StartFounding = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CongNoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IdUserNvThuHoi = table.Column<int>(nullable: false),
                    IdUserNvghi = table.Column<int>(nullable: false),
                    IdkhNcc = table.Column<int>(nullable: false),
                    KeyUser = table.Column<string>(nullable: false),
                    Loai = table.Column<string>(nullable: true),
                    Mahang = table.Column<string>(nullable: true),
                    NgayGhi = table.Column<DateTime>(nullable: false),
                    PhaiThu = table.Column<double>(nullable: false),
                    PhaiTra = table.Column<double>(nullable: false),
                    TenKhNcc = table.Column<string>(nullable: true),
                    TenNvGhi = table.Column<string>(nullable: true),
                    TenNvThuHoi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongNoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoanhThuTxes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BatDau = table.Column<DateTime>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    DonGiaMua = table.Column<double>(nullable: false),
                    DongiaXuat = table.Column<double>(nullable: false),
                    Dvt = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IdUser = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true),
                    KetThuc = table.Column<DateTime>(nullable: false),
                    KeyUser = table.Column<string>(nullable: false),
                    Logfile = table.Column<string>(nullable: true),
                    NgayGhi = table.Column<string>(nullable: true),
                    NhanVien = table.Column<string>(nullable: true),
                    TenNvghi = table.Column<string>(nullable: true),
                    TienMat = table.Column<double>(nullable: false),
                    Tile = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoanhThuTxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoiTacs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    DienThoai = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    Ten = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoiTacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employeeses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    KeyUser = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeeses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    KeyUser = table.Column<string>(nullable: true),
                    NgayGhi = table.Column<string>(nullable: true),
                    NoiDung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: false),
                    DanhMucHang = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    DienThoai = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    KeyUser = table.Column<string>(nullable: false),
                    Loai = table.Column<string>(nullable: true),
                    NgayGhi = table.Column<DateTime>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    TenKh = table.Column<string>(nullable: true),
                    TenNv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nccs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: false),
                    DanhMucHang = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    DienThoai = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    KeyUser = table.Column<string>(nullable: false),
                    Loai = table.Column<string>(nullable: true),
                    MasoThue = table.Column<string>(nullable: true),
                    NgayGhi = table.Column<DateTime>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    TenNcc = table.Column<string>(nullable: true),
                    TenNv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nccs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChucVu = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: false),
                    DienThoai = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    KeyUser = table.Column<string>(nullable: false),
                    NgayGhi = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhanQuyens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CreUpDe = table.Column<bool>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    InOut = table.Column<bool>(nullable: false),
                    KeyUser = table.Column<string>(nullable: false),
                    NgayGhi = table.Column<DateTime>(nullable: false),
                    NvGhi = table.Column<string>(nullable: true),
                    Report = table.Column<bool>(nullable: false),
                    View1 = table.Column<bool>(nullable: false),
                    View2 = table.Column<bool>(nullable: false),
                    View3 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanQuyens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QlCongNoChiTiets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConLai = table.Column<double>(nullable: false),
                    GhiChu = table.Column<string>(nullable: false),
                    IdCty = table.Column<int>(nullable: false),
                    IdNvGhi = table.Column<int>(nullable: false),
                    MaSoPhieu = table.Column<string>(nullable: true),
                    NgayGhi = table.Column<DateTime>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    PhaiThu = table.Column<double>(nullable: false),
                    PhaiTra = table.Column<double>(nullable: false),
                    TenKhNcc = table.Column<string>(nullable: false),
                    TenNvghi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QlCongNoChiTiets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QlDoanhthus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChietKhau = table.Column<double>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    GopVon = table.Column<double>(nullable: false),
                    IdCty = table.Column<int>(nullable: false),
                    IsChiPhi = table.Column<bool>(nullable: false),
                    KeyUser = table.Column<string>(nullable: false),
                    Loai = table.Column<string>(nullable: true),
                    LoiNhuan = table.Column<double>(nullable: false),
                    NgayGop = table.Column<DateTime>(nullable: false),
                    Ten = table.Column<string>(nullable: true),
                    TenNvGhi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QlDoanhthus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QlNccs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DonGiaMua = table.Column<double>(nullable: false),
                    Dvt = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IdNcc = table.Column<int>(nullable: false),
                    IdNv = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    MaDonHang = table.Column<string>(nullable: true),
                    MaVt = table.Column<string>(nullable: true),
                    NgayGhi = table.Column<DateTime>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    TenHang = table.Column<string>(nullable: true),
                    TenNcc = table.Column<string>(nullable: true),
                    TenNv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QlNccs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QlXuatNhaps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Conlai = table.Column<double>(nullable: false),
                    IdCty = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Loai = table.Column<string>(nullable: true),
                    MaDonHang = table.Column<string>(nullable: true),
                    NgayGhi = table.Column<DateTime>(nullable: false),
                    ThanhTien = table.Column<double>(nullable: false),
                    ThanhToan = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QlXuatNhaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XuatNhaps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: false),
                    DonGiaNhap = table.Column<double>(nullable: false),
                    DonGiaXuat = table.Column<double>(nullable: false),
                    Dvt = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IdKhNcc = table.Column<string>(nullable: true),
                    KeyUser = table.Column<string>(nullable: false),
                    KhLeCty = table.Column<string>(nullable: true),
                    KhNcc = table.Column<string>(nullable: true),
                    Loai = table.Column<string>(nullable: true),
                    MaDonHang = table.Column<string>(nullable: true),
                    MaVt = table.Column<string>(nullable: true),
                    NgayChungTu = table.Column<DateTime>(nullable: false),
                    NgayghiSo = table.Column<DateTime>(nullable: false),
                    SoChungTu = table.Column<string>(nullable: true),
                    SoLuong = table.Column<int>(nullable: false),
                    TenKhNcc = table.Column<string>(nullable: true),
                    TenNv = table.Column<string>(nullable: true),
                    Tenhang = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XuatNhaps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiphiDts");

            migrationBuilder.DropTable(
                name: "ChiPhis");

            migrationBuilder.DropTable(
                name: "ChiPhiTxes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "CongNoes");

            migrationBuilder.DropTable(
                name: "DoanhThuTxes");

            migrationBuilder.DropTable(
                name: "DoiTacs");

            migrationBuilder.DropTable(
                name: "Employeeses");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "Khs");

            migrationBuilder.DropTable(
                name: "Nccs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "PhanQuyens");

            migrationBuilder.DropTable(
                name: "QlCongNoChiTiets");

            migrationBuilder.DropTable(
                name: "QlDoanhthus");

            migrationBuilder.DropTable(
                name: "QlNccs");

            migrationBuilder.DropTable(
                name: "QlXuatNhaps");

            migrationBuilder.DropTable(
                name: "XuatNhaps");
        }
    }
}
