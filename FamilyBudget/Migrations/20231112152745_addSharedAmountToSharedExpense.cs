using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addSharedAmountToSharedExpense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SharedAmount",
                table: "SharedExpense",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

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

            migrationBuilder.UpdateData(
                table: "SharedExpense",
                keyColumn: "Id",
                keyValue: 1,
                column: "SharedAmount",
                value: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SharedAmount",
                table: "SharedExpense");

            migrationBuilder.UpdateData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpenseDate",
                value: new DateTime(2023, 11, 12, 2, 50, 23, 254, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpenseDate",
                value: new DateTime(2023, 11, 12, 2, 50, 23, 254, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpenseDate",
                value: new DateTime(2023, 11, 12, 2, 50, 23, 254, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Income",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 11, 12, 2, 50, 23, 254, DateTimeKind.Local).AddTicks(3755));
        }
    }
}
