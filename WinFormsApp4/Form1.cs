namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
