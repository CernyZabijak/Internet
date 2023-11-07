using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Internet
{
    public partial class S : Form
    {
        private List<(int coreIndex, double coreTime)> coreResults = new List<(int coreIndex, double coreTime)>();
        private double averageScore = 0.0;
        private readonly object lockObject = new object();
        private bool isBenchmarking = false;
        private double speed;
        private double latency;
        private String provider;
        double fileSize;
        double downloadTime;
        public S()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            comboBox1.SelectedIndex = 1;
            summaryTextbox.ReadOnly = true;
            textBox2.ReadOnly = true;
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            summaryTextbox.Text = "";

            if (speedTextBox.Text == "") speed = 20;
            else speed = double.Parse(speedTextBox.Text);

            if (fileSizeTextBox.Text == "") fileSize = 2000;
            else fileSize = double.Parse(fileSizeTextBox.Text);

            if (latencyTextBox.Text == "") latency = 200;
            else latency = double.Parse(latencyTextBox.Text);

            if (providerTextBox.Text == "") provider = "Unknown";
            else provider = providerTextBox.Text;

            Internet internet = new Internet(speed, latency, provider);

            if (comboBox1.SelectedIndex == 1)
            {
                downloadTime = fileSize / (speed / 8);
            }
            else
            {
                downloadTime = (fileSize * 1000) / (speed / 8);
            }

            downloadTime = Math.Round((downloadTime / 60 / 60), 2);

            if (speed < 6)
            {
                summaryTextbox.Text = $"Wow, you've got the world's slowest internet with {provider}! It'll take {downloadTime} hours to download the file with a whopping {speed} Mbps speed and {latency} ms latency.";
            }
            if (speed > 6 && speed < 12)
            {
                summaryTextbox.Text = $"Your {provider} internet is on a coffee break. It estimates just {downloadTime} hours to download the file with a speedy {speed} Mbps connection and {latency} ms latency.";
            }
            if (speed > 12 && speed < 20)
            {
                summaryTextbox.Text = $"Your {provider} internet moves at a glacial pace. Expect a mere {downloadTime} hours for the download with {speed} Mbps speed and {latency} ms latency.";
            }
            if (speed > 20 && speed < 34)
            {
                summaryTextbox.Text = $"You've got the patience of a saint with {provider}! It'll only be {downloadTime} hours to get that file, thanks to a decent {speed} Mbps speed and {latency} ms latency.";
            }
            if (speed > 34 && speed < 50)
            {
                summaryTextbox.Text = $"Your {provider} internet is making progress. It's forecasting {downloadTime} hours for the download with {speed} Mbps speed and {latency} ms latency.";
            }
            if (speed > 50 && speed < 75)
            {
                summaryTextbox.Text = $"Not too shabby with {provider}! It'll take just {downloadTime} hour to snatch the file, thanks to a respectable {speed} Mbps speed and {latency} ms latency.";
            }
            if (speed > 75 && speed < 125)
            {
                summaryTextbox.Text = $"Your {provider} internet is above average. It'll be done in {downloadTime * 60} minutes with {speed} Mbps speed and {latency} ms latency.";
            }
            if (speed > 125 && speed < 250)
            {
                summaryTextbox.Text = $"Decent speed with {provider}! It estimates a quick {downloadTime * 60} minutes for the download with {speed} Mbps speed and {latency} ms latency.";
            }
            if (speed > 250 && speed < 500)
            {
                summaryTextbox.Text = $"Impressive with {provider}! Your internet will get the file in {downloadTime * 60} minutes flat with a speedy {speed} Mbps connection and {latency} ms latency.";
            }
            if (speed > 500)
            {
                summaryTextbox.Text = $"You've got the Usain Bolt of internet connections with {provider}. It'll be lightning-fast, just {downloadTime * 60} minutes to go with an incredible {speed} Mbps speed and {latency} ms latency.";
            }

        }


        private async void StartBenchmarkButton_Click(object sender, EventArgs e)
        {
            coreResults.Clear();
            averageScore = 0.0;

            if (isBenchmarking)
            {
                MessageBox.Show("Benchmark is already running.");
                return;
            }

            isBenchmarking = true;
            StartBenchmarkButton.Enabled = false;
            int numCores = Environment.ProcessorCount;
            textBox2.Text = "";
            resultTextbox.Items.Clear();

            await Task.Run(() =>
            {
                int NumIterations = 13000;

                Parallel.For(0, numCores, coreIndex =>
                {
                    var sw = new Stopwatch();
                    sw.Start();

                    for (int i = 0; i < NumIterations; i++)
                    {
                        EngageCore(coreIndex, NumIterations);
                    }

                    sw.Stop();
                    double coreTime = sw.Elapsed.TotalMilliseconds / NumIterations;

                    lock (lockObject)
                    {
                        averageScore += coreTime;
                    }
                    coreResults.Add((coreIndex, coreTime * 1000));
                });
            });

            coreResults = coreResults.OrderBy(result => result.coreIndex).ToList();

            StartBenchmarkButton.Enabled = true;
            isBenchmarking = false;

            foreach (var result in coreResults)
            {
                resultTextbox.Items.Add($"Core {result.coreIndex}: {(int)result.coreTime} Microseconds per iteration");
            }

            double average = averageScore / numCores;
            textBox2.Text = (((int)(average * 1000))).ToString();
        }

        private void EngageCore(int coreIndex, int NumIterations)
        {
            Random random = new Random();

            for (int i = 0; i < NumIterations; i++)
            {
                int n = random.Next(1, 10);
                long result = CalculateFactorial(n);
            }
        }

        private long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

    }
}