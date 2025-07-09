using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DT191GProjektHotell.Migrations
{
    /// <inheritdoc />
    public partial class AddIsAnsweredToContactModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAnswered",
                table: "ContactMessages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAnswered",
                table: "ContactMessages");
        }
    }
}
