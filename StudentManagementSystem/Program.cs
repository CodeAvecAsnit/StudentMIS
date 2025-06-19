using ConsoleApp1.StudentMIS;



Console.WriteLine("Welcome to the Student Management Software");


Console.WriteLine("Press One to add a Student");
Console.WriteLine("Press Two to find the Student by Id ");
Console.WriteLine("Press Three to Remove a Student  ");
Console.WriteLine("Press Four to find the Student by name");
Console.WriteLine("Press Five to Update the data of a student");
Console.WriteLine("Press Six to See all the data of the students ");
Console.WriteLine("Press Seven to sort the students by name ");
Console.WriteLine("Press eight to sort the students by age ");
Console.WriteLine("Press nine to sort the students by gpa ");
Console.WriteLine("Press ten to filter the students by gpa(lower bound)");
Console.WriteLine("Press eleven to filter the students by gpa(lower and upper bound");
Console.WriteLine("Press twelve to filter the students by age");



var functions = new StudentMisFunctions();
int a,autoId=0;
do 
{
    try
    {
        a = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        a = 13;
    }
    

    switch(a)

    {
        case 1 :
            ++autoId;
            
            var student = new Student {
                StudentId = autoId
            };

            Console.Write("Enter the name of the student : ");
            student.StudentName = Console.ReadLine();

            Console.Write("Enter the age of the student : ");
            student.Age = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the gpa of the Student :  ");
            student.Gpa = float.Parse(Console.ReadLine());
            
            Console.WriteLine($"Student Id : {autoId}");
            
            functions.InsertNewStudent(student);
            break;
            
        case 2:
            Console.Write("Enter the Id of the Student : ");
            var id = int.Parse(Console.ReadLine());

            var std = functions.FindById(id);
            if (std != null)
            {
                functions.StudentInfoDisplay(std);
            }else Console.WriteLine("The student does not exist");

            break;
        
        
        case 3 :
            Console.Write("Enter the Id of the Student : ");
            var stdId = int.Parse(Console.ReadLine());

            var stud = functions.RemoveById(stdId);
            if (stud != null)
            {
                functions.StudentInfoDisplay(stud);
            }else Console.WriteLine("The student does not exist");

            break;
        
        case 4:
            Console.Write("Enter the Name of the Student : ");
            var name = Console.ReadLine();

            if (name != null)
            {
                var std1 = functions.GetStudentByName(name);
                if (std1 != null) functions.StudentInfoDisplay(std1);
            }else Console.WriteLine("Please Enter the name ");
            break;
        
        
        case 5:
            Console.WriteLine("Enter the id of the student you want to update : ");

            var Xstd = new Student();
            Xstd.StudentId = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the name of the student : ");
            Xstd .StudentName = Console.ReadLine();

            Console.Write("Enter the age of the student : ");
            Xstd.Age = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the gpa of the Student :  ");
            Xstd.Gpa = float.Parse(Console.ReadLine());
            
            functions.UpdateStudentInfo(Xstd,Xstd.StudentId);
            break;
        
        case 6:
            functions.DisplayList(functions.GetAllStudentRecord());
            break;
        
        case 7 :
            functions.DisplayList(functions.StudentsByName());
            break;
        
        case 8: 
            functions.DisplayList(functions.StudentByAge());
            break;
        
        case 9:
            functions.DisplayList(functions.StudentsBGpa());
            break;
        
        case 10:
            Console.Write("Enter the Lower bound of gpa : ");
            var gpa = float.Parse(Console.ReadLine()); 
            
            functions.DisplayList(functions.FilterByGPA(gpa));
            break;
        
        case 11:
            Console.Write("Enter the Lower bound of gpa : ");
            var gpaLow = float.Parse(Console.ReadLine()); 
            
            Console.Write("Enter the Higher bound of gpa : ");
            var gpaHigh = float.Parse(Console.ReadLine()); 

            
            functions.DisplayList(functions.FilterByGPA(gpaLow,gpaHigh));
            break;
        
        
        case 12:
            Console.Write("Enter the Age : ");
            var age = int.Parse(Console.ReadLine()); 
            
            functions.DisplayList(functions.FilterByAge(age));
            break;
        
        default:
            a = 13;
            break;
    }
}    while (a != 13) ;
