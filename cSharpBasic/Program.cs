
namespace cSharpBasic
{

    class Student
    {
        public string name;
        public int age;

        public Student(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void printName()
        {
            Console.WriteLine("name is : " + name);
        }

       public  void printAge()
        {
            Console.WriteLine("Age is : " + age);
        }

        static string faculty = "CSE";

    }

    class Test
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Rakibul Islam",25);

            student1.printName();
            student1.printAge();
        }
    }

}