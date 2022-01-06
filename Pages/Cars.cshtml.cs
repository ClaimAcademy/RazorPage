using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWorldWebapp.Models;
using HelloWorldWebapp.Services;

namespace HelloWorldWebapp.Pages
{
    public class CarsModel : PageModel
    {
        public List<Car> cars = new();
        public void OnGet()
        {
            cars = CarService.GetAll();
        }

        public IActionResult OnPost()
        {
            CarService.Add(NewCar);
            return RedirectToAction("Get");
        }

        [BindProperty]
        public Car Name { get; set; }
        [BindProperty]
        public Car Color { get; set; }

        [BindProperty]
        public Car NewCar { get; set; } = new();
    }
}
