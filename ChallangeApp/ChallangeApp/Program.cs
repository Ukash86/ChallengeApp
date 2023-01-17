string name = "Ewa";
string plec1 = "Kobieta";
string plec2 = "Mężczyzna";
var age = 33;
string word1 = "Niepełnoletni";
string word2 = " ";


if (age > 38)
{
    Console.WriteLine("Kobieta powyżej 38 lat");
}
else
{
    Console.WriteLine("Kobieta poniżej 38 lat");
}
if (age <= 33) 
{
    Console.WriteLine("Ewa, lat 33");
}
string result = word1 + word2 + plec2;
Console.WriteLine(result);
