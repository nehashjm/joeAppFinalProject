using joemvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace joemvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PizzaSelection()
        {
            var pizzas = new List<Pizza>
            {
                new Pizza { Id = 1, Name = "Margarita", Price = 1000 },
                new Pizza { Id = 2, Name = "Pepperoni", Price = 1200 },
                new Pizza { Id = 3, Name = "VegLoaded", Price = 2500},
                new Pizza { Id = 4, Name = "Cheese and Corn", Price = 2300},
                new Pizza { Id = 5, Name = "Farmhouse", Price = 1300}
            };
            return View(pizzas);
        }

        [HttpPost]
        public IActionResult OrderCheckoout(int pizzaId, int quantity)
        {
            var selectedPizza = GetPizzaById(pizzaId);

            if (selectedPizza == null)
            {
                // Handle invalid pizza selection
                return RedirectToAction("PizzaSelection");
            }

            var orderView = new OrderView
            {
                SelectedPizza = selectedPizza,
                Quantity = quantity
            };
            return View(orderView);
        }
        [HttpPost]
        public IActionResult OrderConfirmation(OrderView orderView)
        {
            var orderId = new Random().Next(1000, 9999);
            var selectedPizza = GetPizzaById(orderView.SelectedPizza.Id);

            var viewModel = new OrderConfirmationView
            {
                OrderView = new OrderView
                {
                    SelectedPizza = selectedPizza,
                    Quantity = orderView.Quantity
                },
                OrderId = orderId
            };

            return View(viewModel);
        }


        public Pizza GetPizzaById(int pizzaId)
        {
            var pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Margarita", Price = 1000 },
            new Pizza { Id = 2, Name = "Pepperoni", Price = 1000 },
            new Pizza { Id = 3, Name = "VegLoaded", Price = 2500},
            new Pizza { Id = 4, Name = "Cheese and Corn", Price = 2300},
            new Pizza { Id = 5, Name = "Farmhouse", Price = 1300}
        };
            return pizzas.FirstOrDefault(p => p.Id == pizzaId);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}