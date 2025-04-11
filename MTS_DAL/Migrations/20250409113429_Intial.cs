using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IECCapacitorsSubCategory",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacitorsSubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECCapacitorsSubCategory", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "IECConstantsForTemperatureDependenceOfOptoelectronicComponents",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConstantsType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ea = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECConstantsForTemperatureDependenceOfOptoelectronicComponents", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "IECConstantsForTemperatureDependenceOfRelays",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupportingConstruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A = table.Column<float>(type: "real", nullable: true),
                    Ea1 = table.Column<float>(type: "real", nullable: true),
                    Ea2 = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECConstantsForTemperatureDependenceOfRelays", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "IECDiscreteSemiconductors",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscreteSemiconductorsTypes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECDiscreteSemiconductors", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "IECInductorsTransformersAndCoils",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransformerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThetaReference = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECInductorsTransformersAndCoils", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "IECOptoelectronicComponents",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptoelectronicTypes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECOptoelectronicComponents", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "IECResistorsAndResistorNetworks",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResistorType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThetaRef = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECResistorsAndResistorNetworks", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "IECResistorsAndResistorNetworksInputType",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InputType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECResistorsAndResistorNetworksInputType", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "Lifecyclephases",
                columns: table => new
                {
                    TRID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LIFECYCLEPHASE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lifecyclephases", x => x.TRID);
                });

            migrationBuilder.CreateTable(
                name: "PredictionHandBook",
                columns: table => new
                {
                    TRID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BOOKNAME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredictionHandBook", x => x.TRID);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    TRID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRODUCTTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.TRID);
                });

            migrationBuilder.CreateTable(
                name: "R2Capacitor",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true),
                    Betaβ = table.Column<float>(type: "real", nullable: true),
                    EAOp = table.Column<float>(type: "real", nullable: true),
                    EANonOp = table.Column<float>(type: "real", nullable: true),
                    N = table.Column<float>(type: "real", nullable: true),
                    C1 = table.Column<float>(type: "real", nullable: true),
                    S1 = table.Column<float>(type: "real", nullable: true),
                    CE = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2Capacitor", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2Connectors",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2Connectors", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2Diode",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true),
                    Betaβ = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2Diode", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2Inductors",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2Inductors", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2IntegratedCircuitsPlasticEncapsulatedPackageType",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2IntegratedCircuitsPlasticEncapsulatedPackageType", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2OptoelectronicDevices",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2OptoelectronicDevices", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2PhotonicsDevices",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true),
                    NPC = table.Column<float>(type: "real", nullable: true),
                    NRH = table.Column<float>(type: "real", nullable: true),
                    NVIB = table.Column<float>(type: "real", nullable: true),
                    EaOP = table.Column<float>(type: "real", nullable: true),
                    Ea_NONOP = table.Column<float>(type: "real", nullable: true),
                    TRDefault = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2PhotonicsDevices", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2Relays",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2Relays", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2Resistors",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true),
                    TRDEFAULT = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2Resistors", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2Switches",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2Switches", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2Thyristor",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2Thyristor", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2Transformers",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2Transformers", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "R2Transistor",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true),
                    Betaβ = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2Transistor", x => x.Trid);
                });

            migrationBuilder.CreateTable(
                name: "RAMCAGE",
                columns: table => new
                {
                    CAGECDXH = table.Column<string>(type: "varchar(5)", nullable: false),
                    CANAMEXH = table.Column<string>(type: "varchar(25)", nullable: true),
                    CASTREXH = table.Column<string>(type: "varchar(25)", nullable: true),
                    CACITYXH = table.Column<string>(type: "varchar(20)", nullable: true),
                    CASTATXH = table.Column<string>(type: "varchar(2)", nullable: true),
                    CANATNXH = table.Column<string>(type: "varchar(20)", nullable: true),
                    CAPOZOXH = table.Column<string>(type: "varchar(10)", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMCAGE", x => x.CAGECDXH);
                });

            migrationBuilder.CreateTable(
                name: "IECCapacitorsTypes",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacitorsTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThetaRef = table.Column<float>(type: "real", nullable: false),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECCapacitorsTypes", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECCapacitorsTypes_IECCapacitorsSubCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "IECCapacitorsSubCategory",
                        principalColumn: "Trid");
                });

            migrationBuilder.CreateTable(
                name: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkID = table.Column<int>(type: "int", nullable: false),
                    A = table.Column<float>(type: "real", nullable: false),
                    Ea1 = table.Column<float>(type: "real", nullable: false),
                    Ea2 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_IECDiscreteSemiconductors_LinkID",
                        column: x => x.LinkID,
                        principalTable: "IECDiscreteSemiconductors",
                        principalColumn: "Trid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IECOptoelectronicComponentsSubCategory",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentsSubCategoryId = table.Column<int>(type: "int", nullable: false),
                    OptoelectronicComponentsSubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThetaRef = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECOptoelectronicComponentsSubCategory", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECOptoelectronicComponentsSubCategory_IECOptoelectronicComponents_ComponentsSubCategoryId",
                        column: x => x.ComponentsSubCategoryId,
                        principalTable: "IECOptoelectronicComponents",
                        principalColumn: "Trid");
                });

            migrationBuilder.CreateTable(
                name: "PredictionCategories",
                columns: table => new
                {
                    TRID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORYNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BOOKID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredictionCategories", x => x.TRID);
                    table.ForeignKey(
                        name: "FK_PredictionCategories_PredictionHandBook_BOOKID",
                        column: x => x.BOOKID,
                        principalTable: "PredictionHandBook",
                        principalColumn: "TRID");
                });

            migrationBuilder.CreateTable(
                name: "RAMProjects",
                columns: table => new
                {
                    PROJECTID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EIACODXA = table.Column<string>(type: "varchar(10)", nullable: true),
                    LCNTYPXB = table.Column<string>(type: "char(1)", nullable: true),
                    TYPEOFPRODUCTID = table.Column<long>(type: "bigint", nullable: true),
                    LIFECYCLEPHASEID = table.Column<long>(type: "bigint", nullable: true),
                    PROJECTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OPRLIFXA = table.Column<float>(type: "real", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROGRAMSTARTDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PROGRAMENDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMProjects", x => x.PROJECTID);
                    table.ForeignKey(
                        name: "FK_RAMProjects_Lifecyclephases_LIFECYCLEPHASEID",
                        column: x => x.LIFECYCLEPHASEID,
                        principalTable: "Lifecyclephases",
                        principalColumn: "TRID");
                    table.ForeignKey(
                        name: "FK_RAMProjects_ProductTypes_TYPEOFPRODUCTID",
                        column: x => x.TYPEOFPRODUCTID,
                        principalTable: "ProductTypes",
                        principalColumn: "TRID");
                });

            migrationBuilder.CreateTable(
                name: "R2IntegratedCircuitsPlasticEncapsulatedPartType",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LambdaOB = table.Column<float>(type: "real", nullable: true),
                    LambdaEB = table.Column<float>(type: "real", nullable: true),
                    LambdaTCB = table.Column<float>(type: "real", nullable: true),
                    LambdaIND = table.Column<float>(type: "real", nullable: true),
                    Betaβ = table.Column<float>(type: "real", nullable: true),
                    TRDEFAULT = table.Column<float>(type: "real", nullable: true),
                    PackageTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R2IntegratedCircuitsPlasticEncapsulatedPartType", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_R2IntegratedCircuitsPlasticEncapsulatedPartType_R2IntegratedCircuitsPlasticEncapsulatedPackageType_PackageTypeId",
                        column: x => x.PackageTypeId,
                        principalTable: "R2IntegratedCircuitsPlasticEncapsulatedPackageType",
                        principalColumn: "Trid");
                });

            migrationBuilder.CreateTable(
                name: "RAMPARTS",
                columns: table => new
                {
                    REFNUMHA = table.Column<string>(type: "varchar(32)", nullable: false),
                    CAGECDXH = table.Column<string>(type: "varchar(5)", nullable: true),
                    ITNAMEHA = table.Column<string>(type: "varchar(19)", nullable: true),
                    MATERLHA = table.Column<string>(type: "varchar(240)", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMPARTS", x => x.REFNUMHA);
                    table.ForeignKey(
                        name: "FK_RAMPARTS_RAMCAGE_CAGECDXH",
                        column: x => x.CAGECDXH,
                        principalTable: "RAMCAGE",
                        principalColumn: "CAGECDXH");
                });

            migrationBuilder.CreateTable(
                name: "IECConstantsForTemperatureDependenceOfCapacitor",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacitorComponent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A = table.Column<float>(type: "real", nullable: false),
                    Ea1 = table.Column<float>(type: "real", nullable: false),
                    Ea2 = table.Column<float>(type: "real", nullable: false),
                    CapacitorTypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECConstantsForTemperatureDependenceOfCapacitor", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECConstantsForTemperatureDependenceOfCapacitor_IECCapacitorsTypes_CapacitorTypeID",
                        column: x => x.CapacitorTypeID,
                        principalTable: "IECCapacitorsTypes",
                        principalColumn: "Trid");
                });

            migrationBuilder.CreateTable(
                name: "IECConstantsForVoltageDependenceOfCapacitor",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacitorType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URefDivURat = table.Column<double>(type: "float", nullable: false),
                    C2 = table.Column<double>(type: "float", nullable: false),
                    C3 = table.Column<double>(type: "float", nullable: false),
                    CapacitorTypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECConstantsForVoltageDependenceOfCapacitor", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECConstantsForVoltageDependenceOfCapacitor_IECCapacitorsTypes_CapacitorTypeID",
                        column: x => x.CapacitorTypeID,
                        principalTable: "IECCapacitorsTypes",
                        principalColumn: "Trid");
                });

            migrationBuilder.CreateTable(
                name: "IECDiscreteSemiconductorsSubcategory",
                columns: table => new
                {
                    Trid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentId = table.Column<int>(type: "int", nullable: false),
                    ConstantsTypeId = table.Column<int>(type: "int", nullable: false),
                    ComponentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThetaRef = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECDiscreteSemiconductorsSubcategory", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECDiscreteSemiconductorsSubcategory_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_ConstantsTypeId",
                        column: x => x.ConstantsTypeId,
                        principalTable: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECDiscreteSemiconductorsSubcategory_IECDiscreteSemiconductors_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "IECDiscreteSemiconductors",
                        principalColumn: "Trid");
                });

            migrationBuilder.CreateTable(
                name: "IECPredictionCapacitor",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECTID = table.Column<long>(type: "bigint", nullable: false),
                    WBS = table.Column<string>(type: "varchar(30)", nullable: false),
                    SUBCATEGORYID = table.Column<long>(type: "bigint", nullable: false),
                    TYPEID = table.Column<long>(type: "bigint", nullable: false),
                    OPERATINGVOLTAGEINV = table.Column<double>(type: "float", nullable: true),
                    RATEDVOLTAGEINV = table.Column<double>(type: "float", nullable: true),
                    AVERAGEACTUALTEMPERATURE = table.Column<double>(type: "float", nullable: true),
                    LAMBDA = table.Column<double>(type: "float", nullable: true),
                    LAMBDAREF = table.Column<double>(type: "float", nullable: true),
                    UOPDIVEDEURATE = table.Column<double>(type: "float", nullable: true),
                    PIEU = table.Column<double>(type: "float", nullable: true),
                    THETAREF = table.Column<double>(type: "float", nullable: true),
                    THETAOP = table.Column<double>(type: "float", nullable: true),
                    PIET = table.Column<double>(type: "float", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECPredictionCapacitor", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECPredictionCapacitor_IECCapacitorsSubCategory_SUBCATEGORYID",
                        column: x => x.SUBCATEGORYID,
                        principalTable: "IECCapacitorsSubCategory",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionCapacitor_IECCapacitorsTypes_TYPEID",
                        column: x => x.TYPEID,
                        principalTable: "IECCapacitorsTypes",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionCapacitor_RAMProjects_PROJECTID",
                        column: x => x.PROJECTID,
                        principalTable: "RAMProjects",
                        principalColumn: "PROJECTID");
                });

            migrationBuilder.CreateTable(
                name: "IECPredictionInductorsTransformersAndCoils",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECTID = table.Column<long>(type: "bigint", nullable: false),
                    WBS = table.Column<string>(type: "varchar(30)", nullable: true),
                    TransformerTypeId = table.Column<int>(type: "int", nullable: true),
                    OperatingFrequencyMHz = table.Column<double>(type: "float", nullable: true),
                    MaximumOperatingFrequencyMHz = table.Column<double>(type: "float", nullable: true),
                    WorstCasePowerDissipationAtMaximumFrequencyW = table.Column<double>(type: "float", nullable: true),
                    MaximumSupplyCurrentA = table.Column<double>(type: "float", nullable: true),
                    NominalVoltage = table.Column<double>(type: "float", nullable: true),
                    ThermalResistance = table.Column<double>(type: "float", nullable: true),
                    AmbientTemperature = table.Column<double>(type: "float", nullable: true),
                    Lambda = table.Column<double>(type: "float", nullable: true),
                    LambdaRef = table.Column<double>(type: "float", nullable: true),
                    PieT = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECPredictionInductorsTransformersAndCoils", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECPredictionInductorsTransformersAndCoils_IECInductorsTransformersAndCoils_TransformerTypeId",
                        column: x => x.TransformerTypeId,
                        principalTable: "IECInductorsTransformersAndCoils",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionInductorsTransformersAndCoils_RAMProjects_PROJECTID",
                        column: x => x.PROJECTID,
                        principalTable: "RAMProjects",
                        principalColumn: "PROJECTID");
                });

            migrationBuilder.CreateTable(
                name: "IECPredictionIntegratedSemiconductorCircuits",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<long>(type: "bigint", nullable: false),
                    WBS = table.Column<string>(type: "varchar(30)", nullable: false),
                    CircuitType = table.Column<int>(type: "int", nullable: false),
                    SubComponent = table.Column<int>(type: "int", nullable: false),
                    ConstantsType = table.Column<int>(type: "int", nullable: false),
                    OperatingVoltageInV = table.Column<double>(type: "float", nullable: true),
                    RatedVoltageInV = table.Column<double>(type: "float", nullable: true),
                    OperatingFrequencyMHz = table.Column<double>(type: "float", nullable: true),
                    MaximumOperatingFrequencyMHz = table.Column<double>(type: "float", nullable: true),
                    worstCasePowerDissipationAtMaximumFrequencyW = table.Column<double>(type: "float", nullable: true),
                    MaximumSupplyCurrentA = table.Column<double>(type: "float", nullable: true),
                    NominalVoltage = table.Column<double>(type: "float", nullable: true),
                    ThermalResistance = table.Column<double>(type: "float", nullable: true),
                    AmbientTemperature = table.Column<double>(type: "float", nullable: true),
                    Lambda = table.Column<double>(type: "float", nullable: true),
                    LambdaRef = table.Column<double>(type: "float", nullable: true),
                    URefDivideURat = table.Column<double>(type: "float", nullable: true),
                    PieU = table.Column<double>(type: "float", nullable: true),
                    ThetaRef = table.Column<double>(type: "float", nullable: true),
                    ThetaOp = table.Column<double>(type: "float", nullable: true),
                    PieT = table.Column<double>(type: "float", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECPredictionIntegratedSemiconductorCircuits", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECPredictionIntegratedSemiconductorCircuits_RAMProjects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "RAMProjects",
                        principalColumn: "PROJECTID");
                });

            migrationBuilder.CreateTable(
                name: "IECPredictionOptoelectronicComponent",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECTid = table.Column<long>(type: "bigint", nullable: false),
                    WBS = table.Column<string>(type: "varchar(30)", nullable: false),
                    OptoelectronicTypes = table.Column<int>(type: "int", nullable: false),
                    OptoelectronicComponentsSubCategory = table.Column<int>(type: "int", nullable: false),
                    ConstantsTypeId = table.Column<int>(type: "int", nullable: false),
                    OperatingVoltageInV = table.Column<double>(type: "float", nullable: true),
                    ReferenceVoltageInV = table.Column<double>(type: "float", nullable: true),
                    RatedVoltageInV = table.Column<double>(type: "float", nullable: true),
                    OperatingFrequencyMHz = table.Column<double>(type: "float", nullable: true),
                    MaximumOperatingFrequencyMHz = table.Column<double>(type: "float", nullable: true),
                    WorstCasePowerDissipationAtMaximumFrequencyW = table.Column<double>(type: "float", nullable: true),
                    MaximumSupplyCurrentA = table.Column<double>(type: "float", nullable: true),
                    NominalVoltage = table.Column<double>(type: "float", nullable: true),
                    ThermalResistance = table.Column<double>(type: "float", nullable: true),
                    AmbientTemperature = table.Column<double>(type: "float", nullable: true),
                    Lambda = table.Column<double>(type: "float", nullable: true),
                    LambdaRef = table.Column<double>(type: "float", nullable: true),
                    UOpDivURat = table.Column<double>(type: "float", nullable: true),
                    PieU = table.Column<double>(type: "float", nullable: true),
                    PieI = table.Column<double>(type: "float", nullable: true),
                    ThetaRef = table.Column<double>(type: "float", nullable: true),
                    ThetaOp = table.Column<double>(type: "float", nullable: true),
                    PieT = table.Column<double>(type: "float", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECPredictionOptoelectronicComponent", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECPredictionOptoelectronicComponent_IECConstantsForTemperatureDependenceOfOptoelectronicComponents_ConstantsTypeId",
                        column: x => x.ConstantsTypeId,
                        principalTable: "IECConstantsForTemperatureDependenceOfOptoelectronicComponents",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionOptoelectronicComponent_IECOptoelectronicComponentsSubCategory_OptoelectronicComponentsSubCategory",
                        column: x => x.OptoelectronicComponentsSubCategory,
                        principalTable: "IECOptoelectronicComponentsSubCategory",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionOptoelectronicComponent_IECOptoelectronicComponents_OptoelectronicTypes",
                        column: x => x.OptoelectronicTypes,
                        principalTable: "IECOptoelectronicComponents",
                        principalColumn: "Trid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IECPredictionOptoelectronicComponent_RAMProjects_PROJECTid",
                        column: x => x.PROJECTid,
                        principalTable: "RAMProjects",
                        principalColumn: "PROJECTID");
                });

            migrationBuilder.CreateTable(
                name: "IECPredictionRelays",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECTID = table.Column<long>(type: "bigint", nullable: false),
                    WBS = table.Column<string>(type: "varchar(30)", nullable: true),
                    SupportingConstructionType = table.Column<int>(type: "int", nullable: true),
                    LoadType = table.Column<int>(type: "int", nullable: true),
                    RegionType = table.Column<int>(type: "int", nullable: true),
                    NumberOfOperatingCyclesPerHour = table.Column<double>(type: "float", nullable: true),
                    ReferenceNumberOperatingCyclesPerHour = table.Column<double>(type: "float", nullable: true),
                    AmbientTemperature = table.Column<double>(type: "float", nullable: true),
                    Lambda = table.Column<double>(type: "float", nullable: true),
                    LambdaRef = table.Column<double>(type: "float", nullable: true),
                    PieEs = table.Column<double>(type: "float", nullable: true),
                    PieS = table.Column<double>(type: "float", nullable: true),
                    ThetaRef = table.Column<double>(type: "float", nullable: true),
                    ThetaOp = table.Column<double>(type: "float", nullable: true),
                    PieT = table.Column<double>(type: "float", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECPredictionRelays", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECPredictionRelays_IECConstantsForTemperatureDependenceOfRelays_SupportingConstructionType",
                        column: x => x.SupportingConstructionType,
                        principalTable: "IECConstantsForTemperatureDependenceOfRelays",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionRelays_RAMProjects_PROJECTID",
                        column: x => x.PROJECTID,
                        principalTable: "RAMProjects",
                        principalColumn: "PROJECTID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IECPredictionResistorsAndResistorNetworks",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECTID = table.Column<long>(type: "bigint", nullable: false),
                    WBS = table.Column<string>(type: "varchar(30)", nullable: true),
                    ResistorType = table.Column<int>(type: "int", nullable: true),
                    InputType = table.Column<int>(type: "int", nullable: true),
                    OperatingTemperature = table.Column<double>(type: "float", nullable: true),
                    ThetaMax = table.Column<double>(type: "float", nullable: true),
                    AmbiantTemperature = table.Column<double>(type: "float", nullable: true),
                    Lambda = table.Column<double>(type: "float", nullable: true),
                    LambdaRef = table.Column<double>(type: "float", nullable: true),
                    ThetaRef = table.Column<double>(type: "float", nullable: true),
                    ThetaOp = table.Column<double>(type: "float", nullable: true),
                    PieT = table.Column<double>(type: "float", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECPredictionResistorsAndResistorNetworks", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECPredictionResistorsAndResistorNetworks_IECResistorsAndResistorNetworksInputType_InputType",
                        column: x => x.InputType,
                        principalTable: "IECResistorsAndResistorNetworksInputType",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionResistorsAndResistorNetworks_IECResistorsAndResistorNetworks_ResistorType",
                        column: x => x.ResistorType,
                        principalTable: "IECResistorsAndResistorNetworks",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionResistorsAndResistorNetworks_RAMProjects_PROJECTID",
                        column: x => x.PROJECTID,
                        principalTable: "RAMProjects",
                        principalColumn: "PROJECTID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IECPredictionSwitchesAndPushButtonsForLowElectricalStress",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECTID = table.Column<long>(type: "bigint", nullable: false),
                    WBS = table.Column<string>(type: "varchar(30)", nullable: true),
                    RegionType = table.Column<int>(type: "int", nullable: true),
                    LoadType = table.Column<int>(type: "int", nullable: true),
                    Lambda = table.Column<double>(type: "float", nullable: true),
                    LambdaRef = table.Column<double>(type: "float", nullable: true),
                    PieEs = table.Column<double>(type: "float", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECPredictionSwitchesAndPushButtonsForLowElectricalStress", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECPredictionSwitchesAndPushButtonsForLowElectricalStress_RAMProjects_PROJECTID",
                        column: x => x.PROJECTID,
                        principalTable: "RAMProjects",
                        principalColumn: "PROJECTID");
                });

            migrationBuilder.CreateTable(
                name: "RAMBRAKDOWN",
                columns: table => new
                {
                    PWBS = table.Column<string>(type: "varchar(30)", nullable: false),
                    WBS = table.Column<string>(type: "varchar(30)", nullable: false),
                    PROJECTID = table.Column<long>(type: "bigint", nullable: false),
                    LCNAMEXB = table.Column<string>(type: "varchar(19)", nullable: true),
                    LSACONXB = table.Column<string>(type: "varchar(18)", nullable: true),
                    ALTLCNXB = table.Column<string>(type: "varchar(2)", nullable: true),
                    CAGECDXH = table.Column<string>(type: "varchar(5)", nullable: true),
                    REFNUMHA = table.Column<string>(type: "varchar(32)", nullable: true),
                    QTYASYHG = table.Column<string>(type: "varchar(4)", nullable: false),
                    REFDESHJ = table.Column<string>(type: "varchar(64)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENVIRONMENTID = table.Column<int>(type: "int", nullable: true),
                    AMBIENTOPERATINGTEMPERATURE = table.Column<float>(type: "real", nullable: true),
                    AMBIENTNONOPERATINGTEMPERATURE = table.Column<float>(type: "real", nullable: true),
                    RELATIVEHUMIDITY = table.Column<float>(type: "real", nullable: true),
                    VIBRATION = table.Column<float>(type: "real", nullable: true),
                    EQUIPMENTTYPEID = table.Column<int>(type: "INT", nullable: true),
                    DUTYCYCLE = table.Column<float>(type: "real", nullable: true),
                    CYCLERATE = table.Column<float>(type: "real", nullable: true),
                    FAILURERATE = table.Column<float>(type: "real", nullable: true),
                    FAILURERATECALCULATED = table.Column<float>(type: "real", nullable: true),
                    FAILURERATEPERCENTAGE = table.Column<float>(type: "real", nullable: true),
                    FRContribution = table.Column<float>(type: "real", nullable: true),
                    FAILURERATEOVERIDE = table.Column<bool>(type: "bit", nullable: true),
                    MTBF = table.Column<float>(type: "real", nullable: true),
                    FLAGID = table.Column<int>(type: "int", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMBRAKDOWN", x => new { x.PWBS, x.WBS });
                    table.ForeignKey(
                        name: "FK_RAMBRAKDOWN_RAMProjects_PROJECTID",
                        column: x => x.PROJECTID,
                        principalTable: "RAMProjects",
                        principalColumn: "PROJECTID");
                });

            migrationBuilder.CreateTable(
                name: "IECPredictionDiscreteSemiconductors",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<long>(type: "bigint", nullable: true),
                    WBS = table.Column<string>(type: "varchar(30)", nullable: false),
                    SubCategoryID = table.Column<int>(type: "int", nullable: false),
                    ComponentTypeID = table.Column<int>(type: "int", nullable: false),
                    ConstantsTypeID = table.Column<int>(type: "int", nullable: false),
                    OperatingVoltage = table.Column<double>(type: "float", nullable: true),
                    RatedVoltage = table.Column<double>(type: "float", nullable: true),
                    NominalVoltage = table.Column<double>(type: "float", nullable: true),
                    ThermalResistance = table.Column<double>(type: "float", nullable: true),
                    AmbientTemperature = table.Column<double>(type: "float", nullable: true),
                    MaxSupplyCurrent = table.Column<double>(type: "float", nullable: true),
                    Pfwc = table.Column<double>(type: "float", nullable: true),
                    Fop = table.Column<double>(type: "float", nullable: true),
                    Fmax = table.Column<double>(type: "float", nullable: true),
                    Lambda = table.Column<double>(type: "float", nullable: true),
                    LambdaRef = table.Column<double>(type: "float", nullable: true),
                    UopDivideUrat = table.Column<double>(type: "float", nullable: true),
                    PieU = table.Column<double>(type: "float", nullable: true),
                    ThetaRef = table.Column<double>(type: "float", nullable: true),
                    ThetaOp = table.Column<double>(type: "float", nullable: true),
                    PieT = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECPredictionDiscreteSemiconductors", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_IECPredictionDiscreteSemiconductors_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_ConstantsTypeID",
                        column: x => x.ConstantsTypeID,
                        principalTable: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionDiscreteSemiconductors_IECDiscreteSemiconductorsSubcategory_ComponentTypeID",
                        column: x => x.ComponentTypeID,
                        principalTable: "IECDiscreteSemiconductorsSubcategory",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionDiscreteSemiconductors_IECDiscreteSemiconductors_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "IECDiscreteSemiconductors",
                        principalColumn: "Trid");
                    table.ForeignKey(
                        name: "FK_IECPredictionDiscreteSemiconductors_RAMProjects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "RAMProjects",
                        principalColumn: "PROJECTID");
                });

            migrationBuilder.CreateTable(
                name: "RAMBRAKDOWNPARTS",
                columns: table => new
                {
                    Trid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PWBS = table.Column<string>(type: "varchar(30)", nullable: false),
                    WBS = table.Column<string>(type: "varchar(30)", nullable: false),
                    PROJECTID = table.Column<long>(type: "bigint", nullable: false),
                    ITNAMEHA = table.Column<string>(type: "varchar(19)", nullable: true),
                    LSACONXB = table.Column<string>(type: "varchar(18)", nullable: true),
                    ALTLCNXB = table.Column<string>(type: "varchar(2)", nullable: true),
                    CAGECDXH = table.Column<string>(type: "varchar(5)", nullable: true),
                    REFNUMHA = table.Column<string>(type: "varchar(32)", nullable: true),
                    QTYASYHG = table.Column<string>(type: "varchar(4)", nullable: true),
                    REFDESHJ = table.Column<string>(type: "varchar(64)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CALMETHODID = table.Column<long>(type: "bigint", nullable: true),
                    CATEGORYID = table.Column<long>(type: "bigint", nullable: true),
                    SUBCATEGORYID = table.Column<long>(type: "bigint", nullable: true),
                    TYPESID = table.Column<long>(type: "bigint", nullable: true),
                    FAILURERATECALCULATED = table.Column<float>(type: "real", nullable: true),
                    FAILURERATE = table.Column<double>(type: "float", nullable: true),
                    FAILURERATEPERCENTAGE = table.Column<double>(type: "float", nullable: true),
                    FRContribution = table.Column<float>(type: "real", nullable: true),
                    FAILURERATEOVERIDE = table.Column<bool>(type: "bit", nullable: true),
                    MTBF = table.Column<double>(type: "float", nullable: true),
                    FLAGID = table.Column<int>(type: "int", nullable: true),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERIDZU = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMBRAKDOWNPARTS", x => x.Trid);
                    table.ForeignKey(
                        name: "FK_RAMBRAKDOWNPARTS_RAMBRAKDOWN_PWBS_WBS",
                        columns: x => new { x.PWBS, x.WBS },
                        principalTable: "RAMBRAKDOWN",
                        principalColumns: new[] { "PWBS", "WBS" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RAMBRAKDOWNPARTS_RAMProjects_PROJECTID",
                        column: x => x.PROJECTID,
                        principalTable: "RAMProjects",
                        principalColumn: "PROJECTID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IECCapacitorsTypes_CategoryID",
                table: "IECCapacitorsTypes",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_IECConstantsForTemperatureDependenceOfCapacitor_CapacitorTypeID",
                table: "IECConstantsForTemperatureDependenceOfCapacitor",
                column: "CapacitorTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_IECConstantsForTemperatureDependenceOfDiscreteSemiconductors_LinkID",
                table: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors",
                column: "LinkID");

            migrationBuilder.CreateIndex(
                name: "IX_IECConstantsForVoltageDependenceOfCapacitor_CapacitorTypeID",
                table: "IECConstantsForVoltageDependenceOfCapacitor",
                column: "CapacitorTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_IECDiscreteSemiconductorsSubcategory_ComponentId",
                table: "IECDiscreteSemiconductorsSubcategory",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_IECDiscreteSemiconductorsSubcategory_ConstantsTypeId",
                table: "IECDiscreteSemiconductorsSubcategory",
                column: "ConstantsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IECOptoelectronicComponentsSubCategory_ComponentsSubCategoryId",
                table: "IECOptoelectronicComponentsSubCategory",
                column: "ComponentsSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionCapacitor_PROJECTID",
                table: "IECPredictionCapacitor",
                column: "PROJECTID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionCapacitor_SUBCATEGORYID",
                table: "IECPredictionCapacitor",
                column: "SUBCATEGORYID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionCapacitor_TYPEID",
                table: "IECPredictionCapacitor",
                column: "TYPEID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionDiscreteSemiconductors_ComponentTypeID",
                table: "IECPredictionDiscreteSemiconductors",
                column: "ComponentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionDiscreteSemiconductors_ConstantsTypeID",
                table: "IECPredictionDiscreteSemiconductors",
                column: "ConstantsTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionDiscreteSemiconductors_ProjectID",
                table: "IECPredictionDiscreteSemiconductors",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionDiscreteSemiconductors_SubCategoryID",
                table: "IECPredictionDiscreteSemiconductors",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionInductorsTransformersAndCoils_PROJECTID",
                table: "IECPredictionInductorsTransformersAndCoils",
                column: "PROJECTID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionInductorsTransformersAndCoils_TransformerTypeId",
                table: "IECPredictionInductorsTransformersAndCoils",
                column: "TransformerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionIntegratedSemiconductorCircuits_ProjectID",
                table: "IECPredictionIntegratedSemiconductorCircuits",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionOptoelectronicComponent_ConstantsTypeId",
                table: "IECPredictionOptoelectronicComponent",
                column: "ConstantsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionOptoelectronicComponent_OptoelectronicComponentsSubCategory",
                table: "IECPredictionOptoelectronicComponent",
                column: "OptoelectronicComponentsSubCategory");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionOptoelectronicComponent_OptoelectronicTypes",
                table: "IECPredictionOptoelectronicComponent",
                column: "OptoelectronicTypes");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionOptoelectronicComponent_PROJECTid",
                table: "IECPredictionOptoelectronicComponent",
                column: "PROJECTid");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionRelays_PROJECTID",
                table: "IECPredictionRelays",
                column: "PROJECTID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionRelays_SupportingConstructionType",
                table: "IECPredictionRelays",
                column: "SupportingConstructionType");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionResistorsAndResistorNetworks_InputType",
                table: "IECPredictionResistorsAndResistorNetworks",
                column: "InputType");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionResistorsAndResistorNetworks_PROJECTID",
                table: "IECPredictionResistorsAndResistorNetworks",
                column: "PROJECTID");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionResistorsAndResistorNetworks_ResistorType",
                table: "IECPredictionResistorsAndResistorNetworks",
                column: "ResistorType");

            migrationBuilder.CreateIndex(
                name: "IX_IECPredictionSwitchesAndPushButtonsForLowElectricalStress_PROJECTID",
                table: "IECPredictionSwitchesAndPushButtonsForLowElectricalStress",
                column: "PROJECTID");

            migrationBuilder.CreateIndex(
                name: "IX_PredictionCategories_BOOKID",
                table: "PredictionCategories",
                column: "BOOKID");

            migrationBuilder.CreateIndex(
                name: "IX_R2IntegratedCircuitsPlasticEncapsulatedPartType_PackageTypeId",
                table: "R2IntegratedCircuitsPlasticEncapsulatedPartType",
                column: "PackageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMBRAKDOWN_PROJECTID",
                table: "RAMBRAKDOWN",
                column: "PROJECTID");

            migrationBuilder.CreateIndex(
                name: "IX_RAMBRAKDOWNPARTS_PROJECTID",
                table: "RAMBRAKDOWNPARTS",
                column: "PROJECTID");

            migrationBuilder.CreateIndex(
                name: "IX_RAMBRAKDOWNPARTS_PWBS_WBS",
                table: "RAMBRAKDOWNPARTS",
                columns: new[] { "PWBS", "WBS" });

            migrationBuilder.CreateIndex(
                name: "IX_RAMPARTS_CAGECDXH",
                table: "RAMPARTS",
                column: "CAGECDXH");

            migrationBuilder.CreateIndex(
                name: "IX_RAMProjects_LIFECYCLEPHASEID",
                table: "RAMProjects",
                column: "LIFECYCLEPHASEID");

            migrationBuilder.CreateIndex(
                name: "IX_RAMProjects_TYPEOFPRODUCTID",
                table: "RAMProjects",
                column: "TYPEOFPRODUCTID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IECConstantsForTemperatureDependenceOfCapacitor");

            migrationBuilder.DropTable(
                name: "IECConstantsForVoltageDependenceOfCapacitor");

            migrationBuilder.DropTable(
                name: "IECPredictionCapacitor");

            migrationBuilder.DropTable(
                name: "IECPredictionDiscreteSemiconductors");

            migrationBuilder.DropTable(
                name: "IECPredictionInductorsTransformersAndCoils");

            migrationBuilder.DropTable(
                name: "IECPredictionIntegratedSemiconductorCircuits");

            migrationBuilder.DropTable(
                name: "IECPredictionOptoelectronicComponent");

            migrationBuilder.DropTable(
                name: "IECPredictionRelays");

            migrationBuilder.DropTable(
                name: "IECPredictionResistorsAndResistorNetworks");

            migrationBuilder.DropTable(
                name: "IECPredictionSwitchesAndPushButtonsForLowElectricalStress");

            migrationBuilder.DropTable(
                name: "PredictionCategories");

            migrationBuilder.DropTable(
                name: "R2Capacitor");

            migrationBuilder.DropTable(
                name: "R2Connectors");

            migrationBuilder.DropTable(
                name: "R2Diode");

            migrationBuilder.DropTable(
                name: "R2Inductors");

            migrationBuilder.DropTable(
                name: "R2IntegratedCircuitsPlasticEncapsulatedPartType");

            migrationBuilder.DropTable(
                name: "R2OptoelectronicDevices");

            migrationBuilder.DropTable(
                name: "R2PhotonicsDevices");

            migrationBuilder.DropTable(
                name: "R2Relays");

            migrationBuilder.DropTable(
                name: "R2Resistors");

            migrationBuilder.DropTable(
                name: "R2Switches");

            migrationBuilder.DropTable(
                name: "R2Thyristor");

            migrationBuilder.DropTable(
                name: "R2Transformers");

            migrationBuilder.DropTable(
                name: "R2Transistor");

            migrationBuilder.DropTable(
                name: "RAMBRAKDOWNPARTS");

            migrationBuilder.DropTable(
                name: "RAMPARTS");

            migrationBuilder.DropTable(
                name: "IECCapacitorsTypes");

            migrationBuilder.DropTable(
                name: "IECDiscreteSemiconductorsSubcategory");

            migrationBuilder.DropTable(
                name: "IECInductorsTransformersAndCoils");

            migrationBuilder.DropTable(
                name: "IECConstantsForTemperatureDependenceOfOptoelectronicComponents");

            migrationBuilder.DropTable(
                name: "IECOptoelectronicComponentsSubCategory");

            migrationBuilder.DropTable(
                name: "IECConstantsForTemperatureDependenceOfRelays");

            migrationBuilder.DropTable(
                name: "IECResistorsAndResistorNetworksInputType");

            migrationBuilder.DropTable(
                name: "IECResistorsAndResistorNetworks");

            migrationBuilder.DropTable(
                name: "PredictionHandBook");

            migrationBuilder.DropTable(
                name: "R2IntegratedCircuitsPlasticEncapsulatedPackageType");

            migrationBuilder.DropTable(
                name: "RAMBRAKDOWN");

            migrationBuilder.DropTable(
                name: "RAMCAGE");

            migrationBuilder.DropTable(
                name: "IECCapacitorsSubCategory");

            migrationBuilder.DropTable(
                name: "IECConstantsForTemperatureDependenceOfDiscreteSemiconductors");

            migrationBuilder.DropTable(
                name: "IECOptoelectronicComponents");

            migrationBuilder.DropTable(
                name: "RAMProjects");

            migrationBuilder.DropTable(
                name: "IECDiscreteSemiconductors");

            migrationBuilder.DropTable(
                name: "Lifecyclephases");

            migrationBuilder.DropTable(
                name: "ProductTypes");
        }
    }
}
