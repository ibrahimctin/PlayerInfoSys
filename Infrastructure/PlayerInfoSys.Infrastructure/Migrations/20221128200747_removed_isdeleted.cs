using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerInfoSys.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removedisdeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Clubs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Clubs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Clubs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Clubs");
        }
    }
}
