using System;
using SQLite;

namespace DatabaseModule01F
{
	public class StudentManagerSQLite
	{
		//create an object for connection to db
		private SQLiteConnection database;

		public StudentManagerSQLite()
		{
			//instantiating the connection object witht he path to the db
			//path to db is specifed in Constants class
			this.database = new SQLiteConnection(Constants.DatabasePath);

			//replaces sql query to create a table for student class
			this.database.CreateTable<Student>();
		}


		//add a student
		public void AddStudent(Student student)
		{
			this.database.Insert(student);
		}

		//delete a student
		public void DeleteStudent(int id)
		{
			this.database.Delete<Student>(id);
		}

		//getting all students in db
		public List<Student> GetAllStudents()
		{
			return this.database.Table<Student>().ToList();
		}

		//getting 1 student by id
		public Student GetStudentById(int id)
		{
			return this.database.Table<Student>().
				Where(s => s.Id == id).FirstOrDefault();
		}

		//update a student
		public void UpdateStudent(Student student)
		{
			this.database.Update(student);
		}

	}
}

