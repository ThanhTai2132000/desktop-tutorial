﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAn.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DongDienThoai",
                columns: table => new
                {
                    MaDT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenDongDT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongDienThoai", x => x.MaDT);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaTK = table.Column<int>(type: "int", nullable: false),
                    NgayLapHD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                });

            migrationBuilder.CreateTable(
                name: "DienThoai",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaDongDT = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    GiaKM = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DienThoai", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DienThoai_DongDienThoai_MaDongDT",
                        column: x => x.MaDongDT,
                        principalTable: "DongDienThoai",
                        principalColumn: "MaDT",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    GiaKhuyenMai = table.Column<float>(type: "real", nullable: false),
                    HoaDonMaHD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DienThoaiID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_DienThoai_DienThoaiID",
                        column: x => x.DienThoaiID,
                        principalTable: "DienThoai",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_HoaDonMaHD",
                        column: x => x.HoaDonMaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_DienThoaiID",
                table: "ChiTietHoaDon",
                column: "DienThoaiID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_HoaDonMaHD",
                table: "ChiTietHoaDon",
                column: "HoaDonMaHD");

            migrationBuilder.CreateIndex(
                name: "IX_DienThoai_MaDongDT",
                table: "DienThoai",
                column: "MaDongDT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "DienThoai");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "DongDienThoai");
        }
    }
}
