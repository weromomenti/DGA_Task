using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieUser_Movies_WatchlistId",
                table: "MovieUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieUser",
                table: "MovieUser");

            migrationBuilder.DropIndex(
                name: "IX_MovieUser_WatchlistId",
                table: "MovieUser");

            migrationBuilder.RenameColumn(
                name: "WatchlistId",
                table: "MovieUser",
                newName: "MoviesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieUser",
                table: "MovieUser",
                columns: new[] { "MoviesId", "UsersId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_UsersId",
                table: "MovieUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieUser_Movies_MoviesId",
                table: "MovieUser",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieUser_Movies_MoviesId",
                table: "MovieUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieUser",
                table: "MovieUser");

            migrationBuilder.DropIndex(
                name: "IX_MovieUser_UsersId",
                table: "MovieUser");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "MovieUser",
                newName: "WatchlistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieUser",
                table: "MovieUser",
                columns: new[] { "UsersId", "WatchlistId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_WatchlistId",
                table: "MovieUser",
                column: "WatchlistId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieUser_Movies_WatchlistId",
                table: "MovieUser",
                column: "WatchlistId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
