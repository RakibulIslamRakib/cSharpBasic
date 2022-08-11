

namespace StaticExample
{
    class Demo1
    {
        public void sayHello()
        {
            Console.WriteLine("Hello from Demo1 class method !");
        }

    }
    class Demo2
    {
        public static void sayHello()
        {
            Console.WriteLine("Hello from Demo2 class static method !");
        }

    }

    class Test
    {
        static void Main(string[] args)
        {
            //calling norlam method using object
            var demo1 = new Demo1();
            Demo2.sayHello();

            //calling norlam method using object
            var demo2 = new Demo2();

            /*
            demo2.sayHello();  error occurs. sayHello cannot be acces from object
            */

            Demo2.sayHello();
            /*
             static method should call using classname.staticmethod name
            because static method   are referenced by the class name itself 
            */
        }
    }
}