using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogVT",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogKucukResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogOlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogVT", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "HakkindaVT",
                columns: table => new
                {
                    HakkindaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkindaDetay1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaDetay2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaResim1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaResim2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaHaritaKonum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HakkindaVT", x => x.HakkindaID);
                });

            migrationBuilder.CreateTable(
                name: "IletisimVT",
                columns: table => new
                {
                    IletisimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IletisimKullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimEposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimMesaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IletisimDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimVT", x => x.IletisimID);
                });

            migrationBuilder.CreateTable(
                name: "KategoriVT",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriVT", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "YazarVT",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarEposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarHakkinda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarDurum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YazarVT", x => x.YazarID);
                });

            migrationBuilder.CreateTable(
                name: "YorumVT",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumKullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YorumDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YorumVT", x => x.YorumID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogVT");

            migrationBuilder.DropTable(
                name: "HakkindaVT");

            migrationBuilder.DropTable(
                name: "IletisimVT");

            migrationBuilder.DropTable(
                name: "KategoriVT");

            migrationBuilder.DropTable(
                name: "YazarVT");

            migrationBuilder.DropTable(
                name: "YorumVT");
        }
    }
}
