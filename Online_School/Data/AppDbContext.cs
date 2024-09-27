using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Online_School.Entities;
using Online_School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Data;

public class AppDbContext: IdentityDbContext<IdentityUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public virtual DbSet<AppUser> AppUsers { get; set; }
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<Teacher> Teachers { get; set; }
    public virtual DbSet<Student> Students { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Teacher>().HasData
        (
            new Teacher
            {
                Id = 1,
                FullName = "Nasriddinov Abdurahmon",
                Subject = "Ingliz tili oqituvchisi",
                Description = " Erishgan natijalari Ielts darajasi : 8.5. 3 yillik tajribaga ega ",
                ImageUrl = ""
            },
            new Teacher
            {
                Id= 2,
                FullName = "Sultonova Mahbubaxon",
                Subject = "Ona tili oqituvchisi",
                Description = "5 yillik tajribaga ega bolgan oqituvchi. Minglab oquvchilarimizga dars bergan ",
                ImageUrl = ""
            }
        );
        builder.Entity<Course>().HasData
            (
            new Course
            {
                Id = 1,
                CourseName = "Ingliz tili",
                TeacherName = "Mr Abdurahmon",
                Description = "Kursimiz haqida toliqroq malumot olish ushun tel : +998-95-215-72-27 ",
                CoursePrice = 500,
                ImageUrl = "",
                

            },
             new Course
             {
                 Id = 2,
                 CourseName = "Ona tili",
                 TeacherName = "Mahbubaxon Sultonova",
                 Description = "Kursimiz haqida toliqroq malumot olish ushun tel : +998-95-215-72-27 ",
                 CoursePrice = 500,
                 ImageUrl = "",
                 //TeacherImageUrl = ""

             }
            );

        builder.Entity<Student>().HasData
             (
                new Student 
                { 
                    Id = 1,
                    FullName = "Shohjahon Alijonov",
                    Address = "Qoqon",
                    PhoneNumber = "90-307-78-47",
                    Description = "03.06.2003 yil tugilgan , Otasining ismi : Ulugbek , Otasining telefon raqami : 99-721-72-27",
                    CourseName = "Ingliz tili"
                },

                new Student
                {
                    Id = 2,
                    FullName = "Nodirbek Alijonov",
                    Address = "Qoqon",
                    PhoneNumber = "90-307-78-47",
                    Description = "03.06.2006 yil tugilgan , Otasining ismi : Ulugbek , Otasining telefon raqami : 99-721-72-27",
                    CourseName = "Ona tili"
                }

            );
    }
}
