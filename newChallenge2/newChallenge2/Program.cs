int number = 637662969;
string numberInString = number.ToString();
char[] digits = numberInString.ToArray();

List<char> numbers = new List<char>();
string[] name = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

foreach (var digit in name)
{
    int times = 0;
    foreach (var x in digits)
    {
        if (digit == x.ToString())
        {
            times++;
        }
    }
    Console.WriteLine(digit + " => " + times);
}