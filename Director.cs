/*******************************************************************
* Name: Emmanuel Holmes
* Date: 4/15/2026
* Assignment: Course Project Part 2
*
* This class represents a director object.
*******************************************************************/
public class Director
{
    public string Name { get; set; }
    public int ExperienceYears { get; set; }

    public Director(string name, int experienceYears)
    {
        Name = name;
        ExperienceYears = experienceYears;
    }

    public override string ToString()
    {
        return $"Director: {Name}\nExperience: {ExperienceYears} years";
    }
}