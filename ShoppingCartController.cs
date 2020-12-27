using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart
{
    [Route("/[Action]")]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartStore _shoppingCartStore;

        public ShoppingCartController(IShoppingCartStore shoppingCartStore)
        {
            this._shoppingCartStore = shoppingCartStore;
        }

        public ShoppingCartStoreModel Get()
        {
            return _shoppingCartStore.Get();
        }
        
        //
        // public ShoppingCartController(
        //     IShoppingCartStore shoppingCartStore,
        //     
        //
        // [HttpGet("{userId:int}")]
        // public ShoppingCart Get(int userId) =>
        //     this.shoppingCartStore.Get(userId);
        //
        // [HttpPost("{userId:int}/items")]
        // public async Task<ShoppingCart> Post(
        //     int userId,
        //     [FromBody] int[] productIds)
        // {
        //     var shoppingCart = shoppingCartStore.Get(userId);
        //     var shoppingCartItems =
        //         await this.productcatalog
        //             .GetShoppingCartItems(productIds);
        //     shoppingCart.AddItems(shoppingCartItems, eventStore);
        //     shoppingCartStore.Save(shoppingCart);
        //     return shoppingCart;
        // }
    }
}