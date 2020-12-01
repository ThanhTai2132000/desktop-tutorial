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
                name: "DienThoai",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDongDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDongDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    GiaKM = table.Column<float>(type: "real", nullable: false),
                    DongDTMaDT = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DienThoai", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DienThoai_DongDienThoai_DongDTMaDT",
                        column: x => x.DongDTMaDT,
                        principalTable: "DongDienThoai",
                        principalColumn: "MaDT",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DienThoai_DongDTMaDT",
                table: "DienThoai",
                column: "DongDTMaDT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DienThoai");

            migrationBuilder.DropTable(
                name: "DongDienThoai");
        }
    }
}
