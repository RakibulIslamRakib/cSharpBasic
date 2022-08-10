int intNumber = int.MaxValue;

try
{
    int result = checked(intNumber + 5);
    Console.WriteLine(result);

}
catch (System.OverflowException e)
{
    Console.WriteLine("Overflow exception due to unchecked integer value:  " + e.Message);
}


