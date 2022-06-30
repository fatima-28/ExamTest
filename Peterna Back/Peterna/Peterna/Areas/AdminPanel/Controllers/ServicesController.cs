using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Peterna.DAL;
using Peterna.Models;
using Peterna.ViewModels.ServicesVM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Peterna.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ServicesController : Controller
    {
        private AppDbContext _context { get;  }
        private IEnumerable<Services> services;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ServicesController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
            services = _context.Services.Where(s => !s.IsDeleted).ToList();


        }

        public IActionResult Index()
        {
            return View(services);
        }
        public async Task< IActionResult> Delete(int? Id)
        {
            if (Id==null)
            {
                return BadRequest();

            }
            Services servDb = _context.Services.Where(s => !s.IsDeleted).FirstOrDefault(s => s.Id == Id);
            if (servDb==null)
            {
                return NotFound();
            }
            servDb.IsDeleted = true;
          await  _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateServicesVM model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);
                if (model.Description.Length<=10)
                {
                    ModelState.AddModelError("Description", "Desc must be at least 10");
                    return View();

                }
                Services service = new Services
                {
                    Title = model.Title,
                    Icon = uniqueFileName,
                    Description=model.Description


                };
                _context.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View();
        }
        private string UploadedFile(CreateServicesVM model)
        {
            string uniqueFileName = null;

            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "assets","img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        public IActionResult Update(int? Id)
        {
            if (Id==null)
            {
                return BadRequest();

            }
            Services servDb = _context.Services.Where(s => !s.IsDeleted).FirstOrDefault(s => s.Id == Id);
            if (servDb==null)
            {
                return NotFound();

            }
            return View(servDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public async Task<IActionResult> Update(int? id,  ServicesVM model)
        {

            if (id == null)
            {
                return BadRequest();

            }
            Services servDb = _context.Services.Where(s => !s.IsDeleted).FirstOrDefault(s => s.Id == id);
            if (servDb == null)
            {
                return NotFound();

            }
            if (model.Description == null)
            {
                ModelState.AddModelError("Description", "At leat 10 character");
                return View();
            }
            if (model.Description.Length<10)
            {
                ModelState.AddModelError("Description", "At leat 10 character");
                return View();
            }
           
            if (model.Title==null)
            {
                ModelState.AddModelError("Title", "null");
                return View();
            }
            servDb.Title = model.Title;
            servDb.Description = model.Description;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
