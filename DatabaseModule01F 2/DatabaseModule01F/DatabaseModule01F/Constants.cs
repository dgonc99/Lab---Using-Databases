using System;
namespace DatabaseModule01F
{
	public class Constants
	{
		//name of db is made constant
		public const string DatabaseFilename = "Student.db3";
		public static string DatabasePath =>
			Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,DatabaseFilename);

		public Constants()
		{
		}
	}
}

