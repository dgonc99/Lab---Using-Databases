using System;
using SQLite;

namespace DatabaseModule01F
{
    public class CoursesManagerSQLite
    {
        //create an object for connection to db
        private SQLiteConnection database;

        public CoursesManagerSQLite()
        {
            //instantiating the connection object witht he path to the db
            //path to db is specifed in Constants class
            this.database = new SQLiteConnection(Constants.DatabasePath);

            //replaces sql query to create a table for courses class
            this.database.CreateTable<Courses>();
        }


        //add a course
        public void AddCourse(Courses course)
        {
            this.database.Insert(course);
        }

        //delete a course
        public void DeleteCourse(int id)
        {
            this.database.Delete<Courses>(id);
        }

        //getting all courses in db
        public List<Courses> GetAllCourses()
        {
            return this.database.Table<Courses>().ToList();
        }

        //getting 1 course by id
        public Courses GetCourseById(int id)
        {
            return this.database.Table<Courses>().
                Where(s => s.CourseID == id).FirstOrDefault();
        }

        //update a Course
        public void UpdateCourse(Courses course)
        {
            this.database.Update(course);
        }

    }
}