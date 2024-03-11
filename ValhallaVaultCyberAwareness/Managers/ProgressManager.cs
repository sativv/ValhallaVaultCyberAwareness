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
		/// <param name="segmentId"></param>
		/// <returns>Lista av SegmentViewModels</returns>
		public async Task<List<SegmentViewModel>> GetSegmentProgressInCategoryAsync(ApplicationUser user, int segmentId)
		{
			List<SegmentModel> allSegments = await uow.SegmentRepo.GetSegmentsInCategoryAsync(segmentId);
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
					newSegment.SegmentProgress = await questionManager.CalculateCorrectPercentage(segment.Id, user);
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
	}
}
