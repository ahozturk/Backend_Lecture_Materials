using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week_6_4.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_6_instrument_picture_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Instruments",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Instruments");
        }
    }
}
