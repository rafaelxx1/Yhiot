using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yhiot.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userName = table.Column<string>(type: "TEXT", nullable: true),
                    userPassword = table.Column<string>(type: "TEXT", nullable: true),
                    userAut = table.Column<string>(type: "TEXT", nullable: true),
                    userInterface = table.Column<string>(type: "TEXT", nullable: true),
                    data = table.Column<string>(type: "TEXT", nullable: true),
                    userEmail = table.Column<string>(type: "TEXT", nullable: true),
                    userCpf = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
