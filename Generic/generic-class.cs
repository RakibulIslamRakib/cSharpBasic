namespace Generics
{
    class GenericArray<T>
    {
        private T[] array;
        public GenericArray(int size)
        {
            array = new T[size + 1];
        }
           
        public T getItem(int index)
        {
            return array[index];

        }
       
        public void setItem(int index, T value)
        {
            array[index] = value;
        }

    }


    class Test
    {
        static void Main(string[] args)
        {
            var generics = new GenericArray<int>(5);
            generics.setItem(0, 1);
            generics.setItem(1, 2);
            generics.setItem(2, 3);
            generics.setItem(3, 4);
            generics.setItem(4, 5);

            for(int i= 0; i < 5; i++)
            {
                Console.Write(generics.getItem(i)+" ");
            }

            Console.WriteLine();
            GenericArray<char> charArray = new GenericArray<char>(5);
            //setting values
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }

            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
            Console.WriteLine();

        }
    }
}
