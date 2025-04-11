using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class IECChildRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IECChildRegion",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionSubId = table.Column<int>(type: "int", nullable: false),
                    ResistiveLoad = table.Column<float>(type: "real", nullable: false),
                    CapacitiveAndIncandescentLampLoad = table.Column<float>(type: "real", nullable: false),
                    InductiveLoad = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECChildRegion", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECChildRegion_IECRegionType_RegionSubId",
                        column: x => x.RegionSubId,
                        principalTable: "IECRegionType",
                        principalColumn: "Trid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IECChildRegion_RegionSubId",
                table: "IECChildRegion",
                column: "RegionSubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IECChildRegion");
        }
    }
}
