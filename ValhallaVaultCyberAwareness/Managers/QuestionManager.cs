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
		public async Task<double> GotMoreThan80Percent(List<QuestionModel> questions, ApplicationUser user)
		{
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
			//Slänger en exception ifall vi inte har lika många svar som frågor
			if (questions.Count() != answeredResponses.Count()) throw new Exception("All questions haven't been answered");

			return Math.Round(correctAnswers / questions.Count() * 100, 2);


		}

		/// <summary>
		/// Räknar ut hur många procent rätt man har.
		/// </summary>
		/// <param name="subcategoryId">Id för subkategorin alla frågor ingår i</param>
		/// <param name="user"></param>
		/// <returns>Antal procentenheter, alltså inte 0.8 utan 80%</returns>
		/// <exception cref="Exception"></exception>
		public async Task<double> GotMoreThan80Percent(int subcategoryId, ApplicationUser user)
		{
			List<QuestionModel> questions = await uow.QuestionRepo.GetQuestionsInSubcategoryAsnyc(subcategoryId);

			return await GotMoreThan80Percent(questions, user);
		}
	}
}
