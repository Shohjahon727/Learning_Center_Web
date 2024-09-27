using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_School.Entities;
using School.DataAccess.Data;

namespace Online_School.Controllers;

public class CourseController : Controller
{
    private readonly AppDbContext _context;
    private readonly IWebHostEnvironment _webHostEnvironment;
    public CourseController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
    {
        _context = context;
        _webHostEnvironment = webHostEnvironment;
    }
    // GET: Course
    public IActionResult Index()
    {
        var courses = _context.Courses.ToList();
        return View(courses);
    }

    // GET: Course/Details/5
    //public IActionResult Details(int id)
    //{
    //    var course = _context.Courses.Find(id);
    //    if (course == null)
    //    {
    //        return NotFound();
    //    }
    //    return View(course);
    //}

    // GET: Course/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Course/Create
    [HttpPost]
    public IActionResult Create(Course model, IFormFile Image)
    {
        if (ModelState.IsValid)
        {
            // Rasm yuklanganligini tekshirish
            if (Image != null && Image.Length > 0)
            {
                // wwwroot/images papkasiga rasmni saqlash uchun yo'l
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Faylni serverga saqlash
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Image.CopyTo(fileStream);
                }

                // Modelda rasm fayl nomini saqlash
                model.ImageUrl = "/images/" + uniqueFileName;
            }

            // Bu yerda modelni ma'lumotlar bazasiga saqlash kerak (masalan, repository orqali)

            return RedirectToAction("Index");
        }

        return View(model);
    }

    //// GET: Course/Edit/5
    //public IActionResult Edit(int id)
    //{
    //    var course = _context.Courses.Find(id);
    //    if (course == null)
    //    {
    //        return NotFound();
    //    }
    //    return View(course);
    //}

    //// POST: Course/Edit/5
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public IActionResult Edit(int id, Course course)
    //{
    //    if (id != course.Id)
    //    {
    //        return NotFound();
    //    }

    //    if (ModelState.IsValid)
    //    {
    //        _context.Update(course);
    //        _context.SaveChanges();
    //        return RedirectToAction(nameof(Index));
    //    }
    //    return View(course);
    //}

    //// GET: Course/Delete/5
    //public IActionResult Delete(int id)
    //{
    //    var course = _context.Courses.Find(id);
    //    if (course == null)
    //    {
    //        return NotFound();
    //    }

    //    return View(course);
    //}

    //// POST: Course/Delete/5
    //[HttpPost, ActionName("Delete")]
    //[ValidateAntiForgeryToken]
    //public IActionResult DeleteConfirmed(int id)
    //{
    //    var course = _context.Courses.Find(id);
    //    if (course == null)
    //    {
    //        return NotFound();
    //    }

    //    _context.Courses.Remove(course);
    //    _context.SaveChanges();
    //    return RedirectToAction(nameof(Index));
    //}
}
