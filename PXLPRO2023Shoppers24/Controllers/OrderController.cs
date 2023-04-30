using Microsoft.AspNetCore.Mvc;
using PXLPRO2023Shoppers24.Data.Cart;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Services;

namespace PXLPRO2023Shoppers24.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILaptopService _laptopService;
        private readonly ShoppingCart _shoppingCart; 
        public OrderController(ILaptopService laptopService, ShoppingCart shoppingCart)
        {
            _laptopService = laptopService;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _laptopService.GetByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));

        }
        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _laptopService.GetByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
    }
}
