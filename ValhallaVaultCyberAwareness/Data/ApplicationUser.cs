using Microsoft.AspNetCore.Identity;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Data
{
	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : IdentityUser
	{
		public List<ResponseModel> Responses { get; } = new();
	}

}
