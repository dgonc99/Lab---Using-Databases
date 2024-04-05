using System;
using System.ComponentModel.DataAnnotations;
using SQLite;

namespace DatabaseModule01F
{
	public class Student
	{
		[Required]
		public string Name { get; set; }

		[Required]//annotations
		[PrimaryKey, AutoIncrement]//sqlite package
		public int Id { get; set; }

		[Required]
		public string Email { get; set; }

		public string Address { get; set; }

		public Student()
		{
		}

        public override string ToString()
        {
            return $"Id: {Id}\t\t" +
				$"Name: {Name}\t\t" +
				$"Email: {Email}\t\t" +
				$"Address: {Address}\t\t";
        }
    }
}

