#return male students list
IEnumerable<Student> queryResult = from student in Student.GetAllStudent() where student.Gender == "Male" select student;

 

       
