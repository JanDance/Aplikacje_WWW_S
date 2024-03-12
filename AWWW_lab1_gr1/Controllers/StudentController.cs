using Microsoft.AspNetCore.Mvc; 
using AWWW_lab1_gr1.Models; 

public class StudentController:Controller
{
    public ActionResult Index(int id=1)
    {
        var student = new List<Student>
        {
            new Student 
            {
                Id = 1, 
                FirstName = "Naz", 
                LastName = "James",
                IndexNr = 1337, 
                DateOfBirth = new DateTime(2004,3,12),
                FieldOfStudy = "Math"
            },

            new Student 
            {
                Id = 2, 
                FirstName = "Nu", 
                LastName = "Nu",
                IndexNr = 1488, 
                DateOfBirth = new DateTime(2003,2,26),
                FieldOfStudy = "Engl"
            },

            new Student 
            {
                Id = 3, 
                FirstName = "Kasha", 
                LastName = "Porter",
                IndexNr = 2289, 
                DateOfBirth = new DateTime(2008,4,2),
                FieldOfStudy = "Fizyk"
            }


        };
        return View(student[id-1]);
    }
}