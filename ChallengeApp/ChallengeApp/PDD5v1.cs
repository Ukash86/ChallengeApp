var Łukasz = 0;
var Daria = 0;
var Przemek = 0;
var Kasia = 0;
var Iza = 0;
var Paweł = 0;

string[] names = {"Łukasz", "Daria", "Przemek", "Kasia", "Łukasz", "Łukasz",
                  "Iza", "Paweł", "Daria", "Daria", "Łukasz", "Przemek", "Kasia",
                   "Przemek", "Daria", "Iza", "Kasia", "Iza", "Iza", "Łukasz", };

foreach (var name in names)
{
    if (name == "Łukasz")
    {
        Łukasz++;
    }
    else if (name == "Daria")
    {
        Daria++;
    }
    else if (name == "Przemek")
    {
        Przemek++;
    }
    else if (name == "Kasia")
    {
        Kasia++;
    }
    else if (name == "Iza")
    {
        Iza++;
    }
    else if (name == "Paweł")
    {
        Paweł++;
    }
}
Console.WriteLine("Łukasz    : " + Łukasz);
Console.WriteLine("Daria     : " + Daria);
Console.WriteLine("Przemek   : " + Przemek);
Console.WriteLine("Kasia     : " + Kasia);
Console.WriteLine("Iza       : " + Iza);
Console.WriteLine("Paweł     : " + Paweł);