namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           MessageBox.Show("Welcome to the Test1 application!");    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            listBox1.Items.Add(input);
            textBox1.Clear();

            try
            {
                if (textBox1.Text == "")
                {
                    throw new ArgumentNullException("Type what you want to be listed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return;
            }
            try
            {
                int number = int.Parse(input);
                MessageBox.Show($"You entered the number: {number}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid integer.");
                return;
            }

        }
    }
}
