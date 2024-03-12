using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;
using ValhallaVaultCyberAwareness.Repository;

namespace ValhallaVaultCyberAwareness.Managers
{
    public class QuestionManager(ApplicationDbContext context)
    {
        private readonly ValhallaUow uow = new(context);

        /// <summary>
        /// Räknar ut hur många procent rätt man har.
        /// </summary>
        /// <param name="questions">Lista med frågorna i subkategorin</param>
        /// <param name="user"></param>
        /// <returns>Antal procentenheter, alltså inte 0.8 utan 80%</returns>
        /// <exception cref="Exception"></exception>
        public async Task<double> CalculateCorrectPercentage(List<QuestionModel> questions, ApplicationUser user)
        {
            if (questions.Count() == 0) throw new Exception();

            List<ResponseModel> answeredResponses = new();
            double correctAnswers = 0;
            foreach (var question in questions)
            {
                var userResponse = await uow.ResponseRepo.GetByIdAsync(user, question.Id);
                if (userResponse != null)
                {
                    //Räknar antalet rätta svar
                    if (userResponse.IsAnsweredCorrectly) correctAnswers++;

                    answeredResponses.Add(userResponse);
                }
            }

            return Math.Round(correctAnswers / questions.Count() * 100, 0);

        }

        /// <summary>
        /// Räknar ut hur många procent rätt man har.
        /// </summary>
        /// <param name="subCategoryId">Id för subkategorin alla frågor ingår i</param>
        /// <param name="user"></param>
        /// <returns>Antal procentenheter, alltså inte 0.8 utan 80%</returns>
        /// <exception cref="Exception"></exception>
        public async Task<double> CalculateCorrectPercentage(int subCategoryId, ApplicationUser user)
        {
            List<QuestionModel> questions = await uow.QuestionRepo.GetQuestionsInSubCategoryAsnyc(subCategoryId);

            return await CalculateCorrectPercentage(questions, user);
        }

        public async Task<double> CalculatePercentageInSegment(int segmentId, ApplicationUser user)
        {
            List<QuestionModel> questions = await uow.QuestionRepo.GetQuestionsInSegmentAsnyc(segmentId);

            return await CalculateCorrectPercentage(questions, user);
        }

        /// <summary>
        /// Sparar svaret användaren gör i databasen. Om användaren redan har svarat på frågan skrivs det gamla svaret över med det nya
        /// </summary>
        /// <param name="questionId"></param>
        /// <param name="user"></param>
        /// <param name="isCorrectAnswer"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task SaveResponseToUser(int questionId, ApplicationUser user, bool isCorrectAnswer)
        {
            ResponseModel newResponse = new()
            {
                QuestionId = questionId,
                UserId = user.Id,
                IsAnsweredCorrectly = isCorrectAnswer
            };

            ResponseModel? existingResponse = await uow.ResponseRepo.GetByIdAsync(user, questionId);
            //Om användaren redan har svarat på frågan tidigare uppdaterar vi det svaret
            if (existingResponse != null)
            {
                try
                {
                    await uow.ResponseRepo.UpdateAsync(questionId, user, newResponse);
                }
                catch
                {
                    throw new Exception();
                }
            }
            //Annars lägger vi till ett nytt svar
            else
            {
                try
                {
                    await uow.ResponseRepo.AddAsync(newResponse);
                }
                catch
                {
                    throw new Exception("Something went wrong with adding answer. Maybe it's already answered");
                }
            }

        }

        /// <summary>
        /// Returnerar questionId på följande fråga i segmentet. Om det är sista frågan i segmentet så returnas 0.
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<int> GetNextQuestionId(int questionId)
        {
            QuestionModel? currentQuestion = await uow.QuestionRepo.GetByIdAsync(questionId);

            if (currentQuestion == null) throw new Exception();

            SubCategoryModel? currentSubCategory = await uow.SubcategoryRepo.GetByIdAsync(currentQuestion.SubCategoryId);

            if (currentSubCategory == null) throw new Exception();

            int indexOfQuestion = currentSubCategory.Questions.IndexOf(currentQuestion);

            if (indexOfQuestion == currentSubCategory.Questions.Count() - 1)
            {
                //Last question. Return something here
                return 0;
            }
            else
            {
                QuestionModel nextQuestion = currentSubCategory.Questions[indexOfQuestion + 1];
                return nextQuestion.Id;
            }
        }

        public async Task<bool> QuestionAnsweredCorrectly(int questionId, ApplicationUser user)
        {
            ResponseModel? response = await uow.ResponseRepo.GetByIdAsync(user, questionId);

            if (response == null) throw new Exception();

            return response.IsAnsweredCorrectly;
        }
    }
}
