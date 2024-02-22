


using ChallengeApp;

Empoyye Empoyee1 = new Empoyye("Adam", "Kamizelich", 30);
Empoyye Empoyee2 = new Empoyye("Zuzia", "Zuziazła", 21);
Empoyye Empoyee3 = new Empoyye("Bartosz", "Michalczewski", 35);



Empoyee1.AddScore(5);
Empoyee1.AddScore(5);
Empoyee1.AddScore(5);
Empoyee1.AddScore(5);
Empoyee1.AddScore(5);
Empoyee2.AddScore(10);
Empoyee2.AddScore(10);
Empoyee2.AddScore(10);
Empoyee2.AddScore(10);
Empoyee2.AddScore(10);
Empoyee3.AddScore(3);
Empoyee3.AddScore(3);
Empoyee3.AddScore(3);
Empoyee3.AddScore(3);
Empoyee3.AddScore(3);

var result1 = Empoyee1.Result;
var result2 = Empoyee2.Result;
var result3 = Empoyee3.Result;

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);

if (result1 > result2 && result1 > result3)
{
    Console.WriteLine("Najlepszy wynik osiągnoł" + Empoyee1.Name + Empoyee1.Surname + Empoyee1.Age + result1);
}
else if (result2 > result1 && result2 > result3)
{
    Console.WriteLine("Najlepszy wynik osiągnoł" + Empoyee2.Name + Empoyee2.Surname + Empoyee2.Age + result2);
}
else if (result3 > result1 && result3 > result2)
{
    Console.WriteLine("Najlepszy wynik osiągnoł" + Empoyee3.Name + Empoyee3.Surname + Empoyee3.Age + result3);
}
