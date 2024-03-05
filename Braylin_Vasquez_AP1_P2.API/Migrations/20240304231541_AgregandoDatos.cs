using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Braylin_Vasquez_AP1_P2.API.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Costo",
                table: "Vehiculos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                table: "Vehiculos");
        }
    }
}
