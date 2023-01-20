var zero = 0;
var one = 0;
var two = 0;
var three = 0;
var four = 0;
var five = 0;
var six = 0;
var seven = 0;
var eight = 0;
var nine = 0;

int number = 8817555;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

foreach (char letter in letters)
{
    if (letter == '0')
    {
        zero++;
    }
    else if (letter == '1')
    {
        one++;
    }
    else if (letter == '2')
    {
        two++;
    }
    else if (letter == '3')
    {
        three++;
    }
    else if (letter == '4')
    {
        four++;
    }
    else if (letter == '5')
    {
        five++;
    }
    else if (letter == '6')
    {
        six++;
    }
    else if (letter == '7')
    {
        seven++;
    }
    else if (letter == '8')
    {
        eight++;
    }
    else if (letter == '9')
    {
        nine++;
    }
}
Console.WriteLine("0 => " + zero);
Console.WriteLine("1 => " + one);
Console.WriteLine("2 => " + two);
Console.WriteLine("3 => " + three);
Console.WriteLine("4 => " + four);
Console.WriteLine("5 => " + five);
Console.WriteLine("6 => " + six);
Console.WriteLine("7 => " + seven);
Console.WriteLine("8 => " + eight);
Console.WriteLine("9 => " + nine);