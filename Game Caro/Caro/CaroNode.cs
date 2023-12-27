using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCaro
{
    class CaroNode
    {
        static private Graphics _g;     
        static private SolidBrush _bg;  
        static private SolidBrush NewNode= new SolidBrush(Color.Yellow);    
        public static SolidBrush Bg
        {
            set { CaroNode._bg = value; }
        }
        public static Graphics G
        {
            set { CaroNode._g = value; }
        }
        static private Image X = Properties.Resources.x, O=Properties.Resources.o;
        

        private int _Line;                       
        public int Line                                   
        {
            get { return _Line; }
            set { _Line = value; }
        }
        private int _Column;                     
        public int Column                                  
        {
            get { return _Column; }
            set { _Column = value; }
        }
        private const int _Width = 23;           
        public static int Width
        {
            get { return _Width; }
        }
        private const int _Height = 23;          
        public static int Height
        {
            get { return _Height; }
        } 
        private Point _Pos;                             
        public Point Pos
        {
            get { return _Pos; }
            set { _Pos = value; }
        }
        private int _NStatus;                           

        public int NStatus
        {
            get { return _NStatus; }
            set { _NStatus = value; }
        }
        public void Draw()      
        {
            if (_NStatus == 1)
            {
                _g.DrawImage(O, Pos);
            }
            else if (_NStatus == -1)
            {
                _g.DrawImage(X, Pos);
            }
            else return;
        }
        public void Del()   
        {
            _g.FillRectangle(_bg, Pos.X +1,Pos.Y +1, Width - 1,Height - 1);
        }
        public void PaintNewNode()      
        {
            _g.FillRectangle(NewNode, Pos.X + 1, Pos.Y + 1, Width - 1, Height - 1);
        }
        public CaroNode() { }
        public CaroNode(int Line,int Column,Point Pos, int Status)      //constructor
        {
            _Column = Column;
            _Line = Line;
            _Pos = Pos;
            _NStatus = Status;
        }
    }
}
