Console.Write("Enter first number: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter last number: ");
int lasttnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber > lasttnumber)
{
    Console.Write(firstnumber + " > " + lasttnumber);
}
else
{
    Console.Write(firstnumber + " < " + lasttnumber);
}