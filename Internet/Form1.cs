namespace Internet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double speed;
        private double latency;
        private String provider;
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (speedTextBox.Text == null) speed = 0;
            else
                speed = double.Parse(speedTextBox.Text);
            if (latencyTextBox.Text == null) latency = 0;
            else speed = double.Parse(latencyTextBox.Text);
            if (providerTextBox.Text == null) provider = "Unknown";
            else provider = providerTextBox.Text;
            int iterations = 10000000;  // Adjust this value to control CPU load

            for (int i = 0; i < iterations; i++)
            {
                double result = Math.Pow(2, i);
            }
            Internet internet = new Internet(speed, latency, provider);

        }
    }
}