
using assignment17.Context;
using assignment17.Entities;
using Microsoft.EntityFrameworkCore;


namespace assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();
            
            var newStudent = new Student
            {
                FName = "philo",
                LName = "atef",
                Age = 25,
                Address = "whatever",
                Dep_Id = 1
            };

            var newStudent2 = new Student
            {
                FName = "body",
                LName = "ehab",
                Age = 22,
                Address = "whatever",
                Dep_Id = 2
            };
           
            dbContext.Set<Student>().Add(newStudent);
           
            dbContext.Add(newStudent2);
           
            dbContext.SaveChanges();
           

            var student = (from S in dbContext.Set<Student>()
                           where S.St_Id == 1
                           select S).FirstOrDefault();
          
            Console.WriteLine(student?.FName ?? "N/A");
            
            student.Dep_Id = 3;

            dbContext.SaveChanges();

            dbContext.Remove(student);

            dbContext.SaveChanges();




        }
    }
}
