namespace Library
{
    public class Cart
    {
        //public delegate decimal DiscountPrice(decimal totalPrice);
        //public delegate void TotalPrice(decimal price);

        public List<Game> ShoppingList { get; set; } = new List<Game>();

        // The method header below uses the delegates defined above
        //public decimal CalculatePrice(DiscountPrice discountPrice, TotalPrice totalPrice)
        public decimal CalculatePrice(Func<decimal,decimal> discountPrice, 
            Action<decimal> totalPrice)
        {
            decimal price = ShoppingList.Sum(game => game.Price);

            totalPrice(price);

            return discountPrice(price);
        }
    }
}