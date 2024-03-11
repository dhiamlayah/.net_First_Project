using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP3.Models.Cinema;

namespace TP3.Controllers
{
     public class ProducersController : Controller
    {
        CinemaDbContext _context;
        public ProducersController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: ProducersController
        public ActionResult Index()
        {
            return View(_context.Producers.ToList());
        }

        // GET: ProducersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProducersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProducersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProducersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Producer producer)
        {
            if(id != producer.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Producers.Update(producer);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(producer);
                }

            }
            return View(producer);
        }

        // GET: ProducersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProducersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
