using System;
using System.Threading.Tasks;
using Core;
using InterfacesDomain;
using Microsoft.AspNetCore.Mvc;

namespace TestWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        public HomeController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_orderRepository.GetAllOrders());
        }
        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                await _orderRepository.PushOrderAsync(order);
                await _orderRepository.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }
    }
}
