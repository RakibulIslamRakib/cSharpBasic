namespace Stack
{
    class SimpleStack<T>
    {
        T[] myStack;
        private int currentIndex = -1;

        public int Count => currentIndex + 1;

        public SimpleStack()
        {
            myStack = new T[10];
        }

        public void push(T item)
        {
            myStack[++currentIndex] = item;
        }
        public T pop()
        {
            T valuex = myStack[currentIndex--];
            return valuex;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
           var stackDouble = new SimpleStack<object>();
            stackDouble.push(1);
            stackDouble.push(2.5);
            stackDouble.push(3);
            stackDouble.push(4);
            stackDouble.push(5);
            stackDouble.push("one");
            stackDouble.push("two");
            stackDouble.push("three");
            stackDouble.push("four");
            stackDouble.push('A');

            while (stackDouble.Count > 0)
            {
                Console.WriteLine( "count : "+ stackDouble.Count +" , item : "+ stackDouble.pop());
            }


          
        }
    }
}
