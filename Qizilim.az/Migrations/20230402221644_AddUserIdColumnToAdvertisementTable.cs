using Microsoft.EntityFrameworkCore.Migrations;

namespace Qizilim.az.Migrations
{
    public partial class AddUserIdColumnToAdvertisementTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QizilimUserId",
                table: "Advertisement",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShopId",
                table: "Advertisement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_QizilimUserId",
                table: "Advertisement",
                column: "QizilimUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisement_Users_QizilimUserId",
                table: "Advertisement",
                column: "QizilimUserId",
                principalSchema: "Membership",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisement_Users_QizilimUserId",
                table: "Advertisement");

            migrationBuilder.DropIndex(
                name: "IX_Advertisement_QizilimUserId",
                table: "Advertisement");

            migrationBuilder.DropColumn(
                name: "QizilimUserId",
                table: "Advertisement");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Advertisement");
        }
    }
}
