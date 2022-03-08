using AppointmentSchedulingDotNet5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSchedulingDotNet5.Controllers
{
    public class AccoutController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccoutController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
