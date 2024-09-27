using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Online_School.Entities;

public class Course
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string? CourseName { get; set; }
    [Required]
    public string TeacherName { get; set; }
    
    
    [Required]
    [Range(1,1000000)]
    public double CoursePrice { get; set; }
    public string Description { get; set; }
    [ValidateNever]
    public string ImageUrl { get; set; }
}
