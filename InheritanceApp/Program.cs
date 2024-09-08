using InheritanceApp;

Teacher teacher1 = new Teacher();
teacher1.Name = "John";
teacher1.Surname = "Sorkin";
teacher1.Salary = 2000;
teacher1.TeacherIntroduce();
Console.WriteLine("--------------------------------");
Student student1 = new Student();
student1.Name = "Ryan";
student1.Surname = "Toretto";
student1.StudentNumber = 432;
student1.StudentIntroduce();