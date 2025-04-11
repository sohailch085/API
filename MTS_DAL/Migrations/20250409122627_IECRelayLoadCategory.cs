using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class IECRelayLoadCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IECRelayLoadCategory",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoadType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECRelayLoadCategory", x => x.Trid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IECRelayLoadCategory");
        }
    }
}
