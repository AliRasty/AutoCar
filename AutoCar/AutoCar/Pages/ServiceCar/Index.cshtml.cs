using AutoCar.Data;
using AutoCar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCar.Pages.ServiceCar
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _db;


        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public IList<ServiceTypeCar> services { get; set; }
        public async Task<IActionResult>  OnGet()
        {
            services = await _db.serviceTypeCars.ToListAsync();
            return Page();
        }
    }
}
