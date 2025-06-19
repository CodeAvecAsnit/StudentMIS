using Test.Model;

namespace Test.Service;

public class EmployeeService
{
    private readonly CsvOperations _operations;
    private List<EmployeesDto> _employees;
    private readonly string _filePath;

    public EmployeeService(CsvOperations operations)
    {
        _operations = operations;
        _filePath = Path.Combine("Data", "Users.csv");
        _employees = _operations.ReadCsv(_filePath);
    }

    public EmployeesDto GetEmployeeByUserName(string username)
    {
        return _employees.FirstOrDefault(emp => emp.Username.Equals(username));
    }

    public EmployeesDto GetEmployeeByPhoneNumber(string phoneNumber)
    {
        return _employees.FirstOrDefault(emp => emp.PhoneNumber.Equals(phoneNumber));
    }

    public List<EmployeesDto> GetAll()
    {
        return _employees;
    }

    public bool InsertEmployee(EmployeesDto employee)
    {
        var result = _operations.WriteCSV(_filePath, employee);
        if (result)
        {
            _employees = _operations.ReadCsv(_filePath);
        }
        return result;
    }

    public List<EmployeesDto> FilterBySalary(decimal minSalary)
    {
        return _employees.Where(emp => emp.Salary > minSalary).ToList();
    }

    public List<EmployeesDto> FilterBySalary(decimal minSalary, decimal maxSalary)
    {
        return SortAsc(_employees.Where(emp => emp.Salary > minSalary && emp.Salary < maxSalary).ToList());
    }

    public List<EmployeesDto> FilterByMaxSalary(decimal maxSalary)
    {
        return SortDsc(_employees.Where(emp => emp.Salary < maxSalary).ToList());
    }

    public List<EmployeesDto> FindByAddress(string address)
    {
        return _employees.Where(emp => emp.Address.Equals(address)).ToList();
    }

    private static List<EmployeesDto> SortAsc(List<EmployeesDto> emp)
    {
        return emp.OrderBy(entity => entity.Salary).ToList();
    }
    
    private static List<EmployeesDto> SortDsc(List<EmployeesDto> emp)
    {
        return emp.OrderByDescending(entity => entity.Salary).ToList();
    }
}