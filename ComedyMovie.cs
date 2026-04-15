/*******************************************************************
* Name: Emmanuel Holmes
* Date: 4/15/2026
* Assignment: Course Project Part 2
*
* This class represents a comedy movie and is derived from Movie.
*******************************************************************/
public class ComedyMovie : Movie
{
    public string HumorStyle { get; set; }

    public ComedyMovie(string title, string genre, int releaseYear, string rating,
        Director directorInfo, string humorStyle)
        : base(title, genre, releaseYear, rating, directorInfo)
    {
        HumorStyle = humorStyle;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nHumor Style: {HumorStyle}";
    }
}