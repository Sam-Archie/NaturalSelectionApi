using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaturalSelection.Infrastructure.Migrations
{
    public partial class updates_to_enitiy_classes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Forums_ForumId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ForumId",
                table: "Users",
                newName: "ProfileImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ForumId",
                table: "Users",
                newName: "IX_Users_ProfileImageId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Images",
                newName: "FilePath");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ForumUser",
                columns: table => new
                {
                    ForumsForumId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumUser", x => new { x.ForumsForumId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ForumUser_Forums_ForumsForumId",
                        column: x => x.ForumsForumId,
                        principalTable: "Forums",
                        principalColumn: "ForumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserId",
                table: "Images",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumUser_UsersId",
                table: "ForumUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Users_UserId",
                table: "Images",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Images_ProfileImageId",
                table: "Users",
                column: "ProfileImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Users_UserId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Images_ProfileImageId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ForumUser");

            migrationBuilder.DropIndex(
                name: "IX_Images_UserId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "ProfileImageId",
                table: "Users",
                newName: "ForumId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ProfileImageId",
                table: "Users",
                newName: "IX_Users_ForumId");

            migrationBuilder.RenameColumn(
                name: "FilePath",
                table: "Images",
                newName: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Forums_ForumId",
                table: "Users",
                column: "ForumId",
                principalTable: "Forums",
                principalColumn: "ForumId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
