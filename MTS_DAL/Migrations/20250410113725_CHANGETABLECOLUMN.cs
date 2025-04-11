using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class CHANGETABLECOLUMN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComponentType",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "TYPES");

            migrationBuilder.RenameColumn(
                name: "DiscreteSemiconductorsTypes",
                table: "IECDiscreteSemiconductors",
                newName: "SUBCATEGORY");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TYPES",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "ComponentType");

            migrationBuilder.RenameColumn(
                name: "SUBCATEGORY",
                table: "IECDiscreteSemiconductors",
                newName: "DiscreteSemiconductorsTypes");
        }
    }
}
