using Microsoft.AspNetCore.Mvc;
using Online_School.Entities;
using School.DataAccess.Data;

namespace Online_School.Controllers
{
    public class TeacherController : Controller
    {
		private readonly AppDbContext _context;
		public TeacherController(AppDbContext context)
		{
			_context = context;
		}
		
		public IActionResult Index()
		{
			var courses = _context.Teachers.ToList();
			return View(courses);
		}

		
		public IActionResult Details()
		{
			return View();
		}
		[HttpGet]
		public IActionResult Details(int id)
		{
			//var courses = _context.Teachers.ToList();
			//return View(courses);
			var teacher = _context.Teachers.FirstOrDefault(); 
			return View(teacher);
		}

		
		public IActionResult Create()
		{
			return View();
		}

		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Teacher course)
		{
			if (ModelState.IsValid)
			{
				_context.Teachers.Add(course);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			return View(course);
		}

		
		public IActionResult Edit(int id)
		{
			var course = _context.Teachers.Find(id);
			if (course == null)
			{
				return NotFound();
			}
			return View(course);
		}

		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, Teacher course)
		{
			if (id != course.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				_context.Update(course);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			return View(course);
		}

		
		public IActionResult Delete(int id)
		{
			var course = _context.Teachers.Find(id);
			if (course == null)
			{
				return NotFound();
			}

			return View(course);
		}

		
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(int id)
		{
			var course = _context.Teachers.Find(id);
			if (course == null)
			{
				return NotFound();
			}

			_context.Teachers.Remove(course);
			_context.SaveChanges();
			return RedirectToAction(nameof(Index));
		}
	}
}

