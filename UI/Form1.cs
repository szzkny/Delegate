using Library;

namespace UI
{
    public partial class form_delegate : Form
    {
        Cart cart = new Cart();

        public form_delegate()
        {
            InitializeComponent();
            LoadDemoData();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The final price with discount is:" + cart.CalculatePrice(Discount,
                (price) => { MessageBox.Show("The total price without discount is: " + price); }
                ));
        }

        private void LoadDemoData()
        {
            cart.ShoppingList.Add(new Game { Name = "Far Car 6", Price = 59.99M });
            cart.ShoppingList.Add(new Game { Name = "GTA V.", Price = 20.49M });
            cart.ShoppingList.Add(new Game { Name = "God Of War", Price = 49.99M });
        }

        private decimal Discount(decimal totalPrice)
        {
            if (totalPrice >= 100.00M)
            {
                return totalPrice * 0.8M;
            }
            else
            {
                return totalPrice;
            }
        }
    }
}