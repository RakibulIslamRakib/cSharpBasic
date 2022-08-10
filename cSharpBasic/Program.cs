
class A
{
    public string name;
    public A(string name)
        { this.name = name; }
    public void printName()
    {
        Console.WriteLine("Name  : "+name);
    }
}

class B
{
    static void Main(string[] arge)
    {
        var x = new A("BS23");
        x.printName();

        var y = x;
        y.name = "BS71";  
        /*As class is reference type so
         it will change name attribute of x object.
        */
       
        y.printName();
        x.printName();


        int a = 50;
        Console.WriteLine("a = "+a);
        var b = a;
        Console.WriteLine("b = " + b);

        /*As int or other primitive variables are 
         value type so the value of a will remain same
        */

        b = 40;
        Console.WriteLine("b = " + b);
        Console.WriteLine("a = " + a);




    }
}