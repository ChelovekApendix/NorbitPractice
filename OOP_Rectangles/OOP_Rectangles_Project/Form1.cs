using System.Xml.Serialization;

namespace OOP_Rectangles
{
    public partial class Form1 : Form
    {
        private int _coordinateX, _coordinateY;
        private int _width, _height;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            _coordinateX = Convert.ToInt32(textBoxCoordX.Text);
            _coordinateY = Convert.ToInt32(textBoxCoordY.Text);
            _width = Convert.ToInt32(textBoxWidth.Text);
            _height = Convert.ToInt32(textBoxHeight.Text);
            RectangleFigure rectangle = new RectangleFigure(_width, _height, _coordinateX, _coordinateY, panelSquare);
            panelSquare.Paint += rectangle.panelSquare_Paint;
            labelResult.Text = $"P = {rectangle.getP}, S = {rectangle.getS}";
        }

        private void AllTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AllTextBoxes_TextChanged(object sender, EventArgs e)
        {
            buttonResult.Enabled = AreAllTextBoxesFilled();
        }
        private bool AreAllTextBoxesFilled()
        {
            TextBox[] textBoxes = new[] { textBoxCoordX, textBoxCoordY, textBoxWidth, textBoxHeight };
            return textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text));
        }
    }
}
