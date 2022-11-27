using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieUser_ToWatch_WatchListId",
                table: "MovieUser");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieUser1_ToWatch_ToWatchId",
                table: "MovieUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToWatch",
                table: "ToWatch");

            migrationBuilder.RenameTable(
                name: "ToWatch",
                newName: "Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieUser_Movies_WatchListId",
                table: "MovieUser",
                column: "WatchListId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieUser1_Movies_ToWatchId",
                table: "MovieUser1",
                column: "ToWatchId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieUser_Movies_WatchListId",
                table: "MovieUser");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieUser1_Movies_ToWatchId",
                table: "MovieUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "ToWatch");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToWatch",
                table: "ToWatch",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieUser_ToWatch_WatchListId",
                table: "MovieUser",
                column: "WatchListId",
                principalTable: "ToWatch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieUser1_ToWatch_ToWatchId",
                table: "MovieUser1",
                column: "ToWatchId",
                principalTable: "ToWatch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
