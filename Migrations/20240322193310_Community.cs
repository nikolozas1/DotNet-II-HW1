﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reddit.Migrations
{
    /// <inheritdoc />
    public partial class Community : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Communities_CommunityId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Community",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "CommunityId",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Communities_CommunityId",
                table: "Posts",
                column: "CommunityId",
                principalTable: "Communities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Communities_CommunityId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "CommunityId",
                table: "Posts",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Community",
                table: "Posts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Communities_CommunityId",
                table: "Posts",
                column: "CommunityId",
                principalTable: "Communities",
                principalColumn: "Id");
        }
    }
}
