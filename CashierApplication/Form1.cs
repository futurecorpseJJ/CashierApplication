namespace CashierApplication
{
    public partial class Form1 : Form
    {
        private Item item;
        private DiscountedItem discountedItem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text;
            double itemPrice = Convert.ToDouble(textBox3.Text);
            int itemQuantity = Convert.ToInt32(textBox4.Text);
            double discount = Convert.ToDouble(DiscountInput.Text);

            discountedItem = new DiscountedItem(itemName, itemPrice, itemQuantity, discount);
            double totalPrice = discountedItem.GetTotalPrice();
            AmountDisplay.Text = totalPrice.ToString();
        }

        private void DiscountInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmountDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButt_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text;
            double itemPrice = Convert.ToDouble(textBox3.Text);
            int itemQuantity = Convert.ToInt32(textBox4.Text);

            item = new Item(itemName, itemPrice, itemQuantity);
            double totalPrice = item.GetTotalPrice();
            ChangeDisplay.Text = totalPrice.ToString();
        }

        private void PaymentInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitPaymentButton_Click(object sender, EventArgs e)
        {
            double paymentAmount = Convert.ToDouble(PaymentInput.Text);
            double amountDisplay = Convert.ToDouble(AmountDisplay.Text);

            double change = paymentAmount - amountDisplay;
            ChangeDisplay.Text = change.ToString();
        }

        public class Item
        {
            protected string item_name;
            protected double item_price;
            protected int item_quantity;
            protected double total_price;
            private double payment_amount;
            private double change;

            public Item(string name, double price, int quantity)
            {
                item_name = name;
                item_price = price;
                item_quantity = quantity;
            }

            public double GetTotalPrice()
            {
                total_price = item_price * item_quantity;
                return total_price;
            }

            public void SetPayment(double amount)
            {
                payment_amount = amount;
                change = total_price - payment_amount;
                
            }

            public double GetChange()
            {
                return change;
            }
        }

        public class DiscountedItem : Item
        {
            private double item_discount;
            private double discounted_price;

            public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
            {
                item_discount = discount * 0.01;
                discounted_price = item_price - (item_discount * item_price);
            }

            public new double GetTotalPrice()
            {
                total_price = discounted_price * item_quantity;
                return total_price;
            }
        }
    }
}