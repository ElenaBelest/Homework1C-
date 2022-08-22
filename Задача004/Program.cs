Console.Write("Enter first number: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter last number: ");
int lastnumber = Convert.ToInt32(Console.ReadLine());

int max = firstnumber;


if (firstnumber < secondnumber)
{
     max = secondnumber;
}
else
{
     max = firstnumber;
}

if (max < lastnumber)
{
    max = lastnumber;
}
else
{
    max = max;
}

Console.Write("Maximal number " + max);