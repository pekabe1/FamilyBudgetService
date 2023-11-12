using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpenseDate",
                value: new DateTime(2023, 11, 12, 21, 36, 50, 778, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpenseDate",
                value: new DateTime(2023, 11, 12, 21, 36, 50, 778, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpenseDate",
                value: new DateTime(2023, 11, 12, 21, 36, 50, 778, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Income",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 11, 12, 21, 36, 50, 778, DateTimeKind.Local).AddTicks(6106));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpenseDate",
                value: new DateTime(2023, 11, 12, 16, 27, 45, 132, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpenseDate",
                value: new DateTime(2023, 11, 12, 16, 27, 45, 132, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpenseDate",
                value: new DateTime(2023, 11, 12, 16, 27, 45, 132, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Income",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 11, 12, 16, 27, 45, 132, DateTimeKind.Local).AddTicks(3234));
        }
    }
}
