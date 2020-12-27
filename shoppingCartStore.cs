namespace ShoppingCart
{
    public class ShoppingCartStore : IShoppingCartStore
    {
        public ShoppingCartStoreModel Get()
        {
            var shoppingCartStore = new ShoppingCartStoreModel()
            {
                Name = "DZ",
                Id = 123
            };
            return shoppingCartStore;
        }
    }
}