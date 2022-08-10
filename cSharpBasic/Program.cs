struct Book
{
    public string name;
    public string description;
    public int prize;

    public void print()
    {
        System.Console.WriteLine("name is " + name);
        System.Console.WriteLine("Description : " + description);
        System.Console.WriteLine("Price : "+ prize);
    }
}

public class Test
{
    static void Main(string[] args)
    {
        var book1 = new Book();
        book1.name = "Hajar bochor dhore";
        book1.description = "Hajar bochor dhore is a novel based on village life";
        book1.prize = 350;

        book1.print();


        var book2 = new Book();
        book2.name = "kobor";
        book2.description = "obor is a poem based on village life";
        book2.prize = 380;

        book2.print();
    }
}