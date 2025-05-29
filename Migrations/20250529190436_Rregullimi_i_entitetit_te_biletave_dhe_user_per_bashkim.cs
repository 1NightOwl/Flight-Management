using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightManagement.Migrations
{
    /// <inheritdoc />
    public partial class Rregullimi_i_entitetit_te_biletave_dhe_user_per_bashkim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fluturimi",
                table: "Biletat");

            migrationBuilder.AddColumn<int>(
                name: "RouteId",
                table: "Biletat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Biletat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Biletat_RouteId",
                table: "Biletat",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Biletat_UserId",
                table: "Biletat",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Biletat_Routes_RouteId",
                table: "Biletat",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Biletat_Users_UserId",
                table: "Biletat",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biletat_Routes_RouteId",
                table: "Biletat");

            migrationBuilder.DropForeignKey(
                name: "FK_Biletat_Users_UserId",
                table: "Biletat");

            migrationBuilder.DropIndex(
                name: "IX_Biletat_RouteId",
                table: "Biletat");

            migrationBuilder.DropIndex(
                name: "IX_Biletat_UserId",
                table: "Biletat");

            migrationBuilder.DropColumn(
                name: "RouteId",
                table: "Biletat");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Biletat");

            migrationBuilder.AddColumn<string>(
                name: "Fluturimi",
                table: "Biletat",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
