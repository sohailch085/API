using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class IECConstantForVoltageDependence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IECConstantForVoltageDependence",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntegratedCircuit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URefDivideURat = table.Column<float>(type: "real", nullable: false),
                    URef = table.Column<float>(type: "real", nullable: false),
                    C1 = table.Column<float>(type: "real", nullable: false),
                    C2 = table.Column<float>(type: "real", nullable: false),
                    C3 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECConstantForVoltageDependence", x => x.Trid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IECConstantForVoltageDependence");
        }
    }
}
