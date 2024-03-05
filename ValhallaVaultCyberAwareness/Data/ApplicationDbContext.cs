using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<ResponseModel> Responses { get; set; }
        public DbSet<SegmentModel> Segments { get; set; }
        public DbSet<SubCategoryModel> SubCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ResponseModel>().HasKey(r => new { r.UserId, r.QuestionId });


            //Seeda dummy-data
            builder.Entity<CategoryModel>().HasData(
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Första kategorin"
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Second category"
                },
                new CategoryModel()
                {
                    Id = 3,
                    Name = "Eine dreite categorie"
                });

            builder.Entity<SegmentModel>().HasData(
                new SegmentModel()
                {
                    Id = 1,
                    Name = "Första segmentet",
                    CategoryId = 1,
                    InfoText = "Här är lite infotext om detta segmentet"
                },
                new SegmentModel()
                {
                    Id = 2,
                    Name = "Ett andra segment",
                    CategoryId = 1,
                    InfoText = "Annan info som tillhör andra segmentet"
                },
                new SegmentModel()
                {
                    Id = 3,
                    Name = "TREEEEEE",
                    CategoryId = 1,
                    InfoText = "HÄR ÄR EN RAGE INFO"
                });

            builder.Entity<SubCategoryModel>().HasData(
                new SubCategoryModel()
                {
                    Id = 1,
                    Name = "Första subkategorin",
                    SegmentId = 1,
                },
                new SubCategoryModel()
                {
                    Id = 2,
                    Name = "Another subcategory please!",
                    SegmentId = 1,
                },
                new SubCategoryModel()
                {
                    Id = 3,
                    Name = "Können ich eine dritte sub haben, bitte?",
                    SegmentId = 1,
                });

            builder.Entity<QuestionModel>().HasData(
                new QuestionModel()
                {
                    Id = 1,
                    Text = "Vilket svar nedan är rätt?",
                    SubCategoryId = 1,
                },
                new QuestionModel()
                {
                    Id = 2,
                    Text = "Ta inte denna frågan?",
                    SubCategoryId = 1,
                },
                new QuestionModel()
                {
                    Id = 3,
                    Text = "Inte denna heller!",
                    SubCategoryId = 1,
                });

            builder.Entity<AnswerModel>().HasData(
                new AnswerModel()
                {
                    Id = 1,
                    QuestionId = 1,
                    Text = "Första svaret",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 2,
                    QuestionId = 1,
                    Text = "Andra svaret",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 3,
                    QuestionId = 1,
                    Text = "Tredje svaret",
                    IsCorrectAnswer = true
                });
        }

    }
}
