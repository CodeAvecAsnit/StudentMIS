namespace ConsoleApp1.StudentMIS;

public class StudentMisFunctions
{
    private List<Student?> studentList;
    
    

    public StudentMisFunctions()
    {
        this.studentList = [];
    }
    
    

    public StudentMisFunctions(List<Student> studentList)
    {
        this.studentList = studentList;
    }

    
    
    public void InsertNewStudent(Student? student)
    {
        studentList.Add(student);
    }
    
    

    public Student? FindById(int id)
    {
        return studentList.FirstOrDefault(student => student.StudentId == id);
    }
    
    

    public Student? RemoveById(int id)
    {
        var std = FindById(id);
        if (std != null)
        {
            studentList.Remove(std);
        }
        return std;
    }
    
    

    public Student? GetStudentByName(string username)
    {
        return studentList.FirstOrDefault(student => student.StudentName.Equals(username));
    }
    
    

    public List<Student?> SortByGPA()
    {
        return studentList.OrderBy(student => student.Gpa).ToList();
    }

    
    
    public void UpdateStudentInfo(Student stdData, int id)
    {
        var std = FindById(id);
        if (std != null)
        {
            std.StudentName = stdData.StudentName;
            std.Gpa = stdData.Gpa;
            std.Age = stdData.Age;
        }
        else
        {
            stdData.StudentId = id;
            studentList.Add(stdData);
        }
    }
    
    
    
    public List<Student?> GetAllStudentRecord()
    {
        return studentList;
    }

    
    

    public List<Student?> StudentsByName()
    {
        return studentList.OrderBy(student => student.StudentName).ToList();
    }

    
    
    public List<Student?> StudentByAge()
    {
        return studentList.OrderBy(student => student.Age).ToList();
        
    }

    
    public List<Student?> StudentsBGpa()
    {
        return studentList.OrderBy(student => student.Gpa).ToList();
    }
    
    

    public List<Student?> FilterByGPA(double gpaLowerLimit)
    {
        return studentList.Where(student => student.Gpa > gpaLowerLimit).ToList();
    }
    
    
    
    
    public List<Student?> FilterByGPA(double gpaLowerLimit,double gpaUpperLimit)
    {
        return studentList.Where(student => student.Gpa > gpaLowerLimit && student.Gpa<gpaUpperLimit).ToList();
    }
    
    
    
    public List<Student?> FilterByAge(int age)
    {
        return studentList.Where(student => student.Age > age).ToList();
    }


    public void StudentInfoDisplay(Student student)
    {
        Console.WriteLine($"Name : {student.StudentName}");
        Console.WriteLine($"Age : {student.Age}");
        Console.WriteLine(($"GPA : {student.Gpa}"));
        Console.WriteLine($"Id : {student.StudentId}");
        
    }

    public void DisplayList(List<Student?> sList)
    {
        foreach ( var std in sList)
        {
            if (std != null) StudentInfoDisplay(std);
            Console.WriteLine();
        }
    }
}
