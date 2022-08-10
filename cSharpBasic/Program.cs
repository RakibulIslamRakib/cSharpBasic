/*
 For, While, Do while, Foreach, continue & break 
(print 1 - 100, skip at 95, break at 99)
*/

Console.WriteLine("using for loop: ");

for(int i = 1; i <= 100; i++)
{
    if(i==95)continue;
    Console.Write(i+ " , ");
    if (i == 99) break;
}
Console.WriteLine();


Console.WriteLine("using while loop: ");
int start = 0;
while (start <= 100)
{
    start++;
    if (start == 95) continue;

    Console.Write(start + " , ");

    if (start == 99) break;

}
Console.WriteLine();



Console.WriteLine("using do while loop: ");
int startDo = 0;
do
{
    startDo++;
    if (startDo == 95) continue;
    Console.Write(startDo + " , ");
    if (startDo == 99) break;

} while (startDo <= 100);


Console.WriteLine();



Console.WriteLine("using foreach loop: ");
int[] numberArray =  new int[101];
for (int ind = 0; ind <= 100; ind++) numberArray[ind] = ind+1;

foreach (int number in numberArray)
{
    if (number == 95) continue;
    Console.Write(number + " , ");
    if (number== 99) break;
}


