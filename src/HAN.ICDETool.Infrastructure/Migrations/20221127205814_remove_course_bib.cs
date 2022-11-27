using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HAN.ICDETool.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removecoursebib : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInrichting_CourseBibliotheek_CourseBibliotheekId",
                table: "CourseInrichting");

            migrationBuilder.DropTable(
                name: "CourseBibliotheek");

            migrationBuilder.DropIndex(
                name: "IX_CourseInrichting_CourseBibliotheekId",
                table: "CourseInrichting");

            migrationBuilder.DropColumn(
                name: "CourseBibliotheekId",
                table: "CourseInrichting");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseBibliotheekId",
                table: "CourseInrichting",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CourseBibliotheek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseBibliotheek", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseInrichting_CourseBibliotheekId",
                table: "CourseInrichting",
                column: "CourseBibliotheekId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInrichting_CourseBibliotheek_CourseBibliotheekId",
                table: "CourseInrichting",
                column: "CourseBibliotheekId",
                principalTable: "CourseBibliotheek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
