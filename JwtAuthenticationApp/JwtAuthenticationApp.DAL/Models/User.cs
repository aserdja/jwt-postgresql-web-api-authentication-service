namespace JwtAuthenticationApp.DAL.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Login { get; set; } = string.Empty;
		public DateTime RegistrationDateTime { get; set; }
		public bool IsDeleted { get; set; } = false;

		public ICollection<User>? Friends { get; set; }
	}
}
