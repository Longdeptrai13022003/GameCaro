using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCaro
{
    public partial class FVCaro : Form
    {
        private Stopwatch s;        
        private Game _VCaro;        
        private Graphics g; 
        public FVCaro()
        {
            InitializeComponent();
            _VCaro = new Game();    
            g=Game.G=CaroNode.G = CaroBoard.G = PNCaroBoard.CreateGraphics();       
            
            PBCPU.Image = Properties.Resources._1;     
            PBCPU.SizeMode = PictureBoxSizeMode.StretchImage;
            PBHM.Image = Properties.Resources._2;        
            PBHM.SizeMode = PictureBoxSizeMode.StretchImage;
            Game.SbBG=CaroNode.Bg = new SolidBrush(BackColor);  
            s = new Stopwatch();      //Bắt đầu tính tzan  
        }
        private void BTNew_Click(object sender, EventArgs e)    
        {
            g.Clear(PNCaroBoard.BackColor);     
            _VCaro.NewGame();      
            if (_VCaro.Player == -1)        //random lượt chơi
            {
                MessageBox.Show("CPU đánh trước");
                _VCaro.ComputerMove(-1, difficulty());
            }
            else
            {
                MessageBox.Show("Bạn đánh trước");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {  
            RBEasy.Checked = true;          
            _VCaro.DrawCaroBoard();     
            if (_VCaro.Player == -1)
            {
                MessageBox.Show("CPU đánh trước");
                _VCaro.ComputerMove(-1, 1);
            }
            else
            {
                MessageBox.Show("Bạn đánh trước");
            }
            s = new Stopwatch();
            s.Start();
        }

        private void PNCaroBoard_Paint(object sender, PaintEventArgs e) 
        {
            _VCaro.DrawCaroBoard(); 
            _VCaro.reDrawMoves();   
        }

        private void PNCaroBoard_MouseClick(object sender, MouseEventArgs e)        
        {
            if (_VCaro.WinCheck(false)==true) return;  
            bool a;
            a= _VCaro.Move(e.X, e.Y);       
            if (_VCaro.WinCheck(true))      
            {
                _VCaro.GameOver();
                return;
            }
            if (a)  
            {
                LBCPUTime.Text = "Find move..";
                s.Reset();  
                s.Start(); 
                _VCaro.ComputerMove(-1, difficulty());  
                s.Stop();
                LBCPUTime.Text=(s.ElapsedMilliseconds/1000).ToString(); 
                s.Reset();  
                s.Start();      
            }
            if (_VCaro.WinCheck(true))  
            {
                _VCaro.GameOver();
                
                s.Reset();
                s.Stop();
                //return;
            }
        }

        private void BTUndo_Click(object sender, EventArgs e)       
        {
            _VCaro.Undo();
        }

        private void BTHM_Click(object sender, EventArgs e)     
        {
            if (_VCaro.WinCheck(false)) return;  //nếu trò chơi đã kêt thúc thì thoát
            _VCaro.ComputerMove(1, difficulty());   //dánh nươc đi cho người
            if (_VCaro.WinCheck(true))  //kiểm tra chiến thắng
            {
                _VCaro.GameOver();
                return;
            }
            _VCaro.ComputerMove(-1, difficulty()); //đánh nước đi cho máy
            if (_VCaro.WinCheck(true))      //kiểm tra chiến thắng
            {
                _VCaro.GameOver();
                return;
            }
        }
        private void TMMoveTime_Tick(object sender, EventArgs e)        
        {
            if(_VCaro.Player==1)
            {
                s.Stop();
                LBHMTime.Text = (s.ElapsedMilliseconds / 1000).ToString();
                s.Start();
            }
        }
        private int difficulty()        //xác định độ khó
        {
            if (RBEasy.Checked) return 1;
            else
                if (RBNormal.Checked) return 2;
                else
                    if (RBHard.Checked) return 3;
                    else
                        return 4;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool dragging;
        private Point startPoint = new Point(0, 0);
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FVCaro_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.DarkCyan,
                Color.SpringGreen,
                140F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void BTNew_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.Aquamarine;
        }
    }
    
}
