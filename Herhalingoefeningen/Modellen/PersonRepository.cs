using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingoefeningen.Modellen
{
    internal class PersonRepository
    {
        private readonly SqlConnection _connection;

        public PersonRepository(SqlConnection connection)
        {
            _connection = connection;

            _connection.Open();
        }
        public void Dispose()
        {
            _connection.Dispose();
        }

        public void AddPerson(Person person)

        {
            if (person.Age < 18 || person.Age > 99)
            {
                throw new ArgumentException("Age must be between 18 and 99.");
            }

            if (person.GetType() == typeof(Student))
            {
                Student student = (Student) person;
                using var command = _connection.CreateCommand();
                command.CommandText = $"INSERT INTO dbo.Students (FirstName,LastName,Age,Password) VALUES(@Firstname,@Lastname,@Age,@Year);";
                command.Parameters.AddWithValue("@Firstname", student.FirstName);
                command.Parameters.AddWithValue("@Lastname", student.LastName);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Year", student.Year);
                command.ExecuteNonQuery();


            }
            if (person.GetType() == typeof(Teacher))

            {
                Teacher teacher = (Teacher) person;
                using var command = _connection.CreateCommand();
                command.CommandText = $"INSERT INTO dbo.Teachers (FirstName,LastName,Age,Password) VALUES(@Firstname,@Lastname,@Age,@Subject);";
                command.Parameters.AddWithValue("@Firstname", teacher.FirstName);
                command.Parameters.AddWithValue("@Lastname", teacher.LastName);
                command.Parameters.AddWithValue("@Age", teacher.Age);
                command.Parameters.AddWithValue("@Subject", teacher.Subject);
                command.ExecuteNonQuery();

            }
        }

        public void DeletePerson(Person person)
        {
            if (person.GetType() == typeof(Student))
            {
                Student student = (Student)person;
                using var command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM dbo.Students WHERE FirstName = @FirstName AND LastName = @LastName AND Age = @Age AND Year = @Year;";
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Year", student.Year);
                command.ExecuteNonQuery();
            }
            else if (person.GetType() == typeof(Teacher))
            {
                Teacher teacher = (Teacher)person;
                using var command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM dbo.Teachers WHERE FirstName = @FirstName AND LastName = @LastName AND Age = @Age AND Subject = @Subject;";
                command.Parameters.AddWithValue("@FirstName", teacher.FirstName);
                command.Parameters.AddWithValue("@LastName", teacher.LastName);
                command.Parameters.AddWithValue("@Age", teacher.Age);
                command.Parameters.AddWithValue("@Subject", teacher.Subject);
                command.ExecuteNonQuery();
            }
        }
    }
}
