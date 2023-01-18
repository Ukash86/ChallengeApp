string name = "Ewa";
char sex = 'K';
var age = 33;

if (sex == 'K')
{
    if (age > 38)
    {
        Console.WriteLine("Kobieta powyżej 38 lat");
    }
    else if (age < 38)
    {
        Console.WriteLine("Kobieta poniżej 38 lat");

        if (age == 33 && name == "Ewa") ;
    }
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (sex != 'K')
{
    if (age >= 18)
    {
        Console.WriteLine("Pełnoletni Mężczyzna");
    }
    else if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
}