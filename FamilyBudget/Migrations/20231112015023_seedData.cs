using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "IncomeCategory",
                newName: "CategoryName");

            migrationBuilder.InsertData(
                table: "ExpenseCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Food" },
                    { 2, "Fuel" }
                });

            migrationBuilder.InsertData(
                table: "IncomeCategory",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 1, "Salary" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, "Adam990" },
                    { 2, "Janusz889" }
                });

            migrationBuilder.InsertData(
                table: "Expense",
                columns: new[] { "Id", "Amount", "Description", "ExpenseCategoryId", "ExpenseDate", "UserId" },
                values: new object[,]
                {
                    { 1, 50.0m, "Grocery shopping", 1, new DateTime(2023, 11, 12, 2, 50, 23, 254, DateTimeKind.Local).AddTicks(3713), 1 },
                    { 2, 30.0m, "Fuel", 2, new DateTime(2023, 11, 12, 2, 50, 23, 254, DateTimeKind.Local).AddTicks(3734), 2 },
                    { 3, 30.0m, "Fuel", 2, new DateTime(2023, 11, 12, 2, 50, 23, 254, DateTimeKind.Local).AddTicks(3736), 1 }
                });

            migrationBuilder.InsertData(
                table: "Income",
                columns: new[] { "Id", "Amount", "Date", "Description", "IncomeCategoryId", "UserId" },
                values: new object[] { 1, 5000.0m, new DateTime(2023, 11, 12, 2, 50, 23, 254, DateTimeKind.Local).AddTicks(3755), "Salary", 1, 1 });

            migrationBuilder.InsertData(
                table: "SharedExpense",
                columns: new[] { "Id", "ExpenseId", "SharingUserId" },
                values: new object[] { 1, 1, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Income",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SharedExpense",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expense",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExpenseCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IncomeCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExpenseCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "IncomeCategory",
                newName: "Name");
        }
    }
}
