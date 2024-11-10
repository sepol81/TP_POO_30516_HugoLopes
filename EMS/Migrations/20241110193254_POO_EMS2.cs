using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Migrations
{
    /// <inheritdoc />
    public partial class POO_EMS2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Equipments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EventId",
                table: "Vehicles",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_EventId",
                table: "Teams",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_EventId",
                table: "Persons",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_EventId",
                table: "Equipments",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Events_EventId",
                table: "Equipments",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Events_EventId",
                table: "Persons",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Events_EventId",
                table: "Teams",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Events_EventId",
                table: "Vehicles",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Events_EventId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Events_EventId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Events_EventId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Events_EventId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_EventId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Teams_EventId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Persons_EventId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_EventId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Equipments");
        }
    }
}
