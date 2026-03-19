using System.Text;

namespace DataType_Task2
{
    public partial class Form1 : Form
    {
        int _diagonal;
        StringBuilder _rhombusString = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            _rhombusString.Clear();
            _diagonal = Convert.ToInt32(textBoxDiagonal.Text);
            if (_diagonal % 2 == 0)
            {
                MessageBox.Show("Число должно быть нечётным");
            }

            else
            {
                richTextBoxRhombus.Text = RhombusDraw(_diagonal).ToString();
            }
        }

        private StringBuilder RhombusDraw(int diagonal)
        {
            char[] rhombus = new char[diagonal];
            int leftSide = rhombus.Length / 2;
            int rightSide = leftSide;
            for (int j = 0; j < rhombus.Length; j++)
            {
                for (int i = 0; i < rhombus.Length; i++)
                {
                    if (leftSide == rightSide)
                    {
                        if (i != leftSide)
                        {
                            rhombus[i] = ' ';
                        }
                        else
                        {
                            rhombus[i] = 'X';
                        }
                    }
                    else
                    {
                        if (i != leftSide && i != rightSide)
                        {
                            rhombus[i] = ' ';
                        }
                        else
                        {
                            rhombus[i] = 'X';
                        }
                    }
                }
                foreach (char elem in rhombus)
                { _rhombusString.Append(elem); }
                _rhombusString.Append("\n");

                if (j < diagonal/2)
                { leftSide--; }
                else
                { leftSide++; }

                if (j < diagonal / 2)
                { rightSide++; }
                else
                { rightSide--; }
            }

            return _rhombusString;
        }

        private void textBoxDiagonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxDiagonal_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDiagonal.Text == "")
            { buttonResult.Enabled = false; }
            else
            { buttonResult.Enabled = true; }
            
        }
    }
}
