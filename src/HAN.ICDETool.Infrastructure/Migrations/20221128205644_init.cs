using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HAN.ICDETool.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseInrichting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Omschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefintief = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInrichting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Docent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locatie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocatieType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opleiding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opleiding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseUitvoering",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseInrichtingId = table.Column<int>(type: "int", nullable: false),
                    StartDatum = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseUitvoering", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseUitvoering_CourseInrichting_CourseInrichtingId",
                        column: x => x.CourseInrichtingId,
                        principalTable: "CourseInrichting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseWeekPlanning",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseInrichtingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseWeekPlanning", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseWeekPlanning_CourseInrichting_CourseInrichtingId",
                        column: x => x.CourseInrichtingId,
                        principalTable: "CourseInrichting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EenheidVanLeeruitkomsten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Omschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseInrichtingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EenheidVanLeeruitkomsten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EenheidVanLeeruitkomsten_CourseInrichting_CourseInrichtingId",
                        column: x => x.CourseInrichtingId,
                        principalTable: "CourseInrichting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Klas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Klas_Docent_DocentId",
                        column: x => x.DocentId,
                        principalTable: "Docent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Straat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Huisnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Toevoeging = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plaatsnaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocatieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adres_Locatie_LocatieId",
                        column: x => x.LocatieId,
                        principalTable: "Locatie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpleidingsProfiel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpleidingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpleidingsProfiel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpleidingsProfiel_Opleiding_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleiding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseWeekInrichting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseWeekPlanningId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseWeekInrichting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseWeekInrichting_CourseWeekPlanning_CourseWeekPlanningId",
                        column: x => x.CourseWeekPlanningId,
                        principalTable: "CourseWeekPlanning",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leeruitkomst",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Omschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EenheidVanLeeruitkomstenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leeruitkomst", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leeruitkomst_EenheidVanLeeruitkomsten_EenheidVanLeeruitkomstenId",
                        column: x => x.EenheidVanLeeruitkomstenId,
                        principalTable: "EenheidVanLeeruitkomsten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpleidingsProfielId = table.Column<int>(type: "int", nullable: true),
                    CourseUitvoeringId = table.Column<int>(type: "int", nullable: true),
                    KlasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_CourseUitvoering_CourseUitvoeringId",
                        column: x => x.CourseUitvoeringId,
                        principalTable: "CourseUitvoering",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Student_Klas_KlasId",
                        column: x => x.KlasId,
                        principalTable: "Klas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Student_OpleidingsProfiel_OpleidingsProfielId",
                        column: x => x.OpleidingsProfielId,
                        principalTable: "OpleidingsProfiel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BeroepsProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weging = table.Column<int>(type: "int", nullable: false),
                    TeBehalenStudiepunten = table.Column<int>(type: "int", nullable: false),
                    CourseInrichtingId = table.Column<int>(type: "int", nullable: false),
                    CourseWeekInrichtingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeroepsProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeroepsProduct_CourseInrichting_CourseInrichtingId",
                        column: x => x.CourseInrichtingId,
                        principalTable: "CourseInrichting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BeroepsProduct_CourseWeekInrichting_CourseWeekInrichtingId",
                        column: x => x.CourseWeekInrichtingId,
                        principalTable: "CourseWeekInrichting",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CourseWeekUitvoering",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseWeekInrichtingId = table.Column<int>(type: "int", nullable: false),
                    CourseUitvoeringId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseWeekUitvoering", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseWeekUitvoering_CourseUitvoering_CourseUitvoeringId",
                        column: x => x.CourseUitvoeringId,
                        principalTable: "CourseUitvoering",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseWeekUitvoering_CourseWeekInrichting_CourseWeekInrichtingId",
                        column: x => x.CourseWeekInrichtingId,
                        principalTable: "CourseWeekInrichting",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Leerdoel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Omschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeeruitkomstId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leerdoel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leerdoel_Leeruitkomst_LeeruitkomstId",
                        column: x => x.LeeruitkomstId,
                        principalTable: "Leeruitkomst",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LesUitvoering",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocentId = table.Column<int>(type: "int", nullable: true),
                    LocatieId = table.Column<int>(type: "int", nullable: true),
                    CourseWeekUitvoeringId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LesUitvoering", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LesUitvoering_CourseWeekUitvoering_CourseWeekUitvoeringId",
                        column: x => x.CourseWeekUitvoeringId,
                        principalTable: "CourseWeekUitvoering",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LesUitvoering_Docent_DocentId",
                        column: x => x.DocentId,
                        principalTable: "Docent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LesUitvoering_Locatie_LocatieId",
                        column: x => x.LocatieId,
                        principalTable: "Locatie",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LesInrichting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseWeekInrichtingId = table.Column<int>(type: "int", nullable: true),
                    CourseInrichtingId = table.Column<int>(type: "int", nullable: false),
                    LeerdoelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LesInrichting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LesInrichting_CourseInrichting_CourseInrichtingId",
                        column: x => x.CourseInrichtingId,
                        principalTable: "CourseInrichting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LesInrichting_CourseWeekInrichting_CourseWeekInrichtingId",
                        column: x => x.CourseWeekInrichtingId,
                        principalTable: "CourseWeekInrichting",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LesInrichting_Leerdoel_LeerdoelId",
                        column: x => x.LeerdoelId,
                        principalTable: "Leerdoel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rubric",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weging = table.Column<int>(type: "int", nullable: false),
                    VoldoendeThreshold = table.Column<int>(type: "int", nullable: false),
                    KnockoutThreshold = table.Column<int>(type: "int", nullable: false),
                    LeerdoelId = table.Column<int>(type: "int", nullable: false),
                    BeroepsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubric", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rubric_BeroepsProduct_BeroepsProductId",
                        column: x => x.BeroepsProductId,
                        principalTable: "BeroepsProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rubric_Leerdoel_LeerdoelId",
                        column: x => x.LeerdoelId,
                        principalTable: "Leerdoel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SchriftelijkeToets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weging = table.Column<int>(type: "int", nullable: false),
                    TeBehalenStudiepunten = table.Column<int>(type: "int", nullable: false),
                    CourseWeekInrichtingId = table.Column<int>(type: "int", nullable: true),
                    CourseInrichtingId = table.Column<int>(type: "int", nullable: false),
                    LeerdoelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchriftelijkeToets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchriftelijkeToets_CourseInrichting_CourseInrichtingId",
                        column: x => x.CourseInrichtingId,
                        principalTable: "CourseInrichting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchriftelijkeToets_CourseWeekInrichting_CourseWeekInrichtingId",
                        column: x => x.CourseWeekInrichtingId,
                        principalTable: "CourseWeekInrichting",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SchriftelijkeToets_Leerdoel_LeerdoelId",
                        column: x => x.LeerdoelId,
                        principalTable: "Leerdoel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LesMateriaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LesInrichtingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LesMateriaal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LesMateriaal_LesInrichting_LesInrichtingId",
                        column: x => x.LesInrichtingId,
                        principalTable: "LesInrichting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeoordelingsCriteria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Omschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RubricId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeoordelingsCriteria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeoordelingsCriteria_Rubric_RubricId",
                        column: x => x.RubricId,
                        principalTable: "Rubric",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TentamenUitvoering",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchriftelijkeToetsId = table.Column<int>(type: "int", nullable: true),
                    BeroepsProductId = table.Column<int>(type: "int", nullable: true),
                    LocatieId = table.Column<int>(type: "int", nullable: true),
                    DocentId = table.Column<int>(type: "int", nullable: true),
                    CourseWeekUitvoeringId = table.Column<int>(type: "int", nullable: false),
                    CourseUitvoeringId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TentamenUitvoering", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TentamenUitvoering_BeroepsProduct_BeroepsProductId",
                        column: x => x.BeroepsProductId,
                        principalTable: "BeroepsProduct",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TentamenUitvoering_CourseWeekUitvoering_CourseWeekUitvoeringId",
                        column: x => x.CourseWeekUitvoeringId,
                        principalTable: "CourseWeekUitvoering",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TentamenUitvoering_Docent_DocentId",
                        column: x => x.DocentId,
                        principalTable: "Docent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TentamenUitvoering_Locatie_LocatieId",
                        column: x => x.LocatieId,
                        principalTable: "Locatie",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TentamenUitvoering_SchriftelijkeToets_SchriftelijkeToetsId",
                        column: x => x.SchriftelijkeToetsId,
                        principalTable: "SchriftelijkeToets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LesMateriaalLine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Line = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LesMateriaalLineId = table.Column<int>(type: "int", nullable: false),
                    LesMateriaalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LesMateriaalLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LesMateriaalLine_LesMateriaal_LesMateriaalId",
                        column: x => x.LesMateriaalId,
                        principalTable: "LesMateriaal",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Beoordeling",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TentamenUitvoeringId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    DocentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beoordeling", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beoordeling_Docent_DocentId",
                        column: x => x.DocentId,
                        principalTable: "Docent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beoordeling_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beoordeling_TentamenUitvoering_TentamenUitvoeringId",
                        column: x => x.TentamenUitvoeringId,
                        principalTable: "TentamenUitvoering",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adres_LocatieId",
                table: "Adres",
                column: "LocatieId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beoordeling_DocentId",
                table: "Beoordeling",
                column: "DocentId");

            migrationBuilder.CreateIndex(
                name: "IX_Beoordeling_StudentId",
                table: "Beoordeling",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Beoordeling_TentamenUitvoeringId",
                table: "Beoordeling",
                column: "TentamenUitvoeringId");

            migrationBuilder.CreateIndex(
                name: "IX_BeoordelingsCriteria_RubricId",
                table: "BeoordelingsCriteria",
                column: "RubricId");

            migrationBuilder.CreateIndex(
                name: "IX_BeroepsProduct_CourseInrichtingId",
                table: "BeroepsProduct",
                column: "CourseInrichtingId");

            migrationBuilder.CreateIndex(
                name: "IX_BeroepsProduct_CourseWeekInrichtingId",
                table: "BeroepsProduct",
                column: "CourseWeekInrichtingId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUitvoering_CourseInrichtingId",
                table: "CourseUitvoering",
                column: "CourseInrichtingId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseWeekInrichting_CourseWeekPlanningId",
                table: "CourseWeekInrichting",
                column: "CourseWeekPlanningId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseWeekPlanning_CourseInrichtingId",
                table: "CourseWeekPlanning",
                column: "CourseInrichtingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseWeekUitvoering_CourseUitvoeringId",
                table: "CourseWeekUitvoering",
                column: "CourseUitvoeringId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseWeekUitvoering_CourseWeekInrichtingId",
                table: "CourseWeekUitvoering",
                column: "CourseWeekInrichtingId");

            migrationBuilder.CreateIndex(
                name: "IX_EenheidVanLeeruitkomsten_CourseInrichtingId",
                table: "EenheidVanLeeruitkomsten",
                column: "CourseInrichtingId");

            migrationBuilder.CreateIndex(
                name: "IX_Klas_DocentId",
                table: "Klas",
                column: "DocentId",
                unique: true,
                filter: "[DocentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Leerdoel_LeeruitkomstId",
                table: "Leerdoel",
                column: "LeeruitkomstId");

            migrationBuilder.CreateIndex(
                name: "IX_Leeruitkomst_EenheidVanLeeruitkomstenId",
                table: "Leeruitkomst",
                column: "EenheidVanLeeruitkomstenId");

            migrationBuilder.CreateIndex(
                name: "IX_LesInrichting_CourseInrichtingId",
                table: "LesInrichting",
                column: "CourseInrichtingId");

            migrationBuilder.CreateIndex(
                name: "IX_LesInrichting_CourseWeekInrichtingId",
                table: "LesInrichting",
                column: "CourseWeekInrichtingId");

            migrationBuilder.CreateIndex(
                name: "IX_LesInrichting_LeerdoelId",
                table: "LesInrichting",
                column: "LeerdoelId");

            migrationBuilder.CreateIndex(
                name: "IX_LesMateriaal_LesInrichtingId",
                table: "LesMateriaal",
                column: "LesInrichtingId");

            migrationBuilder.CreateIndex(
                name: "IX_LesMateriaalLine_LesMateriaalId",
                table: "LesMateriaalLine",
                column: "LesMateriaalId");

            migrationBuilder.CreateIndex(
                name: "IX_LesUitvoering_CourseWeekUitvoeringId",
                table: "LesUitvoering",
                column: "CourseWeekUitvoeringId");

            migrationBuilder.CreateIndex(
                name: "IX_LesUitvoering_DocentId",
                table: "LesUitvoering",
                column: "DocentId");

            migrationBuilder.CreateIndex(
                name: "IX_LesUitvoering_LocatieId",
                table: "LesUitvoering",
                column: "LocatieId");

            migrationBuilder.CreateIndex(
                name: "IX_OpleidingsProfiel_OpleidingId",
                table: "OpleidingsProfiel",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Rubric_BeroepsProductId",
                table: "Rubric",
                column: "BeroepsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Rubric_LeerdoelId",
                table: "Rubric",
                column: "LeerdoelId");

            migrationBuilder.CreateIndex(
                name: "IX_SchriftelijkeToets_CourseInrichtingId",
                table: "SchriftelijkeToets",
                column: "CourseInrichtingId");

            migrationBuilder.CreateIndex(
                name: "IX_SchriftelijkeToets_CourseWeekInrichtingId",
                table: "SchriftelijkeToets",
                column: "CourseWeekInrichtingId");

            migrationBuilder.CreateIndex(
                name: "IX_SchriftelijkeToets_LeerdoelId",
                table: "SchriftelijkeToets",
                column: "LeerdoelId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CourseUitvoeringId",
                table: "Student",
                column: "CourseUitvoeringId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_KlasId",
                table: "Student",
                column: "KlasId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_OpleidingsProfielId",
                table: "Student",
                column: "OpleidingsProfielId");

            migrationBuilder.CreateIndex(
                name: "IX_TentamenUitvoering_BeroepsProductId",
                table: "TentamenUitvoering",
                column: "BeroepsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TentamenUitvoering_CourseWeekUitvoeringId",
                table: "TentamenUitvoering",
                column: "CourseWeekUitvoeringId");

            migrationBuilder.CreateIndex(
                name: "IX_TentamenUitvoering_DocentId",
                table: "TentamenUitvoering",
                column: "DocentId");

            migrationBuilder.CreateIndex(
                name: "IX_TentamenUitvoering_LocatieId",
                table: "TentamenUitvoering",
                column: "LocatieId");

            migrationBuilder.CreateIndex(
                name: "IX_TentamenUitvoering_SchriftelijkeToetsId",
                table: "TentamenUitvoering",
                column: "SchriftelijkeToetsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropTable(
                name: "Beoordeling");

            migrationBuilder.DropTable(
                name: "BeoordelingsCriteria");

            migrationBuilder.DropTable(
                name: "LesMateriaalLine");

            migrationBuilder.DropTable(
                name: "LesUitvoering");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "TentamenUitvoering");

            migrationBuilder.DropTable(
                name: "Rubric");

            migrationBuilder.DropTable(
                name: "LesMateriaal");

            migrationBuilder.DropTable(
                name: "Klas");

            migrationBuilder.DropTable(
                name: "OpleidingsProfiel");

            migrationBuilder.DropTable(
                name: "CourseWeekUitvoering");

            migrationBuilder.DropTable(
                name: "Locatie");

            migrationBuilder.DropTable(
                name: "SchriftelijkeToets");

            migrationBuilder.DropTable(
                name: "BeroepsProduct");

            migrationBuilder.DropTable(
                name: "LesInrichting");

            migrationBuilder.DropTable(
                name: "Docent");

            migrationBuilder.DropTable(
                name: "Opleiding");

            migrationBuilder.DropTable(
                name: "CourseUitvoering");

            migrationBuilder.DropTable(
                name: "CourseWeekInrichting");

            migrationBuilder.DropTable(
                name: "Leerdoel");

            migrationBuilder.DropTable(
                name: "CourseWeekPlanning");

            migrationBuilder.DropTable(
                name: "Leeruitkomst");

            migrationBuilder.DropTable(
                name: "EenheidVanLeeruitkomsten");

            migrationBuilder.DropTable(
                name: "CourseInrichting");
        }
    }
}
