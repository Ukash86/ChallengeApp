string name = "Ewa";
string gender = "kobieta";
int age = 33;

if (gender == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (gender == "kobieta" || gender == "mężczyzna")
{
    Console.WriteLine(name + ", lat " + age);
}
else
{
    Console.WriteLine("Niepełnoletni " + gender);
}