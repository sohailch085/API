using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class IECChildRegionACorDC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IECChildRegionACorDC",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionSubId = table.Column<int>(type: "int", nullable: false),
                    ResistiveLoadDC = table.Column<float>(type: "real", nullable: false),
                    ResistiveLoadAC = table.Column<float>(type: "real", nullable: false),
                    CapacitiveAndIncandescentLampLoadDC = table.Column<float>(type: "real", nullable: false),
                    CapacitiveAndIncandescentLampLoadAC = table.Column<float>(type: "real", nullable: false),
                    InductiveLoadDC = table.Column<float>(type: "real", nullable: false),
                    InductiveLoadAC = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECChildRegionACorDC", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECChildRegionACorDC_IECRegionType_RegionSubId",
                        column: x => x.RegionSubId,
                        principalTable: "IECRegionType",
                        principalColumn: "Trid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IECChildRegionACorDC_RegionSubId",
                table: "IECChildRegionACorDC",
                column: "RegionSubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IECChildRegionACorDC");
        }
    }
}
