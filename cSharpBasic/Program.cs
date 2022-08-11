/*
 Declare an array of int,string,double. Find out all
array manipulation methods and implement them.
 */


int[] int_arr = new int[10];
var doubleArr = new double[10];
var stringList = new string[10];


for (int i = 0; i < 5; i++)
     int_arr[i] = Convert.ToInt32(Console.ReadLine());

      



int[] int_arr2 = { 100, 200, 300, 400 };


for (int i = 0; i < int_arr.Count(); i++)
{
    Console.Write(int_arr[i] + " , ");

}
Console.WriteLine();

var sum = int_arr.Sum();
var avg = int_arr.Average();
var max = int_arr.Max();
var min = int_arr.Min();



Console.WriteLine($"max : {max} , min : {min} , avg : {avg:N2} , sum : {sum}");

Console.WriteLine("After Remove element 5 and reverse the list : ");
Array.Reverse(int_arr);
int_arr = int_arr.Where(element => element != 5).ToArray();

for (int i = 0; i < int_arr.Count(); i++)
{
    Console.Write(int_arr[i] + " , ");
}
Console.WriteLine();


Console.WriteLine("After sorting the list : ");
int_arr[3] = 5;
Array.Sort(int_arr);



for (int i = 0; i < int_arr.Count(); i++)
{
    Console.Write(int_arr[i] + " , ");

}
Console.WriteLine();
Console.WriteLine("Size of list : " + int_arr.Count());