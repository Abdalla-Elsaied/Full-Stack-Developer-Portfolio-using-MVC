using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EX_1.Data;
using MVC_EX_1.Models;
using Portfolio.Models;
using System.IO;

namespace MVC_EX_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var dev = _context.Dev.ToList();
            return View(dev);
        }

        public IActionResult About()
        {
            var dev = _context.Dev.ToList();
            return View(dev);
        }

        public IActionResult Skills()
        {
            var dev = _context.Dev.Where(d => d.Id == 1).ToList();
            return View(dev);
        }

        public IActionResult Projects()
        {
            var dev = _context.Dev.Include(d => d.DevProjects).ToList();
            return View(dev);
        }

        public IActionResult ContactMe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactMe(Client c1)
        {
            _context.Client.Add(c1);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // New action method for downloading the resume
        public IActionResult DownloadResume()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", "resume.pdf");
            var mimeType = "application/pdf"; // MIME type for PDF files
            var fileName = "resume.pdf"; // The name of the file to be downloaded
            return PhysicalFile(filePath, mimeType, fileName);
        }
    }
}
