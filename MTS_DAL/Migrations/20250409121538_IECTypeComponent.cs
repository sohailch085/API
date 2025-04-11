using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class IECTypeComponent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IECTypeComponent",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECTypeComponent", x => x.Trid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IECTypeComponent");
        }
    }
}
