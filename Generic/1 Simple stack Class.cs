namespace Stack
{
    class SimpleStack
    {
        double[] myStack;
        private int currentIndex = -1;

        public int Count => currentIndex + 1;

        public SimpleStack()
        {
            myStack = new double[10];
        }

        public void push(double item)
        {
            myStack[++currentIndex] = item;
        }
        public double pop()
        {
            return myStack[currentIndex--];
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            SimpleStack stack1 = new SimpleStack();
            stack1.push(1);
            stack1.push(2);
            stack1.push(3);
            stack1.push(4);
            stack1.push(5);

            while(stack1.Count > 0)
            {
                Console.WriteLine( "count : "+stack1.Count +" , item : "+stack1.pop());
            }
        }
    }
}
