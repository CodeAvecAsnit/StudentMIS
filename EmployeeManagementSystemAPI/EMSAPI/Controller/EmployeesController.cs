using Microsoft.AspNetCore.Mvc;
using Test.Model;
using Test.Service;

namespace Test.Controller;

[ApiController]
[Route("api/user")]
public class EmployeesController(EmployeeService employeeService) : ControllerBase
{
    
    [HttpGet("employees/all")]
    public List<EmployeesDto> GetAll()
    {
        return employeeService.GetAll();
    }

    [HttpPost("post")]
    public IActionResult InsertEmp([FromBody] EmployeesDto employees)
    {
        if (employeeService.InsertEmployee(employees))
        {
            return Ok("emp was successfully inserted.");
        }
        else return NotFound("User was not Inserted");
    }

    [HttpGet("username")]
    public EmployeesDto GetByUserName([FromQuery] string userName)
    {
        return  employeeService.GetEmployeeByUserName(userName);
    }

    [HttpGet("phone")]
    public EmployeesDto GetByPhone([FromQuery] string number)
    {
        return employeeService.GetEmployeeByPhoneNumber(number);
    }

    [HttpGet("salary/min")]
    public List<EmployeesDto> FilterMin(decimal min)
    {
        return employeeService.FilterBySalary(min);
    }

    [HttpGet("salary/range")]
    public List<EmployeesDto> FilterMinMax([FromQuery] decimal min, [FromQuery] decimal max)
    {
        return employeeService.FilterBySalary(min, max);
    }

    [HttpGet("salary/max")]
    public List<EmployeesDto> FilterMax([FromQuery]decimal max)
    {
        return employeeService.FilterByMaxSalary(max);
    }

    [HttpGet("address")]
    public List<EmployeesDto> FindByAddress([FromQuery] string location)
    {
        return employeeService.FindByAddress(location);
    }
}