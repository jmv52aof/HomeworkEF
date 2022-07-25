namespace HomeworkWebApi.Models;

public class Doctor
{
    public int Id { get; private set; }
    public string? Name { get; private set; }
    public string? Specialisation { get; private set; }
    public int YearsOfExperience { get; private set; }

		public Doctor()
		{
		}

    public Doctor( int id, string name, string specialisation, int yearsOfExperience )
    {
        Id = id;
        Name = name;
        Specialisation = specialisation;
        YearsOfExperience = yearsOfExperience;
    }

    public void UpdateName( string newName )
    {
        Name = newName;
    }

    public void UpdateSpecialisation( string specialisation )
    {
        Specialisation = specialisation;
    }
    public void UpdateYearsOfExperience( int years )
    {
        YearsOfExperience = years;
    }
}
