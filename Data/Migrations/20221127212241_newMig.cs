using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class newMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToWatch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToWatch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieUser",
                columns: table => new
                {
                    WatchListId = table.Column<int>(type: "int", nullable: false),
                    WatchListUsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUser", x => new { x.WatchListId, x.WatchListUsersId });
                    table.ForeignKey(
                        name: "FK_MovieUser_ToWatch_WatchListId",
                        column: x => x.WatchListId,
                        principalTable: "ToWatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUser_Users_WatchListUsersId",
                        column: x => x.WatchListUsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieUser1",
                columns: table => new
                {
                    ToWatchId = table.Column<int>(type: "int", nullable: false),
                    ToWatchUsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUser1", x => new { x.ToWatchId, x.ToWatchUsersId });
                    table.ForeignKey(
                        name: "FK_MovieUser1_ToWatch_ToWatchId",
                        column: x => x.ToWatchId,
                        principalTable: "ToWatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUser1_Users_ToWatchUsersId",
                        column: x => x.ToWatchUsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ToWatch",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "The Lord of the Rigns" },
                    { 2, "The Hobiit" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "User 1" },
                    { 2, "User 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_WatchListUsersId",
                table: "MovieUser",
                column: "WatchListUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser1_ToWatchUsersId",
                table: "MovieUser1",
                column: "ToWatchUsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieUser");

            migrationBuilder.DropTable(
                name: "MovieUser1");

            migrationBuilder.DropTable(
                name: "ToWatch");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
