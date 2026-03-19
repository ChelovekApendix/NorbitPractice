namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int initialDeposit = Convert.ToInt32(textBoxInitialDeposit.Text);
            int years = Convert.ToInt32(textBoxYears.Text);
            int interestRate = Convert.ToInt32(textBoxInterestRate.Text);
            richTextBoxResult.Text = AmountOfSavings(initialDeposit, years, interestRate);
        }

        private String AmountOfSavings(int initialDeposit, int years, int interestRate)
        {
            String result = "";
            for (int i = 1; i <= years; i++)
            {
                result += $"Год {i}: {initialDeposit += (int)(initialDeposit * (interestRate * 0.01))} \n";

            }
            return result;
        }

        private void textBoxInitialDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
