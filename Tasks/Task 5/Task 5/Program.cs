using System;

public class CurriculumVitae
{ 
    private const int MaxNameLength = 50;

    private string name;
    private string email;
    private int age;
    private int yearsOfExperience;
 
    public CurriculumVitae()
    {
        name = "John Doe";
        email = "johndoe@example.com";
        age = 30;
        yearsOfExperience = 5; 
    }
 
    public CurriculumVitae(string name, string email, int age, int yearsOfExperience)
    {
        this.name = name;
        this.email = email;
        this.age = age;
        this.yearsOfExperience = yearsOfExperience;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length <= MaxNameLength)
                name = value;
            else
                throw new ArgumentException("Name exceeds maximum length.");
        }
    }
  
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
 
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public int YearsOfExperience
    {
        get { return yearsOfExperience; }
        set { yearsOfExperience = value; }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Years of Experience: {yearsOfExperience}");
    }

    public int CalculateExperienceYears(int currentYear)
    {
        return currentYear - (age - yearsOfExperience);
    }
}
