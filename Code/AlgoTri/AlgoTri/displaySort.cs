using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoTri
{
    public class displaySort
    {
        int _squareSizeX;
        int _squareSizeY;
        int _posX;
        int _posY;

        public displaySort(int posX, int posY, int squareSizeX, int squareSizeY)
        {
            _squareSizeX = squareSizeX;
            _squareSizeY = squareSizeY;
            _posX = posX;
            _posY = posY;
        }

        public void DrawRectangle(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            g.FillRectangle(brush, _posX, _posY, _squareSizeX, _squareSizeY);
        }
    }
}
