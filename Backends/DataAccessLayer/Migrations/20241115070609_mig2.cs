using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_MentorSkill_Rate",
                table: "MentorSkills");

            migrationBuilder.DropColumn(
                name: "IconPath",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SocialMedias");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "SocialMedias",
                newName: "ClassName");

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "MentorSkills",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ArticleContents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "ClassName",
                table: "SocialMedias",
                newName: "Url");

            migrationBuilder.AddColumn<string>(
                name: "IconPath",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "MentorSkills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "ArticleContents",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddCheckConstraint(
                name: "CK_MentorSkill_Rate",
                table: "MentorSkills",
                sql: "[Rate] >= 0 AND [Rate] <= 100");
        }
    }
}
