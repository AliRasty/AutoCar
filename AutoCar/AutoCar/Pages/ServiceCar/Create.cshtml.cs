using AutoCar.Data;
using AutoCar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

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



        //public async Task<IActionResult> OnPost(ServiceTypeCar service)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //   _db.serviceTypeCars.Add(service);
        //   await _db.SaveChangesAsync();
        //    return RedirectToPage("ServiceCar/Index");

        //}


        public IActionResult OnPost(ServiceTypeCar serviceTypeCar)
        {
            if (ModelState.IsValid)
            {
                _db.serviceTypeCars.Add(serviceTypeCar);
                _db.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
