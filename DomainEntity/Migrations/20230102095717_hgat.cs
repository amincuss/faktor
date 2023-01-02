using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DomainEntity.Migrations
{
    /// <inheritdoc />
    public partial class hgat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InvoiceRegister",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InvoiceRegister");
        }
    }
}
