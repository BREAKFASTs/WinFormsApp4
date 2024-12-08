namespace WinFormsApp4
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnStartOrder_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Order order = new Order();
            order.Show();

        }
    }
}
