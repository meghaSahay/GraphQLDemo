// See https://aka.ms/new-console-template for more information

using GraphQL.SystemTextJson;
using GraphQL.Types;
using GraphQLDemo;
using System.Text.RegularExpressions;

public class Program
{
    public static async Task Main(String[] args)
    {
        var schema = Schema.For(@" 
        type Employee{
            name: String,
            age: Int,
            salary: Float,
            isMarried: Boolean,
            designation: String,
            address: String,
            email: String,
            phone: String,
            skills: [String]
        }
         type Query{
            employees:[Employee]
            employee(name:String):Employee
        }
        
        ", _ =>
        {
            _.Types.Include<Query>();

        });

        var json = await schema.ExecuteAsync(_ =>
        {
            _.Query = "{employee(name:\"Luke\"){name,age,skills}}";

        });
        Console.WriteLine(Regex.Unescape(json));
    }
}



