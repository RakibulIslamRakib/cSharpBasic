/*
 
 Declare a string and change some character of the string (use StringBuilder)
 */


using System.Text;

string s1 = "Hello World ";
var st = new StringBuilder(s1);
Console.WriteLine(st);
st.Insert(6, "c#");
Console.WriteLine(st);

st.Insert(8, " .net ");
Console.WriteLine(st);
st.Remove(5, 8);
Console.WriteLine(st);
st.Replace("Hello", "HI");
Console.WriteLine(st);
Console.WriteLine(st.Length);
st.AppendFormat("{0:C} ", 25);
Console.WriteLine(st);
var greet = st.ToString();
Console.WriteLine(greet);