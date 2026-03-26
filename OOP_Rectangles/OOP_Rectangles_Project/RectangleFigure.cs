using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Rectangles
{
    internal class RectangleFigure
    {
        private int _width, _height;
        private int P, S;
        private bool _drawRect = false;
       
        private Rectangle _rectangle;

        public int getP
        {
            get { return P = (_width + _height) * 2; }
        }
        public int getS
        {
            get { return S = _width * _height; }
        }
        public RectangleFigure(int width, int height, int coordinateX, int coordinateY, Panel panelSquare)
        {
            _width = width;
            _height = height;
            _rectangle = new Rectangle(coordinateX, coordinateY, _width, _height);
            panelSquareDraw(width, height, coordinateX, coordinateY, panelSquare);
        }
        public void panelSquare_Paint(object sender, PaintEventArgs e)
        {
            if (_drawRect == true)
            {
                e.Graphics.Clear(Color.White);
                e.Graphics.DrawRectangle(Pens.Black, _rectangle);
            }
        }

        private void panelSquareDraw(int width, int height, int coordinateX, int coordinateY, Panel panelSquare)
        {
            _drawRect = true;
            if (coordinateX + _width < panelSquare.Width && coordinateY + _height < panelSquare.Height)
            {
                panelSquare.Invalidate();
            }
            else
            {
                MessageBox.Show("Невозможно построить фигуру, которая выходит за пределы панели");
            }
        }
    }
}
