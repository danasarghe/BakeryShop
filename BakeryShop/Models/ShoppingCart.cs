using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BakeryShop.Models
{
    public class ShoppingCart
    {
        private readonly BakeryDbContext _bakeryDbContext;

        public ShoppingCart(BakeryDbContext bakeryDbContext)
        {
            _bakeryDbContext = bakeryDbContext;
        }

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<BakeryDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Bread bread, int amount)
        {
            var shoppingCartItem = _bakeryDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Bread.BreadId == bread.BreadId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Bread = bread,
                    Amount = amount
                };
                _bakeryDbContext.ShoppingCartItems.Add(shoppingCartItem);
                _bakeryDbContext.SaveChanges();
            }
        }

        public int RemoveFromCart(Bread bread)
        {
            var shoppingCartItem = _bakeryDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Bread.BreadId == bread.BreadId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _bakeryDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _bakeryDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (
                ShoppingCartItems = _bakeryDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(b => b.Bread).ToList());
        }

        public void ClearCart()
        {
            var cartItem = _bakeryDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);
            _bakeryDbContext.ShoppingCartItems.RemoveRange(cartItem);
            _bakeryDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _bakeryDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(b => b.Bread.Price * b.Amount).Sum();

            return total;
        }
    }
}
