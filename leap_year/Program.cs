
Console.WriteLine("Enter the year: ");
int year = int. Parse(Console.ReadLine());

// && -> is used for "and"
// || -> is used for "or"

//if (((year%4 == 0) && (year%100 != 0)) || (year%400 == 0))
//{
//    Console.WriteLine("{0} is a leap year", year);
//}
//else
//{
//    Console.WriteLine(year + " is not a leap year");
//}

// internally given method by visual studio for leap year

if (DateTime.IsLeapYear(year))
{
    Console.WriteLine("{0} is a leap year", year);
}
else
{
    Console.WriteLine(year + " is not a leap year");
}