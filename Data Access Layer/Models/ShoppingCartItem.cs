namespace Data_Access_Layer.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Guitar Guitar { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
