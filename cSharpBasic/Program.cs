


class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{Planets.Earch} is at {(int)Planets.Earch}");
        Console.WriteLine($"{Planets.Earch.ToString()} is at {(int)Planets.Earch}");


        Planets day1,day2;int i = 1;

        day1 = (Planets)i;
        day2 = (Planets)2;
        Console.WriteLine($"second planet is {day2}");

        for(int i2 = 1; i2 < 8; i2++)
        {
            Console.WriteLine($"{i2} th planet is : {(Planets)i2}");
        }

    }
}

enum Planets
{
    Mercury=1,
    Venus,
    Earch,
    Jupiter,
    Saturn,
    Uranus,
    Neptune,
    Pluto

}