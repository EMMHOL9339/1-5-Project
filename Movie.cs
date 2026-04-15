/*******************************************************************
* Name: Emmanuel Holmes
* Date: 4/15/2026
* Assignment: Course Project Part 2
*
* This class represents a general movie object.
*******************************************************************/
public class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
    public string Rating { get; set; }
    public Director DirectorInfo { get; set; }

    public Movie(string title, string genre, int releaseYear, string rating, Director directorInfo)
    {
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        Rating = rating;
        DirectorInfo = directorInfo;
    }

    public override string ToString()
    {
        return $"Title: {Title}\nGenre: {Genre}\nRelease Year: {ReleaseYear}\nRating: {Rating}\n{DirectorInfo}";
    }
}