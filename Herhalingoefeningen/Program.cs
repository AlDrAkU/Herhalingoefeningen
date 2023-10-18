using Herhalingoefeningen.Modellen;
using Microsoft.Data.SqlClient;


/*using var connection = new SqlConnection("Data Source=(local);Initial Catalog=example_db;Integrated Security=True;Encrypt=False");
await connection.OpenAsync();
using var command = connection.CreateCommand();
command.CommandText = "INSERT INTO dbo.Teachers (FirstName,LastName,Age,Subject) VALUES(@Firstname,@Lastname,@Age,@Subject);";
command.Parameters.AddWithValue("@Firstname", "Margot");
command.Parameters.AddWithValue("@Lastname", "Delait");
command.Parameters.AddWithValue("@Age", 48);
command.Parameters.AddWithValue("@Subject", "English");
var count = await command.ExecuteNonQueryAsync(); 

Console.WriteLine("Amount of rows affected: {0}", count);
using var command2 = connection.CreateCommand();
command2.CommandText = "INSERT INTO dbo.Students (FirstName,LastName,Age,Year) VALUES(@Firstname,@Lastname,@Age,@Year);";
command2.Parameters.AddWithValue("@Firstname", "Maarten");
command2.Parameters.AddWithValue("@Lastname", "Delvoort");
command2.Parameters.AddWithValue("@Age", 22);
command2.Parameters.AddWithValue("@Year", 3);
var count2 = await command2.ExecuteNonQueryAsync();

Console.WriteLine("Amount of rows affected: {0}", count2);
*/


Repository<Person> personRepository = new Repository<Person>();

// Add some students
personRepository.Add(new Student { FirstName = "Alice", LastName = "Smith", Age = 20, Year = 2 });
personRepository.Add(new Student { FirstName = "Bob", LastName = "Johnson", Age = 19, Year = 1 });

// Add some teachers
personRepository.Add(new Teacher { FirstName = "John", LastName = "Doe", Age = 35, Subject = "Math" });
personRepository.Add(new Teacher { FirstName = "Jane", LastName = "Smith", Age = 40, Subject = "Science" });

// Get and print student and teacher information
Console.WriteLine("Persons:");
foreach (var person in personRepository.GetAll())

{
    if (person.GetType() == typeof(Teacher))
    {
        Teacher teacher = (Teacher)person;
        Console.WriteLine($"Teacher: Name: {teacher.GetFullName()}, Age: {teacher.Age}, Year: {teacher.Subject}");
    }
    if (person.GetType() == typeof(Student))
    {
        Student student = (Student)person;
        Console.WriteLine($"Student: Name: {student.GetFullName()}, Age: {student.Age}, Year: {student.Year}");
    }

}
Person.AssignName(new Person());


