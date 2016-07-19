namespace AccountManagers.Models
{
	public enum Gender
	{
		Male, Female
	}

	public class Account
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public Gender Sex { get; set; }
		public int CountryId { get; set; }
		public Country Country { get; set; }
	}
}