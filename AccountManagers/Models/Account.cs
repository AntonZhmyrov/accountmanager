namespace AccountManagers.Models
{
	public class Account
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Gender { get; set; }
		public int CountryId { get; set; }
	}
}