namespace Internet
{
    partial class Form1
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
            speedTextBox = new TextBox();
            latencyTextBox = new TextBox();
            providerTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            fileSizeTextBox = new TextBox();
            CalculateButton = new Button();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // speedTextBox
            // 
            speedTextBox.Location = new Point(12, 32);
            speedTextBox.Name = "speedTextBox";
            speedTextBox.Size = new Size(100, 23);
            speedTextBox.TabIndex = 0;
            // 
            // latencyTextBox
            // 
            latencyTextBox.Location = new Point(118, 32);
            latencyTextBox.Name = "latencyTextBox";
            latencyTextBox.Size = new Size(100, 23);
            latencyTextBox.TabIndex = 1;
            // 
            // providerTextBox
            // 
            providerTextBox.Location = new Point(224, 32);
            providerTextBox.Name = "providerTextBox";
            providerTextBox.Size = new Size(100, 23);
            providerTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Speed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 9);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Latency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 9);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Provider";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 70);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 6;
            label4.Text = "File Size";
            // 
            // fileSizeTextBox
            // 
            fileSizeTextBox.Location = new Point(12, 88);
            fileSizeTextBox.Name = "fileSizeTextBox";
            fileSizeTextBox.Size = new Size(100, 23);
            fileSizeTextBox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(12, 117);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(75, 36);
            CalculateButton.TabIndex = 8;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 9;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(118, 117);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(206, 36);
            progressBar1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 166);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(CalculateButton);
            Controls.Add(fileSizeTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(providerTextBox);
            Controls.Add(latencyTextBox);
            Controls.Add(speedTextBox);
            Name = "Form1";
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
        private TextBox textBox1;
        private ProgressBar progressBar1;
    }
}