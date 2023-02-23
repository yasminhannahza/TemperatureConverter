namespace TemperatureConverter
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
            calculateButton = new Button();
            celsiusTextBox = new TextBox();
            fahrenheitTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            fahrenheitLabel = new Label();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(272, 163);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 29);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // celsiusTextBox
            // 
            celsiusTextBox.Location = new Point(228, 108);
            celsiusTextBox.Name = "celsiusTextBox";
            celsiusTextBox.Size = new Size(186, 27);
            celsiusTextBox.TabIndex = 1;
            celsiusTextBox.KeyPress += celsiusTextBox_KeyPress;
            // 
            // fahrenheitTextBox
            // 
            fahrenheitTextBox.Location = new Point(228, 225);
            fahrenheitTextBox.Name = "fahrenheitTextBox";
            fahrenheitTextBox.ReadOnly = true;
            fahrenheitTextBox.Size = new Size(186, 27);
            fahrenheitTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(161, 34);
            label1.Name = "label1";
            label1.Size = new Size(382, 50);
            label1.TabIndex = 3;
            label1.Text = "Celsius to Fahrenheit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 111);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Celsius";
            // 
            // fahrenheitLabel
            // 
            fahrenheitLabel.AutoSize = true;
            fahrenheitLabel.Location = new Point(137, 228);
            fahrenheitLabel.Name = "fahrenheitLabel";
            fahrenheitLabel.Size = new Size(77, 20);
            fahrenheitLabel.TabIndex = 5;
            fahrenheitLabel.Text = "Fahrenheit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fahrenheitLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fahrenheitTextBox);
            Controls.Add(celsiusTextBox);
            Controls.Add(calculateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private TextBox celsiusTextBox;
        private TextBox fahrenheitTextBox;
        private Label label1;
        private Label label2;
        private Label fahrenheitLabel;
    }
}