using Microsoft.AspNetCore.Mvc;
using First_MVC_Application.Models;

namespace First_MVC_Application.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {

/*
            DogViewModel doggo = new DogViewModel()
            {
                Name = "Tom",
                Age = 2
            };*/
            return View(dogs);
        }
      
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult RegisterDog(DogViewModel dogViewModel)
        {
            /*return View("Index");*/

            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

    }
}
