namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double _initialDeposit;
        private int _years;
        private double _interestRate;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                _initialDeposit = Convert.ToDouble(textBoxInitialDeposit.Text);
                _years = Convert.ToInt32(textBoxYears.Text);
                _interestRate = Convert.ToDouble(textBoxInterestRate.Text);
            }
            catch (FormatException)
            { MessageBox.Show("Введите корректные числа в поля!"); }
            
            richTextBoxResult.Text = AmountOfSavings(_initialDeposit, _years, _interestRate);
        }

        private String AmountOfSavings(double initialDeposit, int years, double interestRate)
        {
            String result = "";
            for (int i = 1; i <= years; i++)
            {
                result += $"Год {i}: {Math.Round(initialDeposit += (double)(initialDeposit * (interestRate * 0.01)), 2)} \n";

            }
            return result;
        }

        private void textBoxInitialDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBoxYears_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void AllTextBoxes_TextChanged(object sender, EventArgs e)
        {
            buttonResult.Enabled = AreAllTextBoxesFilled();
        }

        private bool AreAllTextBoxesFilled()
        {
            TextBox[] textBoxes = new[] { textBoxInterestRate, textBoxInitialDeposit, textBoxYears };
            return textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text));
        }

    }
}
