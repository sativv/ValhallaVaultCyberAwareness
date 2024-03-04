using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.Migrations
{
    /// <inheritdoc />
    public partial class addDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerModel_QuestionModel_QuestionId",
                table: "AnswerModel");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_SubCategoryModel_SubCategoryId",
                table: "QuestionModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ResponseModel_AspNetUsers_UserId",
                table: "ResponseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ResponseModel_QuestionModel_QuestionId",
                table: "ResponseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_SegmentModel_CategoryModel_CategoryId",
                table: "SegmentModel");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoryModel_SegmentModel_SegmentId",
                table: "SubCategoryModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategoryModel",
                table: "SubCategoryModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SegmentModel",
                table: "SegmentModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResponseModel",
                table: "ResponseModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionModel",
                table: "QuestionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerModel",
                table: "AnswerModel");

            migrationBuilder.RenameTable(
                name: "SubCategoryModel",
                newName: "SubCategories");

            migrationBuilder.RenameTable(
                name: "SegmentModel",
                newName: "Segments");

            migrationBuilder.RenameTable(
                name: "ResponseModel",
                newName: "Responses");

            migrationBuilder.RenameTable(
                name: "QuestionModel",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "CategoryModel",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "AnswerModel",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategoryModel_SegmentId",
                table: "SubCategories",
                newName: "IX_SubCategories_SegmentId");

            migrationBuilder.RenameIndex(
                name: "IX_SegmentModel_CategoryId",
                table: "Segments",
                newName: "IX_Segments_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ResponseModel_QuestionId",
                table: "Responses",
                newName: "IX_Responses_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionModel_SubCategoryId",
                table: "Questions",
                newName: "IX_Questions_SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerModel_QuestionId",
                table: "Answers",
                newName: "IX_Answers_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Segments",
                table: "Segments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Responses",
                table: "Responses",
                columns: new[] { "UserId", "QuestionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_SubCategories_SubCategoryId",
                table: "Questions",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_AspNetUsers_UserId",
                table: "Responses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Questions_QuestionId",
                table: "Responses",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Segments_Categories_CategoryId",
                table: "Segments",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Segments_SegmentId",
                table: "SubCategories",
                column: "SegmentId",
                principalTable: "Segments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_SubCategories_SubCategoryId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_AspNetUsers_UserId",
                table: "Responses");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Questions_QuestionId",
                table: "Responses");

            migrationBuilder.DropForeignKey(
                name: "FK_Segments_Categories_CategoryId",
                table: "Segments");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Segments_SegmentId",
                table: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Segments",
                table: "Segments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Responses",
                table: "Responses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "SubCategories",
                newName: "SubCategoryModel");

            migrationBuilder.RenameTable(
                name: "Segments",
                newName: "SegmentModel");

            migrationBuilder.RenameTable(
                name: "Responses",
                newName: "ResponseModel");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "QuestionModel");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CategoryModel");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "AnswerModel");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_SegmentId",
                table: "SubCategoryModel",
                newName: "IX_SubCategoryModel_SegmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Segments_CategoryId",
                table: "SegmentModel",
                newName: "IX_SegmentModel_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Responses_QuestionId",
                table: "ResponseModel",
                newName: "IX_ResponseModel_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_SubCategoryId",
                table: "QuestionModel",
                newName: "IX_QuestionModel_SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionId",
                table: "AnswerModel",
                newName: "IX_AnswerModel_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategoryModel",
                table: "SubCategoryModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SegmentModel",
                table: "SegmentModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResponseModel",
                table: "ResponseModel",
                columns: new[] { "UserId", "QuestionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionModel",
                table: "QuestionModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerModel",
                table: "AnswerModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerModel_QuestionModel_QuestionId",
                table: "AnswerModel",
                column: "QuestionId",
                principalTable: "QuestionModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModel_SubCategoryModel_SubCategoryId",
                table: "QuestionModel",
                column: "SubCategoryId",
                principalTable: "SubCategoryModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResponseModel_AspNetUsers_UserId",
                table: "ResponseModel",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResponseModel_QuestionModel_QuestionId",
                table: "ResponseModel",
                column: "QuestionId",
                principalTable: "QuestionModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SegmentModel_CategoryModel_CategoryId",
                table: "SegmentModel",
                column: "CategoryId",
                principalTable: "CategoryModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategoryModel_SegmentModel_SegmentId",
                table: "SubCategoryModel",
                column: "SegmentId",
                principalTable: "SegmentModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
