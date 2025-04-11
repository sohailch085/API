using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class IECTypeComponentSubCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IECTypeComponentSubCategory",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThetaRef = table.Column<double>(type: "float", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECTypeComponentSubCategory", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECTypeComponentSubCategory_IECTypeComponent_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "IECTypeComponent",
                        principalColumn: "Trid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IECTypeComponentSubCategory_SubCategoryId",
                table: "IECTypeComponentSubCategory",
                column: "SubCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IECTypeComponentSubCategory");
        }
    }
}
