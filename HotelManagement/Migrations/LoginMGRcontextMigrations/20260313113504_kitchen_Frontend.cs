using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations.LoginMGRcontextMigrations
{
    /// <inheritdoc />
    public partial class kitchen_Frontend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frontend",
                columns: table => new
                {
                    user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pass_word = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frontend", x => x.user_name);
                });

            migrationBuilder.CreateTable(
                name: "Kitchen",
                columns: table => new
                {
                    user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pass_word = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchen", x => x.user_name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frontend");

            migrationBuilder.DropTable(
                name: "Kitchen");
        }
    }
}
