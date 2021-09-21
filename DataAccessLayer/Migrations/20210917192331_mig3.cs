using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriID",
                table: "BlogVT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BlogVT_KategoriID",
                table: "BlogVT",
                column: "KategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogVT_KategoriVT_KategoriID",
                table: "BlogVT",
                column: "KategoriID",
                principalTable: "KategoriVT",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogVT_KategoriVT_KategoriID",
                table: "BlogVT");

            migrationBuilder.DropIndex(
                name: "IX_BlogVT_KategoriID",
                table: "BlogVT");

            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "BlogVT");
        }
    }
}
