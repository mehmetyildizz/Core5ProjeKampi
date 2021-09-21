using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "YorumVT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_YorumVT_BlogID",
                table: "YorumVT",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_YorumVT_BlogVT_BlogID",
                table: "YorumVT",
                column: "BlogID",
                principalTable: "BlogVT",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YorumVT_BlogVT_BlogID",
                table: "YorumVT");

            migrationBuilder.DropIndex(
                name: "IX_YorumVT_BlogID",
                table: "YorumVT");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "YorumVT");
        }
    }
}
