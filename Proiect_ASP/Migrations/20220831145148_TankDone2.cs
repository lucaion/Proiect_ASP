using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_ASP.Migrations
{
    public partial class TankDone2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clients_travelAgencies_TravelAgencyId1",
                table: "clients");

            migrationBuilder.DropForeignKey(
                name: "FK_travelAgencies_owners_OwnerId",
                table: "travelAgencies");

            migrationBuilder.DropForeignKey(
                name: "FK_travelAgencyOffers_offers_OfferId",
                table: "travelAgencyOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_travelAgencyOffers_travelAgencies_TravelAgencyId",
                table: "travelAgencyOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_travelAgencyOffers",
                table: "travelAgencyOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_travelAgencies",
                table: "travelAgencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_owners",
                table: "owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_offers",
                table: "offers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clients",
                table: "clients");

            migrationBuilder.RenameTable(
                name: "travelAgencyOffers",
                newName: "TravelAgencyOffers");

            migrationBuilder.RenameTable(
                name: "travelAgencies",
                newName: "TravelAgencies");

            migrationBuilder.RenameTable(
                name: "owners",
                newName: "Owners");

            migrationBuilder.RenameTable(
                name: "offers",
                newName: "Offers");

            migrationBuilder.RenameTable(
                name: "clients",
                newName: "Clients");

            migrationBuilder.RenameIndex(
                name: "IX_travelAgencyOffers_OfferId",
                table: "TravelAgencyOffers",
                newName: "IX_TravelAgencyOffers_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_travelAgencies_OwnerId",
                table: "TravelAgencies",
                newName: "IX_TravelAgencies_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_clients_TravelAgencyId1",
                table: "Clients",
                newName: "IX_Clients_TravelAgencyId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelAgencyOffers",
                table: "TravelAgencyOffers",
                columns: new[] { "TravelAgencyId", "OfferId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelAgencies",
                table: "TravelAgencies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Offers",
                table: "Offers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_TravelAgencies_TravelAgencyId1",
                table: "Clients",
                column: "TravelAgencyId1",
                principalTable: "TravelAgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelAgencies_Owners_OwnerId",
                table: "TravelAgencies",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelAgencyOffers_Offers_OfferId",
                table: "TravelAgencyOffers",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelAgencyOffers_TravelAgencies_TravelAgencyId",
                table: "TravelAgencyOffers",
                column: "TravelAgencyId",
                principalTable: "TravelAgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_TravelAgencies_TravelAgencyId1",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelAgencies_Owners_OwnerId",
                table: "TravelAgencies");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelAgencyOffers_Offers_OfferId",
                table: "TravelAgencyOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelAgencyOffers_TravelAgencies_TravelAgencyId",
                table: "TravelAgencyOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelAgencyOffers",
                table: "TravelAgencyOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelAgencies",
                table: "TravelAgencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Offers",
                table: "Offers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "TravelAgencyOffers",
                newName: "travelAgencyOffers");

            migrationBuilder.RenameTable(
                name: "TravelAgencies",
                newName: "travelAgencies");

            migrationBuilder.RenameTable(
                name: "Owners",
                newName: "owners");

            migrationBuilder.RenameTable(
                name: "Offers",
                newName: "offers");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "clients");

            migrationBuilder.RenameIndex(
                name: "IX_TravelAgencyOffers_OfferId",
                table: "travelAgencyOffers",
                newName: "IX_travelAgencyOffers_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelAgencies_OwnerId",
                table: "travelAgencies",
                newName: "IX_travelAgencies_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_TravelAgencyId1",
                table: "clients",
                newName: "IX_clients_TravelAgencyId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_travelAgencyOffers",
                table: "travelAgencyOffers",
                columns: new[] { "TravelAgencyId", "OfferId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_travelAgencies",
                table: "travelAgencies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_owners",
                table: "owners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_offers",
                table: "offers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clients",
                table: "clients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clients_travelAgencies_TravelAgencyId1",
                table: "clients",
                column: "TravelAgencyId1",
                principalTable: "travelAgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_travelAgencies_owners_OwnerId",
                table: "travelAgencies",
                column: "OwnerId",
                principalTable: "owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_travelAgencyOffers_offers_OfferId",
                table: "travelAgencyOffers",
                column: "OfferId",
                principalTable: "offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_travelAgencyOffers_travelAgencies_TravelAgencyId",
                table: "travelAgencyOffers",
                column: "TravelAgencyId",
                principalTable: "travelAgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
