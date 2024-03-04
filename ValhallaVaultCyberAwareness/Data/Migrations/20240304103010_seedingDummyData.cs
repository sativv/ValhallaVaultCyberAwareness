using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberAwareness.Migrations
{
    /// <inheritdoc />
    public partial class seedingDummyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryModel",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Första kategorin" });

            migrationBuilder.InsertData(
                table: "SegmentModel",
                columns: new[] { "Id", "CategoryId", "InfoText", "Name" },
                values: new object[] { 1, 1, "Här är lite infotext om detta segmentet", "Första segmentet" });

            migrationBuilder.InsertData(
                table: "SubCategoryModel",
                columns: new[] { "Id", "Name", "SegmentId" },
                values: new object[] { 1, "Första subkategorin", 1 });

            migrationBuilder.InsertData(
                table: "QuestionModel",
                columns: new[] { "Id", "SubCategoryId", "Text" },
                values: new object[] { 1, 1, "Vilket svar nedan är rätt?" });

            migrationBuilder.InsertData(
                table: "AnswerModel",
                columns: new[] { "Id", "IsCorrectAnswer", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, false, 1, "Första svaret" },
                    { 2, false, 1, "Andra svaret" },
                    { 3, true, 1, "Tredje svaret" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnswerModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnswerModel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AnswerModel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategoryModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SegmentModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryModel",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
