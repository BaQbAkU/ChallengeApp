


using ChallengeApp;

employee Employee1 = new employee("Adam", "Kamizelich", 30);
employee Employee2 = new employee("Zuzia", "Zuziazła", 21);
employee Employee3 = new employee("Bartosz", "Michalczewski", 35);



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
    Console.WriteLine("Najlepszy" + "  " + "wynik"  + "  " + "osiągnoł" + "  " + "pan" + "  " + Employee1.Name + "  " + Employee1.Surname + "  " + "lat" + "  " + Employee1.Age + "  " + "ilością punktów" + "  " + result1 + "  " + "GRATULACJE!!");
}
else if (result2 > result1 && result2 > result3)
{
    Console.WriteLine("Najlepszy" + "  " + "wynik" + "  " + "osiągnęła" + "  " + "pani" + "  " + Employee2.Name + "  " + Employee2.Surname + "  " + "lat" + "  " + Employee2.Age + "  " + "ilością punktów" + "  " + result2 + "  " + "GRATULACJE!!");
}
else if (result3 > result1 && result3 > result2)
{
    Console.WriteLine("Najlepszy" + "  " + "wynik" + "  " + "osiągnoł" + "  " + "pan" + "  " + Employee3.Name + "  " + Employee3.Surname + "  " + "lat" + "  " + Employee3.Age + "  " + "ilością punktów" + "  " + result3 + "  " + "GRATULACJE!!");
}
