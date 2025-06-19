using Microsoft.AspNetCore.Mvc;
using Test.Model;

namespace Test.Controller;

[ApiController]
[Route("persons")]
public class TestController : ControllerBase
{
    [HttpGet("get")]
    public Person getPerson()
    {
        return new Person("Asnit", 1);
    }

    [HttpPost("post")]
    public IActionResult set_X([FromBody] Person person)
    {
        Console.Write($"{person.userId}. {person.userName}");
        return Ok("User is sucessfully Inserted");
    }
}