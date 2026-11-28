using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_App.Context;
using MVC_App.Models;
using System.Diagnostics;

namespace MVC_App.Controllers
{
    public class PlanController : Controller
    {
        private GymDbContext context = new GymDbContext();
        public IActionResult IndexTest()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var plans =  await context.Plans.ToListAsync();
            return View(plans);
        }

    }
}
