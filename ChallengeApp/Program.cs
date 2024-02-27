


using ChallengeApp;

Employee Employee1 = new Employee("Adam", "Kamizelich", 30);
Employee Employee2 = new Employee("Zuzia", "Zuziazła", 21);
Employee Employee3 = new Employee("Bartosz", "Michalczewski", 35);



Employee1.AddScore(5);
Employee1.AddScore(5);
Employee1.AddScore(5);
Employee1.AddScore(5);
Employee1.AddScore(5);

Employee2.AddScore(10);
Employee2.AddScore(10);
Employee2.AddScore(10);
Employee2.AddScore(10);
Employee2.AddScore(10);
Employee2.AddScore(-2);

Employee3.AddScore(3);
Employee3.AddScore(3);
Employee3.AddScore(3);
Employee3.AddScore(3);
Employee3.AddScore(3);

var result1 = Employee1.Result;
var result2 = Employee2.Result;
var result3 = Employee3.Result;

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);

if (result1 > result2 && result1 > result3)
{
    Console.WriteLine("Najlepszy wynik osiągnoł" + Employee1.Name + Employee1.Surname + Employee1.Age + result1);
}
else if (result2 > result1 && result2 > result3)
{
    Console.WriteLine("Najlepszy wynik osiągnoł" + Employee2.Name + Employee2.Surname + Employee2.Age + result2);
}
else if (result3 > result1 && result3 > result2)
{
    Console.WriteLine("Najlepszy wynik osiągnoł" + Employee3.Name + Employee3.Surname + Employee3.Age + result3);
}
