using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLinkID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_IECDiscreteSemiconductors_LinkID",
                table: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors");

            migrationBuilder.DropIndex(
                name: "IX_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_LinkID",
                table: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors");

            migrationBuilder.DropColumn(
                name: "LinkID",
                table: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors");

            migrationBuilder.AddColumn<string>(
                name: "ConstantsType",
                table: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConstantsType",
                table: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors");

            migrationBuilder.AddColumn<int>(
                name: "LinkID",
                table: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_LinkID",
                table: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                column: "LinkID");

            migrationBuilder.AddForeignKey(
                name: "FK_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_IECDiscreteSemiconductors_LinkID",
                table: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                column: "LinkID",
                principalTable: "IECDiscreteSemiconductors",
                principalColumn: "Trid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
