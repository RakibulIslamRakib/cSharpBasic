namespace Stack
{
    class SimpleStack
    {
        object[] myStack;
        private int currentIndex = -1;

        public int Count => currentIndex + 1;

        public SimpleStack()
        {
            myStack = new object[10];
        }

        public void push(object item)
        {
            myStack[++currentIndex] = item;
        }
        public object pop()
        {
            object valuex = myStack[currentIndex--];
            return valuex;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
           var stackDouble = new SimpleStack();
            stackDouble.push(1);
            stackDouble.push(2);
            stackDouble.push(3);
            stackDouble.push(4);
            stackDouble.push(5);

            while(stackDouble.Count > 0)
            {
                Console.WriteLine( "count : "+ stackDouble.Count +" , item : "+ stackDouble.pop());
            }


            var stackString = new SimpleStack();
            stackString.push("one");
            stackString.push("two");
            stackString.push("three");
            stackString.push("four");
            stackString.push("five");

            while (stackString.Count > 0)
            {
                Console.WriteLine("count : " + stackString .Count + " , item : " + stackString.pop());
            }
        }
    }
}
