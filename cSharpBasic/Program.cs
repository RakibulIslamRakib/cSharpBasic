/*
 
 Declare string and find all types of string manipulation methods.
 */

Console.WriteLine("Input An string : ");

string s = Console.ReadLine();

Console.WriteLine(s);

char[] chArray = s.ToCharArray();

Console.WriteLine(s.Length);

var sString = s.ToLower();
var lString = s.ToUpper();

var emptyString = String.Empty;


string s1 = "NANhE";
string s2 = "NANHe";
int n = string.Compare(s1, s2, false);

/*
 
This function returns 0 if both strings are equal.
It returns -1 if string2 is greater than string1 
and returns 1 if string1 is greater than string2.
It takes an optional parameter that is true or false.
If we pass true than it ignores case for the comparison.
 */

Console.WriteLine(n);


s1 = "              The quick brown fox     jumps over the lazy dog";
s2 = "Fox";
bool b;
b = s1.Contains(s2);
Console.WriteLine(b);


char[] chArray2 = s1.ToCharArray();
Array.Reverse(chArray2);
s1 = new string(chArray2);
Console.WriteLine(s1);

