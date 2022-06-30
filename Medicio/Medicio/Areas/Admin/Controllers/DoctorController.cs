using Medicio.DAL;
using Medicio.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Medicio.Areas.Admin.Controllers
{
    public class DoctorController : Controller
    {
        public readonly IWebHostEnvironment _env;
        public readonly AppDbContext _context;

        public DoctorController(IWebHostEnvironment env, AppDbContext context)
        {
            _env = env;
            _context = context;
        }
         
        // GET: DoctorController
        public ActionResult Index()
        {
            List<Doctors> doctorList = _context.Doctor.ToList();
            return View(doctorList);
        }

        // GET: DoctorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoctorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorController/Create
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

        // GET: DoctorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: DoctorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorController/Delete/5
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
