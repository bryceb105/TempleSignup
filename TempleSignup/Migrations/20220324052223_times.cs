using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleSignup.Migrations
{
    public partial class times : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    DateTime = table.Column<string>(nullable: true),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 1, "April 1st, 2022, 8:00am", "colesmith@email.com", 4, "Smiths", "775-222-111" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 9, "April 1st, 2022, 3:00pm", "youth@email.com", 12, "Youth Group", null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 3, "April 1st, 2022, 9:00am", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 4, "April 1st, 2022, 10:00am", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 5, "April 1st, 2022, 11:00am", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 6, "April 1st, 2022, 12:00pm", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 7, "April 1st, 2022, 1:00pm", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 8, "April 1st, 2022, 2:00pm", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 10, "April 1st, 2022, 4:00pm", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 11, "April 1st, 2022, 5:00pm", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 12, "April 1st, 2022, 6:00pm", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 13, "April 1st, 2022, 7:00pm", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "DateTime", "Email", "GroupSize", "Name", "Phone" },
                values: new object[] { 14, "April 1st, 2022, 8:00pm", null, 0, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
