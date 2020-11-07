using Microsoft.EntityFrameworkCore.Migrations;

namespace Wedu.Migrations
{
    public partial class changein : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_AspNetUsers_IdentityUserId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_IdentityUserId",
                table: "Profiles");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "Profiles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_IdentityUserId",
                table: "Profiles",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_AspNetUsers_IdentityUserId",
                table: "Profiles",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
