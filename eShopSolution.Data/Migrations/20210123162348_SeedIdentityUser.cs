using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 23, 23, 23, 46, 302, DateTimeKind.Local).AddTicks(2685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 1, 23, 22, 51, 57, 895, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("50b4f6c8-a041-42a6-a273-5c9fbbd15516"), "de2719c4-6d2d-4296-b572-db5ef178db19", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("50b4f6c8-a041-42a6-a273-5c9fbbd15516"), new Guid("dce43894-e786-4cb1-b67c-bb55eda3b091") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("dce43894-e786-4cb1-b67c-bb55eda3b091"), 0, "720b5b3c-0f59-4299-a657-454e347b6850", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "locteo2016@gmail.com", true, "Nguyen", "Loc", false, null, "locteo2016@gmail.com", "admin", "AQAAAAEAACcQAAAAECUZwAQxovrtQ/ZE8laAZvwxZbvTbeuXM4aoysFC1YGd1spS3LMykSqElZVYgAzmVQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 23, 23, 23, 46, 339, DateTimeKind.Local).AddTicks(8473));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("50b4f6c8-a041-42a6-a273-5c9fbbd15516"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("50b4f6c8-a041-42a6-a273-5c9fbbd15516"), new Guid("dce43894-e786-4cb1-b67c-bb55eda3b091") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("dce43894-e786-4cb1-b67c-bb55eda3b091"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 23, 22, 51, 57, 895, DateTimeKind.Local).AddTicks(4208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 1, 23, 23, 23, 46, 302, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 23, 22, 51, 57, 938, DateTimeKind.Local).AddTicks(9571));
        }
    }
}
