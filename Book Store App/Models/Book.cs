namespace Book_Store_App.Models
{
	public class Book
	{
		public string Name { get; set; }
		public string Color { get; set; }
		public int Pages { get; set; }
		public int Year { get; set; }

		public Book(string BookName, string BookColor, int BookPages, int BookYear)
		{
			Name = BookName;
			Color = BookColor;
			Pages = BookPages;
			Year = BookYear;
		}

		public Book(string BookName, int BookYear)
		{
			Name = BookName;
			Year = BookYear;
		}
	}
}