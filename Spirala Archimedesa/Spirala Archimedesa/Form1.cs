using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Spirala_Archimedesa
{
    public partial class Okno : Form
    {   Bitmap Pole_do_rysowania;
        Graphics g;
        List<PointF> coord;
        PointF coord_zero;
        private int degree = 0;
        private int counter = 0;
        Pen red = new Pen(Brushes.Red,2);

        public Okno()
        {
            InitializeComponent();
            Pole_do_rysowania = new Bitmap(PicBox.Size.Width, PicBox.Size.Height);
            PicBox.Image = Pole_do_rysowania;
        }

        private void Okno_Load(object sender, EventArgs e)
        {

        }

        PointF archimedeanPoint(int degrees)
        {
            double a = 1;
            double b = double.Parse(SpaceBetweenArms.Text);
            double t = degrees * Math.PI / 180;
            double r = a + b * t;
            return new PointF { X = (float)(Pole_do_rysowania.Width / 2 + r * Math.Cos(t)), Y = (float)(Pole_do_rysowania.Height / 2 + r * Math.Sin(t)) };
        }

        private void Draw_guzik_Click(object sender, EventArgs e)
        {
            if (SpaceBetweenArms.Text != "")
            {
                coord = new List<PointF>();
                g = Graphics.FromImage(Pole_do_rysowania);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                PointF PicBox_center = new PointF(PicBox.Width / 2, PicBox.Height / 2);
                coord_zero = new PointF(PicBox.Width / 2, PicBox.Height / 2);
                Pen black = new Pen(Brushes.Black, 1);
                g.DrawLine(black, PicBox_center.X, 0,
                    PicBox_center.X, PicBox.Height);
                g.DrawLine(black, 0, PicBox_center.Y,
                    PicBox.Width, PicBox_center.Y);
                PicBox.Image = Pole_do_rysowania;
                timer1.Start();
                timer1.Interval = 10;
                Pause_button.Enabled = true;
                Draw_guzik.Enabled = false;
                Reset_button.Enabled = true;
            }
            else
                MessageBox.Show("Przed rozpoczęciem rysowania należy podać odległość między jej ramionami.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SpaceBetweenArms.Text == "")
            {
                timer1.Stop();
                MessageBox.Show("Uzupełnij miejsce na parametry!");
                Resume_button.Enabled = true;
                Pause_button.Enabled = false;
            }
            else
            {
                coord.Add(archimedeanPoint(degree));
                g.DrawLine(red, coord_zero, coord[counter]);
                coord_zero = coord[counter];               
                degree++;
                PicBox.Image = Pole_do_rysowania;
                if(coord[counter].X>=Pole_do_rysowania.Width|| coord[counter].X <=0 || coord[counter].Y>=Pole_do_rysowania.Height|| coord[counter].Y <=0)
                {
                    timer1.Stop();
                    Pause_button.Enabled = false;
                    MessageBox.Show("Osiągnięto maksymalny rozmiar spirali dla podanych parametrów.");
                }
                else counter++;
            }
        }
        
        private void Pause_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Pause_button.Enabled = false;
            Resume_button.Enabled = true;
        }

        private void Resume_button_Click(object sender, EventArgs e)
        {
            if (SpaceBetweenArms.Text != "")
            {
                timer1.Start();
                Pause_button.Enabled = true;
                Resume_button.Enabled = false;
            }
            else
                MessageBox.Show("Podaj parametry zanim wznowisz rysowanie.");
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            g.Clear(Color.Wheat);
            coord.Clear();
            coord_zero= new PointF(PicBox.Width / 2, PicBox.Height / 2);
            degree = 0;
            counter = 0;
            g.Dispose();
            PicBox.Image = Pole_do_rysowania;
            Draw_guzik.Enabled = true;
            Pause_button.Enabled = false;
            Resume_button.Enabled = false;
            Reset_button.Enabled = false;
        }
    }
}
