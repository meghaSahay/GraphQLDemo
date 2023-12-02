namespace GraphQLDemo;

public class CompanyDB
{
    public static IEnumerable<Employee> GetEmployees()
    {
        var result = new List<Employee>()
        {
            new Employee() {Name = "Luke", Age = 30, Skills = new List<string>{"Python","C","ML"}},
            new Employee() {Name = "Yoda", Age = 23,Skills =new List<string> {"Go","C++","React"}},
            new Employee() {Name = "Darth Vadar", Age = 35,Skills = new List<string>{"Java","C#","React"}}
        };
        return result;
    }

    public static Employee? GetEmployee(string name)
    {

        return GetEmployees().FirstOrDefault(employee => employee.Name == name);
    }


}
public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public float Salary { get; set; }
    public bool IsMarried { get; set; }
    public string Designation { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public List<string> Skills { get; set; }
}

