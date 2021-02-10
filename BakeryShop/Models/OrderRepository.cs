using System;

namespace BakeryShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BakeryDbContext _bakeryDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(BakeryDbContext bakeryDbContext, ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
            _bakeryDbContext = bakeryDbContext;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _bakeryDbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    BreadId = shoppingCartItem.Bread.BreadId,
                    OrderId = order.Orderid,
                    Price = shoppingCartItem.Bread.Price
                };

                _bakeryDbContext.OrderDetails.Add(orderDetail);
            }

            _bakeryDbContext.SaveChanges();

        }
    }
}
