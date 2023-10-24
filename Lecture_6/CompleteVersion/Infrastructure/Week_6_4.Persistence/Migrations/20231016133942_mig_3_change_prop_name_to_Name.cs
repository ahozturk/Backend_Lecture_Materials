using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week_6_4.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3_change_prop_name_to_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Brands",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Brands",
                newName: "Title");
        }
    }
}
