


using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kamizelich", 30);
Employee employee2 = new Employee("Zuzia", "Zuziazła", 21);
Employee employee3 = new Employee("Bartosz", "Michalczewski", 35);



employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);

employee2.AddScore(10);
employee2.AddScore(10);
employee2.AddScore(10);
employee2.AddScore(10);
employee2.AddScore(10);
employee2.AddScore(-2);

employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);

if (result1 > result2 && result1 > result3)
{
    Console.WriteLine("Najlepszy" + "  " + "wynik"  + "  " + "osiągnoł" + "  " + "pan" + "  " + employee1.Name + "  " + employee1.Surname + "  " + "lat" + "  " + employee1.Age + "  " + "ilością punktów" + "  " + result1 + "  " + "GRATULACJE!!");
}
else if (result2 > result1 && result2 > result3)
{
    Console.WriteLine("Najlepszy" + "  " + "wynik" + "  " + "osiągnęła" + "  " + "pani" + "  " + employee2.Name + "  " + employee2.Surname + "  " + "lat" + "  " + employee2.Age + "  " + "ilością punktów" + "  " + result2 + "  " + "GRATULACJE!!");
}
else if (result3 > result1 && result3 > result2)
{
    Console.WriteLine("Najlepszy" + "  " + "wynik" + "  " + "osiągnoł" + "  " + "pan" + "  " + employee3.Name + "  " + employee3.Surname + "  " + "lat" + "  " + employee3.Age + "  " + "ilością punktów" + "  " + result3 + "  " + "GRATULACJE!!");
}
