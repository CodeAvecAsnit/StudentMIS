namespace ConsoleApp1.StudentMIS;

public class Student
{
    
    
    public Student(){}

    public Student(int studentId, string studentName, int age, float gpa)
    {
        this.StudentId = studentId;
        this.StudentName = studentName;
        this.Age = age;
        this.Gpa = gpa;
    }

    public int StudentId { get; set; }

    public string StudentName { get; set; }

    public int Age { get; set; }

    public float Gpa { get; set; }
}


