using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class UPDATETABLE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IECCapacitorsTypes_IECCapacitorsSubCategory_CategoryID",
                table: "IECCapacitorsTypes");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "IECCapacitorsTypes",
                newName: "CATEGORYID");

            migrationBuilder.RenameColumn(
                name: "CapacitorsTypes",
                table: "IECCapacitorsTypes",
                newName: "TYPES");

            migrationBuilder.RenameIndex(
                name: "IX_IECCapacitorsTypes_CategoryID",
                table: "IECCapacitorsTypes",
                newName: "IX_IECCapacitorsTypes_CATEGORYID");

            migrationBuilder.RenameColumn(
                name: "CapacitorsSubCategory",
                table: "IECCapacitorsSubCategory",
                newName: "SUBCATEGORY");

            migrationBuilder.AddForeignKey(
                name: "FK_IECCapacitorsTypes_IECCapacitorsSubCategory_CATEGORYID",
                table: "IECCapacitorsTypes",
                column: "CATEGORYID",
                principalTable: "IECCapacitorsSubCategory",
                principalColumn: "Trid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IECCapacitorsTypes_IECCapacitorsSubCategory_CATEGORYID",
                table: "IECCapacitorsTypes");

            migrationBuilder.RenameColumn(
                name: "CATEGORYID",
                table: "IECCapacitorsTypes",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "TYPES",
                table: "IECCapacitorsTypes",
                newName: "CapacitorsTypes");

            migrationBuilder.RenameIndex(
                name: "IX_IECCapacitorsTypes_CATEGORYID",
                table: "IECCapacitorsTypes",
                newName: "IX_IECCapacitorsTypes_CategoryID");

            migrationBuilder.RenameColumn(
                name: "SUBCATEGORY",
                table: "IECCapacitorsSubCategory",
                newName: "CapacitorsSubCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_IECCapacitorsTypes_IECCapacitorsSubCategory_CategoryID",
                table: "IECCapacitorsTypes",
                column: "CategoryID",
                principalTable: "IECCapacitorsSubCategory",
                principalColumn: "Trid");
        }
    }
}
