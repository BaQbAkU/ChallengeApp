
namespace ChallengeApp;

public class Employee
{
    public static string GameName = "Diablo";

    private List<int> score = new List<int>();

    private string name;
    private string surname;
    private int age;

    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;

    }
    public Employee(string name)
    {
        this.Name = name;
    }
    public string Name { get; private set; }

    public string Surname { get; private set; }


    public int Age { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }



    public void AddScore(int number)
    {
        this.score.Add(number);
    }

}
