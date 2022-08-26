#return male students list
IEnumerable<Student> queryResult = from student in Student.GetAllStudent() where student.Gender == "Male" select student;

 

#Aggregate function:(min, max,sum, count, average)
-------------------------
 
int[] numbers = {1,2,3,4,5,6,7,8,9};
var result = numbers.Where(x=>x%2==0);
int minNumber = result.min();
int sum = numbers.sum();

int sumOfEven = numbers.Where(x=>x%2==0).sum();
int len = numbers.Count();

 
string[] countries = {"India", "USE","UK"};
var smallCountryLen = countries.Min(country=>country.Length);


#Aggregate:
----------------
var stringArrayToCommaSeparetString = countries.Aggregate((a,b)=>a+", "+b);
int[] numbers = {1,2,3,4,5,6,7,8,9};
int productOfItem = numbers.Aggregate((a,b)=>a*b);//seed = 1 default
int productOfItem = numbers.Aggregate(10,(a,b)=>a*b);//seed = 10 default

