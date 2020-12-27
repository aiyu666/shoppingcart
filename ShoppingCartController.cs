using Microsoft.AspNetCore.Mvc;
using ShoppingCart;

namespace ShoppingCart.ShoppingCartController
{
     [Route("/shoppingcart")]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartStore shoppingCartStore;
        public ShoppingCartController(
        IShoppingCartStore shoppingCartStore,
        [HttpGet("{userId:int}")]
        public ShoppingCart Get(int userId) =>
        this.shoppingCartStore.Get(userId);
        [HttpPost("{userId:int}/items")]
        public async Task<ShoppingCart> Post(
        int userId,
        [FromBody] int[] productIds)
        {
            var shoppingCart = shoppingCartStore.Get(userId);
            var shoppingCartItems =
            await this.productcatalog
                .GetShoppingCartItems(productIds);
                shoppingCart.AddItems(shoppingCartItems, eventStore);
                shoppingCartStore.Save(shoppingCart);
            return shoppingCart;
        }
    }
}

