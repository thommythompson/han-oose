using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HAN.ICDETool.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class klasdocentklasstudentrelatie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docent_Klas_MentorVanId",
                table: "Docent");

            migrationBuilder.AlterColumn<int>(
                name: "DocentId",
                table: "Klas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MentorVanId",
                table: "Docent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KlasId",
                table: "Docent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Docent_Klas_MentorVanId",
                table: "Docent",
                column: "MentorVanId",
                principalTable: "Klas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docent_Klas_MentorVanId",
                table: "Docent");

            migrationBuilder.AlterColumn<int>(
                name: "DocentId",
                table: "Klas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MentorVanId",
                table: "Docent",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KlasId",
                table: "Docent",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Docent_Klas_MentorVanId",
                table: "Docent",
                column: "MentorVanId",
                principalTable: "Klas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
