using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorEfCoreRepro.Server.Data.Migrations
{
    public partial class PhotoSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhotoSessionInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BackgroundImageUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Frames = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoSessionInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotoSessionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoSessionInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoSessionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoSessionDetails_PhotoSessionInfo_PhotoSessionInfoId",
                        column: x => x.PhotoSessionInfoId,
                        principalTable: "PhotoSessionInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhotoSessionDetails_PhotoSessionInfoId",
                table: "PhotoSessionDetails",
                column: "PhotoSessionInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhotoSessionDetails");

            migrationBuilder.DropTable(
                name: "PhotoSessionInfo");
        }
    }
}
