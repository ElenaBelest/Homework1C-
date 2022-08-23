Console.Write("Enter number > 1: ");
int number = Convert.ToInt32(Console.ReadLine());

int number2 = 1;

if (number <= 0)
{
    Console.Write("Bad number");
}
else
{
    while (number2 <= number)
    {
        if (number2 % 2 == 0)
        {
            Console.Write(number2 + "  ");
            number2 ++;
        }
        else
        {
        number2 ++;
        }
    }
}