using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class initialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieUser1_Movies_ToWatchId",
                table: "MovieUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieUser1",
                table: "MovieUser1");

            migrationBuilder.DropIndex(
                name: "IX_MovieUser1_ToWatchUsersId",
                table: "MovieUser1");

            migrationBuilder.RenameColumn(
                name: "ToWatchId",
                table: "MovieUser1",
                newName: "WatchedMoviesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieUser1",
                table: "MovieUser1",
                columns: new[] { "ToWatchUsersId", "WatchedMoviesId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser1_WatchedMoviesId",
                table: "MovieUser1",
                column: "WatchedMoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieUser1_Movies_WatchedMoviesId",
                table: "MovieUser1",
                column: "WatchedMoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieUser1_Movies_WatchedMoviesId",
                table: "MovieUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieUser1",
                table: "MovieUser1");

            migrationBuilder.DropIndex(
                name: "IX_MovieUser1_WatchedMoviesId",
                table: "MovieUser1");

            migrationBuilder.RenameColumn(
                name: "WatchedMoviesId",
                table: "MovieUser1",
                newName: "ToWatchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieUser1",
                table: "MovieUser1",
                columns: new[] { "ToWatchId", "ToWatchUsersId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser1_ToWatchUsersId",
                table: "MovieUser1",
                column: "ToWatchUsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieUser1_Movies_ToWatchId",
                table: "MovieUser1",
                column: "ToWatchId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
