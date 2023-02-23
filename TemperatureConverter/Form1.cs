namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Get the value that the user entered in the Celsius Text Box
            double celsiusValue = Double.Parse(celsiusTextBox.Text);

            // Apply the calculation
            double result = (celsiusValue * 9 / 5) + 32;

            // Store the result in the Fahrenheit Textbox
            fahrenheitTextBox.Text = string.Format("{0:0.000}", result);
        }

        private void celsiusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '-':
                    if (celsiusTextBox.SelectionStart == 0)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;

                case (char)8:
                    e.Handled = false;
                    break;

                case '.':
                    int theDotCount = celsiusTextBox.Text
                    .Count(x => x == '.');

                    if (theDotCount >= 1)
                    {
                        e.Handled = true;
                    }
                    break;

                case char c when c >= '0' && c <= '9':
                    e.Handled = false;
                    break;

                default:
                    e.Handled = true;
                    break;
            }


            //if (e.KeyChar < 48 || e.KeyChar > '9')
            //{
            //    e.Handled = true;
            //}
        }
    }
}