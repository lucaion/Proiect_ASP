using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_ASP.Migrations
{
    public partial class finalfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelAgencies_Owners_OwnerId",
                table: "TravelAgencies");

            migrationBuilder.DropIndex(
                name: "IX_TravelAgencies_OwnerId",
                table: "TravelAgencies");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "TravelAgencies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelAgencies_OwnerId",
                table: "TravelAgencies",
                column: "OwnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelAgencies_Owners_OwnerId",
                table: "TravelAgencies",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelAgencies_Owners_OwnerId",
                table: "TravelAgencies");

            migrationBuilder.DropIndex(
                name: "IX_TravelAgencies_OwnerId",
                table: "TravelAgencies");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "TravelAgencies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_TravelAgencies_OwnerId",
                table: "TravelAgencies",
                column: "OwnerId",
                unique: true,
                filter: "[OwnerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelAgencies_Owners_OwnerId",
                table: "TravelAgencies",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
