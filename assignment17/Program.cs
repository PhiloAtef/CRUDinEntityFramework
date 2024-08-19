
using assignment17.Context;
using assignment17.Entities;
using Microsoft.EntityFrameworkCore;

namespace assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext dbContext = new ITIDbContext();
            dbContext.Database.Migrate();

            var newStudent = new Student
            {
                FName = "John",
                LName = "Doe",
                Age = 20,
                Address = "123 Main St",
                Dep_Id = 1
            };

            dbContext.Set<Student>().Add(newStudent);
        }
    }
}
