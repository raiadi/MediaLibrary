namespace MediaLibrary
{
  class Library
  {
    public static void Main()
    {
      Album album = new Album("Rock Yatra", "1974AD");
      Book book = new Book("The Alchemist", "Paulo Coelho");
      Movie movie = new Movie("Austin Powers", "Comedy");

      System.Console.WriteLine("Album: "+ album.Name + " by artist "+ album.Artist);
      System.Console.WriteLine("Book: "+ book.Name + " by author "+ book.Author);
      System.Console.WriteLine("Movie: "+ movie.Name + " Genre: "+ movie.Genre);
    }
  }
}
