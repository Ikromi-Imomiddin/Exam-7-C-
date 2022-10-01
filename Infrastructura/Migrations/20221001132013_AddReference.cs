using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructura.Migrations
{
    /// <inheritdoc />
    public partial class AddReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Participants_GroupId",
                table: "Participants",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_LocationId",
                table: "Participants",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ChallangeId",
                table: "Groups",
                column: "ChallangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Challanges_ChallangeId",
                table: "Groups",
                column: "ChallangeId",
                principalTable: "Challanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Groups_GroupId",
                table: "Participants",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Locations_LocationId",
                table: "Participants",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Challanges_ChallangeId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Groups_GroupId",
                table: "Participants");

            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Locations_LocationId",
                table: "Participants");

            migrationBuilder.DropIndex(
                name: "IX_Participants_GroupId",
                table: "Participants");

            migrationBuilder.DropIndex(
                name: "IX_Participants_LocationId",
                table: "Participants");

            migrationBuilder.DropIndex(
                name: "IX_Groups_ChallangeId",
                table: "Groups");
        }
    }
}
