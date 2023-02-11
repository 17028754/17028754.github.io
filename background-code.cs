public class LifeTime
{

    public static void Main(string[] args)
    {
        var DOBYear = new DateTime(1999, 2, 20).Year;
        var currentYear = DateTime.UtcNow.Year;
        var age = currentYear - DOBYear;
        var currentGoal = SimplifiedGoals(age);
    }

    public static string SimplifiedGoals(int age)
    {
        if (age >= 23 && age <= 29)
        {
            return "Work hard, save money";
        }
        else if (age >= 30 && age <= 39)
        {
            return "Work harder, buy house, buy car, and save money";
        }
        else if (age >= 40 && age <= 49)
        {
            return "Retire (if possible)";
        }
        else if (age >= 50 && age <= 55)
        {
            return "Retire now (if possible)";
        }
        else if (age >= 55 && age <= 60)
        {
            return "Must Retire now (if possible)";
        }
        else if (age >= 60)
        {
            return "Just work and don't retire";
        }
        else
        {
            return "Invalid age";
        }
    }

}

