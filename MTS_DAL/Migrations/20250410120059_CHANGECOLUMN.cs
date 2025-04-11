using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class CHANGECOLUMN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IECDiscreteSemiconductorsSubcategory_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_ConstantsTypeId",
                table: "IECDiscreteSemiconductorsSubcategory");

            migrationBuilder.DropForeignKey(
                name: "FK_IECDiscreteSemiconductorsSubcategory_IECDiscreteSemiconductors_ComponentId",
                table: "IECDiscreteSemiconductorsSubcategory");

            migrationBuilder.DropForeignKey(
                name: "FK_IECPredictionDiscreteSemiconductors_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_ConstantsTypeID",
                table: "IECPredictionDiscreteSemiconductors");

            migrationBuilder.DropForeignKey(
                name: "FK_IECPredictionDiscreteSemiconductors_IECDiscreteSemiconductorsSubcategory_ComponentTypeID",
                table: "IECPredictionDiscreteSemiconductors");

            migrationBuilder.DropForeignKey(
                name: "FK_IECPredictionDiscreteSemiconductors_IECDiscreteSemiconductors_SubCategoryID",
                table: "IECPredictionDiscreteSemiconductors");

            migrationBuilder.DropIndex(
                name: "IX_IECPredictionDiscreteSemiconductors_ComponentTypeID",
                table: "IECPredictionDiscreteSemiconductors");

            migrationBuilder.DropColumn(
                name: "ComponentTypeID",
                table: "IECPredictionDiscreteSemiconductors");

            migrationBuilder.RenameColumn(
                name: "SubCategoryID",
                table: "IECPredictionDiscreteSemiconductors",
                newName: "SUBCATEGORYID");

            migrationBuilder.RenameColumn(
                name: "ConstantsTypeID",
                table: "IECPredictionDiscreteSemiconductors",
                newName: "TYPESID");

            migrationBuilder.RenameIndex(
                name: "IX_IECPredictionDiscreteSemiconductors_SubCategoryID",
                table: "IECPredictionDiscreteSemiconductors",
                newName: "IX_IECPredictionDiscreteSemiconductors_SUBCATEGORYID");

            migrationBuilder.RenameIndex(
                name: "IX_IECPredictionDiscreteSemiconductors_ConstantsTypeID",
                table: "IECPredictionDiscreteSemiconductors",
                newName: "IX_IECPredictionDiscreteSemiconductors_TYPESID");

            migrationBuilder.RenameColumn(
                name: "ThetaRef",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "THETAREF");

            migrationBuilder.RenameColumn(
                name: "ConstantsTypeId",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "CONSTANTSTYPEID");

            migrationBuilder.RenameColumn(
                name: "ComponentId",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "SUBCATEGORYID");

            migrationBuilder.RenameIndex(
                name: "IX_IECDiscreteSemiconductorsSubcategory_ConstantsTypeId",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "IX_IECDiscreteSemiconductorsSubcategory_CONSTANTSTYPEID");

            migrationBuilder.RenameIndex(
                name: "IX_IECDiscreteSemiconductorsSubcategory_ComponentId",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "IX_IECDiscreteSemiconductorsSubcategory_SUBCATEGORYID");

            migrationBuilder.AddForeignKey(
                name: "FK_IECDiscreteSemiconductorsSubcategory_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_CONSTANTSTYPEID",
                table: "IECDiscreteSemiconductorsSubcategory",
                column: "CONSTANTSTYPEID",
                principalTable: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                principalColumn: "Trid");

            migrationBuilder.AddForeignKey(
                name: "FK_IECDiscreteSemiconductorsSubcategory_IECDiscreteSemiconductors_SUBCATEGORYID",
                table: "IECDiscreteSemiconductorsSubcategory",
                column: "SUBCATEGORYID",
                principalTable: "IECDiscreteSemiconductors",
                principalColumn: "Trid");

            migrationBuilder.AddForeignKey(
                name: "FK_IECPredictionDiscreteSemiconductors_IECDiscreteSemiconductorsSubcategory_TYPESID",
                table: "IECPredictionDiscreteSemiconductors",
                column: "TYPESID",
                principalTable: "IECDiscreteSemiconductorsSubcategory",
                principalColumn: "Trid");

            migrationBuilder.AddForeignKey(
                name: "FK_IECPredictionDiscreteSemiconductors_IECDiscreteSemiconductors_SUBCATEGORYID",
                table: "IECPredictionDiscreteSemiconductors",
                column: "SUBCATEGORYID",
                principalTable: "IECDiscreteSemiconductors",
                principalColumn: "Trid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IECDiscreteSemiconductorsSubcategory_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_CONSTANTSTYPEID",
                table: "IECDiscreteSemiconductorsSubcategory");

            migrationBuilder.DropForeignKey(
                name: "FK_IECDiscreteSemiconductorsSubcategory_IECDiscreteSemiconductors_SUBCATEGORYID",
                table: "IECDiscreteSemiconductorsSubcategory");

            migrationBuilder.DropForeignKey(
                name: "FK_IECPredictionDiscreteSemiconductors_IECDiscreteSemiconductorsSubcategory_TYPESID",
                table: "IECPredictionDiscreteSemiconductors");

            migrationBuilder.DropForeignKey(
                name: "FK_IECPredictionDiscreteSemiconductors_IECDiscreteSemiconductors_SUBCATEGORYID",
                table: "IECPredictionDiscreteSemiconductors");

            migrationBuilder.RenameColumn(
                name: "SUBCATEGORYID",
                table: "IECPredictionDiscreteSemiconductors",
                newName: "SubCategoryID");

            migrationBuilder.RenameColumn(
                name: "TYPESID",
                table: "IECPredictionDiscreteSemiconductors",
                newName: "ConstantsTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_IECPredictionDiscreteSemiconductors_SUBCATEGORYID",
                table: "IECPredictionDiscreteSemiconductors",
                newName: "IX_IECPredictionDiscreteSemiconductors_SubCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_IECPredictionDiscreteSemiconductors_TYPESID",
                table: "IECPredictionDiscreteSemiconductors",
                newName: "IX_IECPredictionDiscreteSemiconductors_ConstantsTypeID");

            migrationBuilder.RenameColumn(
                name: "THETAREF",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "ThetaRef");

            migrationBuilder.RenameColumn(
                name: "CONSTANTSTYPEID",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "ConstantsTypeId");

            migrationBuilder.RenameColumn(
                name: "SUBCATEGORYID",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "ComponentId");

            migrationBuilder.RenameIndex(
                name: "IX_IECDiscreteSemiconductorsSubcategory_CONSTANTSTYPEID",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "IX_IECDiscreteSemiconductorsSubcategory_ConstantsTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_IECDiscreteSemiconductorsSubcategory_SUBCATEGORYID",
                table: "IECDiscreteSemiconductorsSubcategory",
                newName: "IX_IECDiscreteSemiconductorsSubcategory_ComponentId");

            migrationBuilder.AddColumn<int>(
                name: "ComponentTypeID",
                table: "IECPredictionDiscreteSemiconductors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionDiscreteSemiconductors_ComponentTypeID",
                table: "IECPredictionDiscreteSemiconductors",
                column: "ComponentTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_IECDiscreteSemiconductorsSubcategory_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_ConstantsTypeId",
                table: "IECDiscreteSemiconductorsSubcategory",
                column: "ConstantsTypeId",
                principalTable: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                principalColumn: "Trid");

            migrationBuilder.AddForeignKey(
                name: "FK_IECDiscreteSemiconductorsSubcategory_IECDiscreteSemiconductors_ComponentId",
                table: "IECDiscreteSemiconductorsSubcategory",
                column: "ComponentId",
                principalTable: "IECDiscreteSemiconductors",
                principalColumn: "Trid");

            migrationBuilder.AddForeignKey(
                name: "FK_IECPredictionDiscreteSemiconductors_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_ConstantsTypeID",
                table: "IECPredictionDiscreteSemiconductors",
                column: "ConstantsTypeID",
                principalTable: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                principalColumn: "Trid");

            migrationBuilder.AddForeignKey(
                name: "FK_IECPredictionDiscreteSemiconductors_IECDiscreteSemiconductorsSubcategory_ComponentTypeID",
                table: "IECPredictionDiscreteSemiconductors",
                column: "ComponentTypeID",
                principalTable: "IECDiscreteSemiconductorsSubcategory",
                principalColumn: "Trid");

            migrationBuilder.AddForeignKey(
                name: "FK_IECPredictionDiscreteSemiconductors_IECDiscreteSemiconductors_SubCategoryID",
                table: "IECPredictionDiscreteSemiconductors",
                column: "SubCategoryID",
                principalTable: "IECDiscreteSemiconductors",
                principalColumn: "Trid");
        }
    }
}
