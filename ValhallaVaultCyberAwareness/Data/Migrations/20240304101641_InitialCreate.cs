using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SegmentModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegmentModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SegmentModel_CategoryModel_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoryModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoryModel_SegmentModel_SegmentId",
                        column: x => x.SegmentId,
                        principalTable: "SegmentModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionModel_SubCategoryModel_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategoryModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnswerModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrectAnswer = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerModel_QuestionModel_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponseModel",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    IsAnsweredCorrectly = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseModel", x => new { x.UserId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_ResponseModel_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponseModel_QuestionModel_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerModel_QuestionId",
                table: "AnswerModel",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModel_SubCategoryId",
                table: "QuestionModel",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseModel_QuestionId",
                table: "ResponseModel",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentModel_CategoryId",
                table: "SegmentModel",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryModel_SegmentId",
                table: "SubCategoryModel",
                column: "SegmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerModel");

            migrationBuilder.DropTable(
                name: "ResponseModel");

            migrationBuilder.DropTable(
                name: "QuestionModel");

            migrationBuilder.DropTable(
                name: "SubCategoryModel");

            migrationBuilder.DropTable(
                name: "SegmentModel");

            migrationBuilder.DropTable(
                name: "CategoryModel");
        }
    }
}
