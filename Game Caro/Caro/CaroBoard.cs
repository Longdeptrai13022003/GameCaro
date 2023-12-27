using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCaro
{
    class CaroBoard
    {
        private static Graphics _g;     

        public static Graphics G
        {
            set { _g = value; }
        }
        public CaroBoard()
        {
        }

        private const int _LineAmount = 20;                

        public int LineAmount
        {
            get { return _LineAmount; }
        }

        private const int _ColumnAmount = 20;              

        public int ColumnAmount
        {
            get { return _ColumnAmount; }
        }
        public void Draw()           
        {
            Pen pen;
            pen=new Pen(Color.White);                
            for(int i = 0;i <= _LineAmount; i++)        
            {
                _g.DrawLine(pen, i * CaroNode.Width, 0, i * CaroNode.Width, _LineAmount * CaroNode.Height);
            }
            for (int j = 0; j <= _ColumnAmount; j++)                
            {
                _g.DrawLine(pen, 0, j * CaroNode.Height, _ColumnAmount * CaroNode.Width, j * CaroNode.Height);
            }
        }
    }
}