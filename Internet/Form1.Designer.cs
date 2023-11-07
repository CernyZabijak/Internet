namespace Internet
{
    partial class S
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S));
            speedTextBox = new TextBox();
            latencyTextBox = new TextBox();
            providerTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            fileSizeTextBox = new TextBox();
            CalculateButton = new Button();
            summaryTextbox = new TextBox();
            StartBenchmarkButton = new Button();
            resultTextbox = new ListBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // speedTextBox
            // 
            speedTextBox.Location = new Point(14, 43);
            speedTextBox.Margin = new Padding(3, 4, 3, 4);
            speedTextBox.Name = "speedTextBox";
            speedTextBox.Size = new Size(114, 27);
            speedTextBox.TabIndex = 0;
            // 
            // latencyTextBox
            // 
            latencyTextBox.Location = new Point(135, 43);
            latencyTextBox.Margin = new Padding(3, 4, 3, 4);
            latencyTextBox.Name = "latencyTextBox";
            latencyTextBox.Size = new Size(114, 27);
            latencyTextBox.TabIndex = 1;
            // 
            // providerTextBox
            // 
            providerTextBox.Location = new Point(256, 43);
            providerTextBox.Margin = new Padding(3, 4, 3, 4);
            providerTextBox.Name = "providerTextBox";
            providerTextBox.Size = new Size(114, 27);
            providerTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 3;
            label1.Text = "Speed Mbps";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 12);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Latency ms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 12);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Provider";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 84);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 6;
            label4.Text = "File Size";
            // 
            // fileSizeTextBox
            // 
            fileSizeTextBox.Location = new Point(14, 111);
            fileSizeTextBox.Margin = new Padding(3, 4, 3, 4);
            fileSizeTextBox.Name = "fileSizeTextBox";
            fileSizeTextBox.Size = new Size(114, 27);
            fileSizeTextBox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(14, 143);
            CalculateButton.Margin = new Padding(3, 4, 3, 4);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(114, 69);
            CalculateButton.TabIndex = 8;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // summaryTextbox
            // 
            summaryTextbox.Location = new Point(134, 100);
            summaryTextbox.Margin = new Padding(3, 4, 3, 4);
            summaryTextbox.Multiline = true;
            summaryTextbox.Name = "summaryTextbox";
            summaryTextbox.Size = new Size(235, 148);
            summaryTextbox.TabIndex = 9;
            // 
            // StartBenchmarkButton
            // 
            StartBenchmarkButton.Location = new Point(14, 255);
            StartBenchmarkButton.Name = "StartBenchmarkButton";
            StartBenchmarkButton.Size = new Size(235, 67);
            StartBenchmarkButton.TabIndex = 11;
            StartBenchmarkButton.Text = "Start Factorial Benchmark";
            StartBenchmarkButton.UseVisualStyleBackColor = true;
            StartBenchmarkButton.Click += StartBenchmarkButton_Click;
            // 
            // resultTextbox
            // 
            resultTextbox.FormattingEnabled = true;
            resultTextbox.ItemHeight = 20;
            resultTextbox.Location = new Point(14, 328);
            resultTextbox.Name = "resultTextbox";
            resultTextbox.ScrollAlwaysVisible = true;
            resultTextbox.Size = new Size(356, 324);
            resultTextbox.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(255, 295);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(255, 252);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 15;
            label5.Text = "Average score";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 272);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 16;
            label6.Text = "Lower is better";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(135, 76);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 17;
            label7.Text = "Summary";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ControlLightLight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "File Size GB", "File Size MB" });
            comboBox1.Location = new Point(14, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 28);
            comboBox1.TabIndex = 18;
            // 
            // S
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 667);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(resultTextbox);
            Controls.Add(StartBenchmarkButton);
            Controls.Add(summaryTextbox);
            Controls.Add(CalculateButton);
            Controls.Add(fileSizeTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(providerTextBox);
            Controls.Add(latencyTextBox);
            Controls.Add(speedTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "S";
            Text = "Weeeee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox speedTextBox;
        private TextBox latencyTextBox;
        private TextBox providerTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox fileSizeTextBox;
        private Button CalculateButton;
        private TextBox summaryTextbox;
        private Button StartBenchmarkButton;
        private ListBox resultTextbox;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
    }
}