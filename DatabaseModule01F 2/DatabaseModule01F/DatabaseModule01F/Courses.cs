using System;
using System.ComponentModel.DataAnnotations;
using SQLite;

namespace DatabaseModule01F
{
    public class Courses
    {
        [Required]//annotations
        [PrimaryKey]//sqlitepackage
        public int CourseID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Credits { get; set; }

        public Courses() 
        {
        }

        public override string ToString()
        {
            return $"ID: {CourseID}\t\t" +
                $"Name: {Name}\t\t" +
                $"Credits: {Credits}\t\t";
        }
    }
}