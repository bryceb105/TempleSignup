using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleSignup.Migrations
{
    public partial class times : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "times",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTime = table.Column<string>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_times", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    TimeId = table.Column<int>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.id);
                    table.ForeignKey(
                        name: "FK_responses_times_TimeId",
                        column: x => x.TimeId,
                        principalTable: "times",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 1, false, "April 1st, 2022, 8:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 2, false, "April 1st, 2022, 9:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 3, true, "April 1st, 2022, 10:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 4, true, "April 1st, 2022, 11:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 5, true, "April 1st, 2022, 12:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 6, true, "April 1st, 2022, 1:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 7, true, "April 1st, 2022, 2:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 8, true, "April 1st, 2022, 3:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 9, true, "April 1st, 2022, 4:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 10, true, "April 1st, 2022, 5:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 11, true, "April 1st, 2022, 6:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 12, true, "April 1st, 2022, 7:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "id", "Available", "DateTime" },
                values: new object[] { 13, true, "April 1st, 2022, 8:00PM" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "Email", "GroupSize", "Name", "Phone", "TimeId" },
                values: new object[] { 1, "colesmith@email.com", 4, "Smiths", "775-222-111", 1 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "Email", "GroupSize", "Name", "Phone", "TimeId" },
                values: new object[] { 2, "youth@email.com", 12, "Youth Group", null, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_TimeId",
                table: "responses",
                column: "TimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "times");
        }
    }
}
