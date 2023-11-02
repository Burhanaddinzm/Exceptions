
using Exceptions.Exceptions;

namespace Exceptions
{
    public class Student
    {
        public string Name { get; set; }
        public Student(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                Name = name;
            }
            else
            {
                throw new EmptyNameException("Name can't be empty!");
            }
        }
    }
}
