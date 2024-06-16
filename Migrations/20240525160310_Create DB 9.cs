using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationService_Reservations_reservationsId",
                table: "ReservationService");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationService_Services_servicesId",
                table: "ReservationService");

            migrationBuilder.RenameColumn(
                name: "servicesId",
                table: "ReservationService",
                newName: "ServicesId");

            migrationBuilder.RenameColumn(
                name: "reservationsId",
                table: "ReservationService",
                newName: "ReservationsId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationService_servicesId",
                table: "ReservationService",
                newName: "IX_ReservationService_ServicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationService_Reservations_ReservationsId",
                table: "ReservationService",
                column: "ReservationsId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationService_Services_ServicesId",
                table: "ReservationService",
                column: "ServicesId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationService_Reservations_ReservationsId",
                table: "ReservationService");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationService_Services_ServicesId",
                table: "ReservationService");

            migrationBuilder.RenameColumn(
                name: "ServicesId",
                table: "ReservationService",
                newName: "servicesId");

            migrationBuilder.RenameColumn(
                name: "ReservationsId",
                table: "ReservationService",
                newName: "reservationsId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationService_ServicesId",
                table: "ReservationService",
                newName: "IX_ReservationService_servicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationService_Reservations_reservationsId",
                table: "ReservationService",
                column: "reservationsId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationService_Services_servicesId",
                table: "ReservationService",
                column: "servicesId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
