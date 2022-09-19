using AutoCar.Data;
using AutoCar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoCar.Pages.ServiceCar
{
    public class CreateModel : PageModel
    {
        private ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }


       
        public ServiceTypeCar serviceTypeCar { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost(ServiceTypeCar serviceTypeCar)
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
