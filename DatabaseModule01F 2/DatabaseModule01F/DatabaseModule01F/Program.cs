using MySqlConnector;

namespace DatabaseModule01F;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);

        ////creating connection string
        //MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
        //{
            //Server = "127.0.0.1",
            //UserID = "root",
            //Password = "Cprg211Demo",
            //Database = "StudentDatabaseE"
        //};

        //Console.WriteLine(builder.ConnectionString);

        //StudentManager studentManager = new StudentManager(builder.ConnectionString);

        //List<Student> students = studentManager.GetAllStudents();

        //Console.WriteLine("Printing Students");
        //foreach(var student in students)
        //{
        //    Console.WriteLine(student);
        //}

        ////adding a new student
        //Console.WriteLine("\nAdding new student...");
        //Student newStudent = new Student
        //{
        //    Name = "Matt Damon",
        //    Email = "matt@sait.ca",
        //    Address = "12345 Main Street"
        //};
        ////studentManager.AddStudent(newStudent);
        //Console.WriteLine("New Student added");


        ////updating a student
        //Console.WriteLine("\n\nUpdating new Student...");
        //Student studentToUpdate = students[9];
        //studentToUpdate.Email = "updatedemail@sait.ca";
        //studentToUpdate.Address = "updatedAddress 32nd Ave";
        //studentManager.UpdateStudent(studentToUpdate);
        //Console.WriteLine("Student update completed");

        ////deleting student
        //Console.WriteLine("\n\nDeleting a student from db.....");
        ////int studentToDelete = students[11].Id;
        ////studentManager.DeleteStudent(studentToDelete);
        //Console.WriteLine("Deletion completed");


        ////retrieving a student by id
        //Console.WriteLine("\n\nretrieving a student by id from db.....");
        //int studentToFetch = students[8].Id;
        //Student retrievedStudent = studentManager.GetStudentById(studentToFetch);
        //if(retrievedStudent != null)
        //{
        //    Console.WriteLine(retrievedStudent);
        //}
        //else
        //{
        //    Console.WriteLine("Student not found or invlaid id");
        //}

        //Console.WriteLine("****USING SQLITE WITH ORM***");
        //Student student = new Student
        //{
            //Name = "Jane",
            //Email = "Jane@sait.ca",
            //Address = "999 Main Str. Calgary"
        //};
        //create object to sqlite student manager
        //StudentManagerSQLite sqliteDb = new StudentManagerSQLite();
        //sqliteDb.AddStudent(student);
        //Console.WriteLine("Adding student completed");

        //adding all the students from MySQL db to sqlite db
        //foreach(var eachStudent in students)
        //{
        //    Console.WriteLine(eachStudent);
        //    sqliteDb.AddStudent(eachStudent);
        //}

        //sqliteDb.DeleteStudent(11);

        //Retrieving all students in db
        //Console.WriteLine("Displaying all the students in db");
        //List<Student> studentsSqlite = sqliteDb.GetAllStudents();
        //foreach(var allStudents in studentsSqlite)
        //{
            //Console.WriteLine(allStudents);
        //}

        //retrieving student by id
        //Console.WriteLine("\n\nRetrieving just 1 student using id");
        //Student jessica = sqliteDb.GetStudentById(7);
        //Console.WriteLine(jessica);

        //Console.WriteLine("\n\nupdating student details");
        //jessica.Email = "jessica.brown@sait.ca";
        //jessica.Address = "123 SAIT Avenue";
        //sqliteDb.UpdateStudent(jessica);
        //Console.WriteLine(jessica);


        Console.WriteLine("****USING SQLITE WITH ORM***");
        Courses  course1 = new Courses
        {
            CourseID = 1001,
            Name = "Fundamentals of Web Development",
            Credits = 3
        };
        Courses course2 = new Courses
        {
            CourseID = 1002,
            Name = "Introduction to Full Stack Programming",
            Credits = 3
        };
        Courses course3 = new Courses
        {
            CourseID = 1003,
            Name = "Databases",
            Credits = 3
        };
        Courses course4 = new Courses
        {
            CourseID = 1004,
            Name = "Principles of Software Design and Analysis",
            Credits = 4
        };
        Courses course5 = new Courses
        {
            CourseID = 1005,
            Name = "Object-Oriented Programming",
            Credits = 4
        };



        //create objects to sqlite course manager
        CoursesManagerSQLite sqliteDb = new CoursesManagerSQLite();

        //emptying Courses table
        sqliteDb.DeleteCourse(1001);
        sqliteDb.DeleteCourse(1002);
        sqliteDb.DeleteCourse(1003);
        sqliteDb.DeleteCourse(1004);
        sqliteDb.DeleteCourse(1005);

        sqliteDb.AddCourse(course1);
        Console.WriteLine("Adding course completed");
        sqliteDb.AddCourse(course2);
        Console.WriteLine("Adding course completed");
        sqliteDb.AddCourse(course3);
        Console.WriteLine("Adding course completed");
        sqliteDb.AddCourse(course4);
        Console.WriteLine("Adding course completed");
        sqliteDb.AddCourse(course5);
        Console.WriteLine("Adding course completed");

        //retrieving all courses in the database
        Console.WriteLine("Displaying all the courses in db");
        List<Courses> coursesSqlite = sqliteDb.GetAllCourses();
        foreach (var allCourses in coursesSqlite)
        {
            Console.WriteLine(allCourses);
        }

        //retrieving course by id
        Console.WriteLine("\n\nRetrieving just 1 course using id");
        Courses databases = sqliteDb.GetCourseById(1003);
        Console.WriteLine(databases);

        //updating a course by id
        Console.WriteLine("\n\nupdating course details");
        databases.Name = "Databases 2";
        databases.Credits = 4;
        sqliteDb.UpdateCourse(databases);
        Console.WriteLine(databases);

        //deleting a course by id
        sqliteDb.DeleteCourse(1005);

        //retrieving all courses after delete
        Console.WriteLine("Displaying all the courses in db after deletion");
        List<Courses> coursesSqliteUpdated = sqliteDb.GetAllCourses();
        foreach (var allCourses in coursesSqliteUpdated)
        {
            Console.WriteLine(allCourses);
        }
    }
}

