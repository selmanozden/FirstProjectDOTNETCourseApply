using Microsoft.AspNetCore.Mvc;
using courseapply.Models;
using Microsoft.EntityFrameworkCore;
namespace courseapply.Controllers
{
    public class CourseController : Controller
    {
        private readonly ContextModel _context;
        public CourseController(ContextModel context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult CourseApplyView()
        {
            return View("CourseApplyView");
        }
        [HttpPost]
        public async Task<IActionResult> CourseApplyView([FromForm] VariableModel model)
        {
            if (ModelState.IsValid)
            {

                _context.Kurs.Add(model);
                await _context.SaveChangesAsync();
                ListModel.Add(model);
                return View("FeedbackView", model);
            }
            return View("CourseApplyView", model);
        }
        public IActionResult ApplicationView()
        {
            var model = _context.Kurs.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult DeleteRecord(int id)
        {
            var record = _context.Kurs.FirstOrDefault(x => x.Id == id);
            if (record == null)
            {
                return NotFound();
            }

            _context.Kurs.Remove(record);
            _context.SaveChanges();

            return RedirectToAction("ApplicationView");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _context.Kurs.FirstOrDefault(x => x.Id == id);
           

            return View("EditView",model);
        }
        [HttpPost]
        public IActionResult Edit(VariableModel model)
        {
            

            _context.Kurs.Update(model);
            _context.SaveChanges();

            return RedirectToAction("ApplicationView");

        }

    }}


