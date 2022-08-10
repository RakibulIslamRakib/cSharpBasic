/*
Console.WriteLine(stringToInt("343435342"));
Console.WriteLine(intToString(343435));

Console.WriteLine(stringToLong("34343546463"));
Console.WriteLine(longToString(34343546463));

Console.WriteLine(stringToDouble("343435.46463"));
Console.WriteLine(doubleToString(3434.45435));


Console.WriteLine(stringToFloat("343435.4646"));
Console.WriteLine(floatToString(34533.243f));


Console.WriteLine(charToAscii('c'));
Console.WriteLine(asciiToChar(99));

Console.WriteLine(stringToBool("true"));
Console.WriteLine(boolToString(true));

Console.WriteLine((intToLong(34)));
Console.WriteLine(longToInt(992424242));
*/





int stringToInt(string s)
{
    int stringEquivalentInt = 0;

    foreach(char c in s)
    {
        stringEquivalentInt*=10;
        stringEquivalentInt+=(c-48);
    }

    return stringEquivalentInt;

}

string intToString(int number)
{
    return number.ToString();
}


long stringToLong(string s)
{
    long stringEquivalentLong = 0;

    foreach (char c in s)
    {
        stringEquivalentLong *= 10;
        stringEquivalentLong += (c - 48);
    }

    return stringEquivalentLong;

}

string longToString(long number)
{
    return number.ToString();
}


double stringToDouble(string s)
{
    double stringEquivalentDouble = 0.0, doubleNumber1 = 0.0, doubleNumber2 = 0.0;
    bool findDot = false; int div = 1;

    foreach (char c in s)
    {
        if (c == '.')
        {
            findDot = true;
            continue;
        }
        if (findDot)
        {
            div *= 10;
        }
     
            
        stringEquivalentDouble *= 10;
        stringEquivalentDouble += (c - 48);

        
        
    }

    return stringEquivalentDouble/div;

}

string doubleToString(double number)
{
    return number.ToString();
}




double stringToFloat(string s)
{
    float stringEquivalentFloat = 0.0f;
    bool findDot = false; int div = 1;

    foreach (char c in s)
    {
        if (c == '.')
        {
            findDot = true;
            continue;
        }
        if (findDot)
        {
            div *= 10;
        }


        stringEquivalentFloat *= 10;
        stringEquivalentFloat += (c - 48);



    }

    return stringEquivalentFloat / div;

}

string floatToString(float number)
{
    return number.ToString();

}



bool stringToBool(string s)
{
    if (s.ToLower()=="true")return true;
    else if(s.ToLower()=="false")return false;
    else
    {
        throw new Exception("Invalid Input");   
    }
}

string boolToString(bool bl)
{
    if (bl) return "True";
    else  return "False";
    
}




long intToLong(int number)
{
    return Convert.ToInt64(number);
}

int longToInt(int number)
{
    try
    {
        return Convert.ToInt32(number);
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
        return 0;
    }
}



int charToAscii(char ch)
{
    return (int)ch ;
}

char asciiToChar(int num)
{
    return (char)num;
}


