namespace Test.Model;

public class Person
{
    public string userName { get; set; }
    public long userId { get; set; }

    public Person(string userName, long id)
    {
        this.userName = userName;
        this.userId = id;
    }

    public Person()
    {
    }
}