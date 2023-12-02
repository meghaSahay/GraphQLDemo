using GraphQL;

namespace GraphQLDemo;

public class Query
{
    [GraphQLMetadata("employees")]
    public IEnumerable<Employee> GetEmployees()
    {
        return CompanyDB.GetEmployees();
    }

    [GraphQLMetadata("employee")]
    public Employee? GetEmployee(string name)
    {
        return CompanyDB.GetEmployee(name);
    }

}



