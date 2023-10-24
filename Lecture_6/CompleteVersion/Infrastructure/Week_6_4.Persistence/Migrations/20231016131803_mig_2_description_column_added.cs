using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week_6_4.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2_description_column_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Instruments",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Instruments");
        }
    }
}
