using Microsoft.AspNetCore.Mvc;
using PXLPRO2023Shoppers24.Data.Cart;

namespace PXLPRO2023Shoppers24.Data.ViewComponents
{
    [ViewComponent(Name = "ShoppingCartSummary")]
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shopppingCart;
        public ShoppingCartSummary(ShoppingCart shopppingCart)
        {
            _shopppingCart = shopppingCart;
        }
        public IViewComponentResult Invoke()
        {
            var items = _shopppingCart.GetShoppingCartItems();
            return View(items.Count);
        }
    }
}
