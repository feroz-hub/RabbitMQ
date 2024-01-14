using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MicroRabbit.Transfer.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransferLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FromAccount = table.Column<int>(type: "INTEGER", nullable: false),
                    ToAccount = table.Column<int>(type: "INTEGER", nullable: false),
                    TransferAmount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferLogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TransferLogs",
                columns: new[] { "Id", "FromAccount", "ToAccount", "TransferAmount" },
                values: new object[,]
                {
                    { 1, 123, 456, 100.50m },
                    { 2, 789, 321, 50.75m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransferLogs");
        }
    }
}
