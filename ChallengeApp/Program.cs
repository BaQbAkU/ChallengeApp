using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich",30);
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Avereage: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

SetSth(statistics);
//ref-mozna ale nie trzeba_ or _ out-trzeba wywoac
void SetSth(Statistics statistics)
{
    statistics = new Statistics();
}
