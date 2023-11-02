using Exceptions;
using Exceptions.Exceptions;

try
{
    Student student = new Student(" ");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}