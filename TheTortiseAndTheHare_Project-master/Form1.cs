using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTortiseAndTheHare_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            T1 = new Tortoise();
            C1 = new Contender();
            H1 = new Hare();
        }
        Contender C1;
        Tortoise T1;
        Hare H1;


        public class Contender
        {
            protected int position;
            protected int steps;
            public Color col;

            public Contender()
            {
                position = 0;
                steps = 70;
                col = Color.Black;
            }

            public Contender (int iPos, int iStep, Color clr)
            {
                position = iPos;
                steps = iStep;
                col = clr;
            }

            public Contender (Contender other)
            {
                this.position = other.position;
                this.steps = other.steps;
                this.col = other.col;
            }

            public int getPosition()
            {
                return position;
            }

            public int getSteps()
            {
                return steps;
            }

            public void setposition(int iPosition)
            {
                if (iPosition < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    position = iPosition;
                }
            }

            public void setsteps(int iSteps)
            {
                if (iSteps > position)               
                    throw new ArgumentOutOfRangeException();                
                else                
                    steps = iSteps;                
            }

            public bool isWinner()
            {
                if (position >= steps)                
                    return true;                
                else
                    return false;
            }

            public void setPositionToZero()
            {
                position = 0;
            }
        }

        public class Tortoise : Contender
        {
            Random rndGenT;

            public Tortoise():base() 
            {
                rndGenT = new Random();
                col = Color.Green;


            }
            public Tortoise(int iPos, int iStep, Color clr, Random rnd)
                              :base(iPos, iStep, clr)
            {
                rndGenT = new Random();
            }

            public Tortoise(Tortoise other)
                              : base(other)
            {
                rndGenT = new Random();
            }

            public void  UpdatePosition()
            {
                int chance = rndGenT.Next(1000);

                if (chance < 500)
                    position = position + 3;
                else if (chance < 700)
                    position = position - 6;
                else if (chance < 1000)
                    position++;

                if (position < 0)
                    position = 0;
               
            }

            public void Draw(Graphics g)
            {                
                Brush myBrush = new SolidBrush(col);
                g.FillEllipse(myBrush, position * 15 + 75, 65, 25, 25);                
            }            
        }

        public class Hare : Contender
        {
            Random rndGenH;

            public Hare() : base()
            {
                rndGenH = new Random();
                col = Color.Blue;
            }
            public Hare(int iPos, int iStep, Color clr, Random rnd) : base(iPos, iStep, clr)

            {
                rndGenH = new Random();
            }

            public Hare(Hare other)
                              : base(other)
            {
                rndGenH = new Random();
            }

            public void UpdatePosition()
            {
                int chance = rndGenH.Next(1000);

                if (chance < 200)
                    position = position + 0;
                else if (chance < 400)
                    position = position + 6;
                else if (chance < 500)
                    position = position - 7;
                else if (chance < 700)
                    position = position + 3;
                else if (chance < 1000)
                    position = position - 2;

                if (position < 0)
                    position = 0;
                if (position > 70)
                    position = 70;
            }

            public void Draw(Graphics g)
            {
                Pen mypen = new Pen(col);
                Brush myBrush = new SolidBrush(col);
                g.FillRectangle(myBrush, position * 15 + 75, 195, 25, 25);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrRaceSpeed.Start();
        }

        private void tmrRaceSpeed_Tick(object sender, EventArgs e)
        {
            T1.UpdatePosition();
            bool Twinner = T1.isWinner();
            if (Twinner == true)
            {               
                tmrRaceSpeed.Stop();
                MessageBox.Show("TORTOISE WINS!!! YAYYY!!!");
            }

            H1.UpdatePosition();
            bool Hwinner = H1.isWinner();
            if (Hwinner == true)
            {
                tmrRaceSpeed.Stop();
                MessageBox.Show("something");
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            T1.Draw(e.Graphics);
            H1.Draw(e.Graphics);
            Graphics g = e.Graphics;
            Pen linePen = new Pen(Color.Black, 10);
            Pen racePen = new Pen(Color.Black, 2);
            g.DrawLine(racePen, 75, 78, 1135, 78);
            g.DrawLine(racePen, 75, 208, 1135, 208);
            g.DrawLine(linePen, 1130, 78, 1130, 208);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrRaceSpeed.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {            
            T1.setPositionToZero();
            H1.setPositionToZero();
            pictureBox1.Invalidate();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            cdChangeColor.ShowDialog();            
            H1.col = cdChangeColor.Color;
            pictureBox1 .Invalidate();
        }

        private void btnChangeTColor_Click(object sender, EventArgs e)
        {
            cdChangeColor.ShowDialog();
            T1.col = cdChangeColor.Color;
            pictureBox1.Invalidate();
        }

        private void rbSlow_CheckedChanged(object sender, EventArgs e)
        {
            tmrRaceSpeed.Interval = 1000;
        }

        private void rbFast_CheckedChanged(object sender, EventArgs e)
        {
            tmrRaceSpeed.Interval = 10;
        }
    }
}
