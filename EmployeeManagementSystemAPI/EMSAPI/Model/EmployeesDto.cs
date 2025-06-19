namespace Test.Model;

public class EmployeesDto
{
    public string Username { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Salary { get; set; }
    public string Address { get; set; }
    
    public EmployeesDto(){}

    public EmployeesDto(string username, string phoneNumber, decimal salary, string address)
    {
        Username = username;
        PhoneNumber = phoneNumber;
        Salary = salary;
        Address = address;
    }
}