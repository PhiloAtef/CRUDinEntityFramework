using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment17.Migrations
{
    /// <inheritdoc />
    public partial class mappingall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructors",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Courses",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                schema: "dbo",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Cairo",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "Instructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                schema: "dbo",
                table: "Courses",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Instructors",
                schema: "dbo",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "Courses",
                schema: "dbo",
                newName: "courses");

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Cairo");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Instructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "Id");
        }
    }
}
