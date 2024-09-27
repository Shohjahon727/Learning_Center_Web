using Microsoft.AspNetCore.Identity;
using Online_School.Entities;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Online_School.Models;

public class AppUser : IdentityUser
{
    [Required]
    public string? Name { get; set; }
    public int Age { get; set; }
    public DateTime Birthdate { get; set; }
    public string? Address { get; set; }
    public string? FatherName { get; set; }
   

    //public virtual List<Course> Courses { get; set; }
    //public virtual List<Student> Students { get; set; }
    //public virtual List<Teacher> Teachers { get; set; }
}
