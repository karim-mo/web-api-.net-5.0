﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace web_api_course_.net_5._0.Migrations
{
    public partial class CharRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_userid",
                table: "Characters",
                column: "userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Users_userid",
                table: "Characters",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Users_userid",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_userid",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "Characters");
        }
    }
}
