﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PXLPRO2023Shoppers24.Data.Cart;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;
using PXLPRO2023Shoppers24.Services;
using System.Security.Claims;

namespace PXLPRO2023Shoppers24.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ILaptopService _laptopService;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrdersService _ordersService;
        private readonly IStockOrderRepository _stockOrder;
        public OrderController(ILaptopService laptopService, ShoppingCart shoppingCart, IOrdersService ordersService, IStockOrderRepository stockOrder)
        {
            _laptopService = laptopService;
            _shoppingCart = shoppingCart;
            _ordersService = ordersService;
            _stockOrder = stockOrder;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);

            var orders = await _ordersService.GetOrdersByUserIdAndRoleAsync(userId, userRole);
            return View(orders);
        }
        [AllowAnonymous]
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
        [AllowAnonymous]
        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _laptopService.GetByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));

        }
        [AllowAnonymous]
        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _laptopService.GetByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userEmailAddress = User.FindFirstValue(ClaimTypes.Email);
            await _ordersService.StoreOrderAsync(items, userId, userEmailAddress);
            foreach (var item in items.Select(x => x.Laptop))
            {
                await _stockOrder.UpdateLaptop(item.Id, item);
            }
            await _shoppingCart.ClearShoppingCartAsync();

            return View("OrderCompleted");
        }
    }
}
