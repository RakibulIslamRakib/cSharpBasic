/*
Declare arrays of size 15. Array type should be
bool,char,int,long,double,string etc 
Insert dummy value to those arrays and print them. 
While printing skip index no 5 and 
print until index 10. (use for,while,foreach,break,continue)
*/

string stringGenerate()
{
Random rand = new Random();

// Choosing the size of string
// Using Next() string
int stringlen = rand.Next(4, 10);
int randValue;
string str = "";
char letter;
for (int i = 0; i < stringlen; i++)
{

    // Generating a random number.
    randValue = rand.Next(0, 26);

    // Generating random character by converting
    // the random number into character.
    letter = Convert.ToChar(randValue + 65);

    // Appending the letter to string.
    str = str + letter;
}
    return str;
}



var boolArray = new bool[15];
var charArray = new char[15];
var intArray = new int[15];
var longArray = new long[15];
var doubleArray = new double[15];
var stringArray = new string[15];

bool x = true;
for(int i = 0; i < 15; i++)
{
    boolArray[i] = x;
    x = !x;
}


char ch = 'a';
for (int i = 0; i < 15; i++)
{
    charArray[i] = ch;
   ch++;
}



for (int i = 0; i < 15; i++)
{
    intArray[i] = i+1;
}


for (int i = 0; i < 15; i++)
{
    longArray[i] = (long)i * 100000000000;
}


var dbl = 3273.353;
for (int i = 0; i < 15; i++)
{
    doubleArray[i] = dbl;
    dbl *= 2;
}


for (int i = 0; i < 15; i++)
{
    var newString = stringGenerate();
    stringArray[i] = newString;
}



for(int i = 0; i < 15; i++)
    {
    if (i == 5) continue;
    Console.WriteLine(intArray[i] +", ");
    if (i == 10) {
        Console.WriteLine();
        break;
    }
   }

for (int i = 0; i < 15; i++)
{
    if (i == 5) continue;
    Console.WriteLine(charArray[i] +", ");
    if (i == 10)
    {
        Console.WriteLine();
        break;
    }
}

for (int i = 0; i < 15; i++)
{
    if (i == 5) continue;
    Console.WriteLine(longArray[i] + ", ");
    if (i == 10)
    {
        Console.WriteLine();
        break;
    }
}

for (int i = 0; i < 15; i++)
{
    if (i == 5) continue;
    Console.WriteLine(doubleArray[i] + ", ");
    if (i == 10)
    {
        Console.WriteLine();
        break;
    }
}

for (int i = 0; i < 15; i++)
{
    if (i == 5) continue;
    Console.WriteLine(boolArray[i] +", ");
    if (i == 10)
    {
        Console.WriteLine();
        break;
    }
}

for (int i = 0; i < 15; i++)
{
    if (i == 5) continue;
    Console.WriteLine(stringArray[i] + ", ");
    if (i == 10)
    {
        Console.WriteLine();
        break;
    }
}