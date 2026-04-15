/*******************************************************************
* Name: Emmanuel Holmes
* Date: 4/15/2026
* Assignment: Course Project Part 2
*
* This class represents an action movie and is derived from Movie.
*******************************************************************/
public class ActionMovie : Movie
{
    public string StuntLevel { get; set; }

    public ActionMovie(string title, string genre, int releaseYear, string rating,
        Director directorInfo, string stuntLevel)
        : base(title, genre, releaseYear, rating, directorInfo)
    {
        StuntLevel = stuntLevel;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nStunt Level: {StuntLevel}";
    }
}