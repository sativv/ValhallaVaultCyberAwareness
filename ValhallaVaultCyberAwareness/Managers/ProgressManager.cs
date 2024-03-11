using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;
using ValhallaVaultCyberAwareness.Repository;

namespace ValhallaVaultCyberAwareness.Managers
{
    public class ProgressManager(ApplicationDbContext context)
    {
        private readonly ValhallaUow uow = new(context);
        private readonly QuestionManager questionManager = new(context);

        /// <summary>
        /// Hämtar userns progression i en kategori. Returnar SegmentViewModel som innehåller saker vi kan 
        /// använda oss av i UI, så som segmentProgress i % och IsAvailable.
        /// Ett segment är endast available om det föregående har mer än 80% rätt
        /// </summary>
        /// <param name="user"></param>
        /// <param name="categoryId"></param>
        /// <returns>Lista av SegmentViewModels</returns>
        public async Task<List<SegmentViewModel>> GetSegmentProgressInCategoryAsync(ApplicationUser user, int categoryId)
        {
            List<SegmentModel> allSegments = await uow.SegmentRepo.GetSegmentsInCategoryAsync(categoryId);
            List<SegmentViewModel> segmentViews = new();

            //Här kan man snabbt ändra om man vill ha en annan procent som tröskel.
            double percentageThreshold = 80;

            //Denna ändras till false för kommande segment om man inte har klarat den föregående
            bool nextSegmentAvailable = true;

            foreach (var segment in allSegments)
            {
                SegmentViewModel newSegment = new()
                {
                    Id = segment.Id,
                    Name = segment.Name,
                    InfoText = segment.InfoText,
                    CategoryId = segment.CategoryId,
                    IsAvailable = nextSegmentAvailable,
                };

                try
                {
                    newSegment.SegmentProgress = await questionManager.CalculatePercentageInSegment(segment.Id, user);
                    if (newSegment.SegmentProgress < percentageThreshold)
                    {
                        nextSegmentAvailable = false;
                    }
                }
                catch
                {
                    //Man hamnar här om man inte har gjort klart ett segment helt och hållet.
                    newSegment.SegmentProgress = 0;
                    nextSegmentAvailable = false;
                }

                segmentViews.Add(newSegment);
            }

            return segmentViews;
        }

        /// <summary>
        /// Hämtar userns progression i en kategori. Returnar SubCategoryViewModel som innehåller saker vi kan 
        /// använda oss av i UI, så som SubCategoryProcess i % och IsAvailable.
        /// Ett subcategory är endast available om det föregående har mer än 80% rätt
        /// </summary>
        /// <param name="user"></param>
        /// <param name="categoryId"></param>
        /// <returns>Lista av SubCategoryViewModel</returns>
        public async Task<List<SubCategoryViewModel>> GetSubCategoryProgressInSegmentAsync(ApplicationUser user, int segmentId)
        {
            List<SubCategoryModel> allSubCategories = await uow.SubcategoryRepo.GetSubcategoriesInSegmentAsync(segmentId);
            List<SubCategoryViewModel> subcategoryViews = new();

            //Här kan man snabbt ändra om man vill ha en annan procent som tröskel.
            double percentageThreshold = 80;

            //Denna ändras till false för kommande segment om man inte har klarat den föregående
            bool nextSegmentAvailable = true;

            foreach (var subcategory in allSubCategories)
            {
                SubCategoryViewModel newSubCategory = new()
                {
                    Id = subcategory.Id,
                    Title = subcategory.Title,
                    InfoText = subcategory.InfoText,
                    SegmentId = subcategory.SegmentId,
                    IsAvailable = nextSegmentAvailable,
                };

                try
                {
                    newSubCategory.SubCategoryProgress = await questionManager.CalculateCorrectPercentage(subcategory.Id, user);
                    if (newSubCategory.SubCategoryProgress < percentageThreshold)
                    {
                        nextSegmentAvailable = false;
                    }
                }
                catch
                {
                    //Man hamnar här om man inte har gjort klart ett segment helt och hållet.
                    newSubCategory.SubCategoryProgress = 0;
                    nextSegmentAvailable = false;
                }

                subcategoryViews.Add(newSubCategory);
            }

            return subcategoryViews;
        }

        /// <summary>
        /// Hämtar userns progression i en subkategori. Returnar QuestionViewModel som innehåller saker vi kan 
        /// använda oss av i UI, så som IsAnsweredCorrectly.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="categoryId"></param>
        /// <returns>Lista av SubCategoryViewModel</returns>
        public async Task<List<QuestionViewModel>> GetQuestionProgressInSubCategoryAsync(ApplicationUser user, int subcategoryId)
        {
            List<QuestionModel> allQuestionsInSubCategory = await uow.QuestionRepo.GetQuestionsInSubCategoryAsnyc(subcategoryId);
            List<QuestionViewModel> questionViews = new();

            foreach (var question in allQuestionsInSubCategory)
            {
                QuestionViewModel newQuestion = new()
                {
                    Id = question.Id,
                    Title = question.Title,
                };

                try
                {
                    newQuestion.IsAnsweredCorrectly = await questionManager.QuestionAnsweredCorrectly(question.Id, user);
                }
                catch
                {
                    newQuestion.IsAnsweredCorrectly = false;
                }

                questionViews.Add(newQuestion);
            }

            return questionViews;
        }

    }
}
