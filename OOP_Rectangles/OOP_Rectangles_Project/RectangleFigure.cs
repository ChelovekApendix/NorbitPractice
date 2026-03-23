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

        public int getP
        {
            get { return P; }
        }
        public int getS
        {
            get { return S; }
        }
        public RectangleFigure(int width, int height)
        {
            _width = width;
            _height = height;

            CalculatePandS();
        }
        private void CalculatePandS()
        {
            P = (_width + _height) * 2;
            S = _width * _height;
        }
    }
}
