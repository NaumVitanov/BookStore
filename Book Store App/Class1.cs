namespace Book_Store_App
{
    public class Library
    {
        public string? Name;
        public string? Color;
        public int Pages;
        public int Year;

        public Library (string BookName, string BookColor, int BookPages, int BookYear)
        {
            Name = BookName;
            Color = BookColor;
            Pages = BookPages;
            Year = BookYear;
        }
    }
}