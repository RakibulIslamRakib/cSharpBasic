int x = 5, y = 3, z = 8;

int max = x;
if (x >z && x>y)
{
    max = x;
}
else if (y> x && y > z)
{
    max = y;
}

else
{
    max = z;
}

Console.WriteLine($"max among {x} , {y}, {z} = {max}");


//ternary
int maxAmonThree(int x,int y,int z)
{
   return  x > y ? x > z ? x :z :y > z? y : z;
}

Console.WriteLine( maxAmonThree(3, 8, 5));