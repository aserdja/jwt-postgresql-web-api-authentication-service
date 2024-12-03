namespace JwtAuthenticationApp.DAL.Models
{
	public class UserCredentials
	{
		public int Id { get; set; }
		public string Email { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;

		public int UserId { get; set; }
		public User User { get; set; } = null!;
	}
}
