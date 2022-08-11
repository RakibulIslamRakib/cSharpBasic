/*
 
 Declare a list of int,string,double. Find out all list
manipulation methods and implement them.
 */

var intList = new List<int>();
var doubleList = new List<double>();
var stringList = new List<string>();


for (int i = 0; i < 5; i++)
{
    int x;
    x = Convert.ToInt32(Console.ReadLine());
    intList.Add(x);
}



int[] int_arr = { 100, 200, 300, 400 };
intList.AddRange(int_arr);

for(int i=0; i<intList.Count;i++)
{
    Console.Write(intList[i]+" , ");

}
Console.WriteLine();

var sum = intList.Sum();
var avg = intList.Average();
var max = intList.Max();
var min = intList.Min();



Console.WriteLine($"max : {max} , min : {min} , avg : {avg:N2} , sum : {sum}");

Console.WriteLine("After Remove from index 4 and reverse the list : ");
intList.RemoveAt(3);
intList.Reverse();

for (int i = 0; i < intList.Count; i++)
{
    Console.Write(intList[i] + " , ");

}
Console.WriteLine();


Console.WriteLine("After sorting the list : ");
intList.Sort();

intList[3] = 4;

for (int i = 0; i < intList.Count; i++)
{
    Console.Write(intList[i] + " , ");

}
Console.WriteLine();
Console.WriteLine("Size of list : "+intList.Count);