using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingCars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameOver.Visible = false;
        }
        int gamespeed = 5;
        private void timer1_Tick(object sender, EventArgs e) 
        {
            moveline(gamespeed);
            movepolice(gamespeed);
            gameover();
            movecoin(gamespeed);
            earncoin();
            //Konieczne włączenie Timera w bocznych ustawieniach, domyślnie jest wyłączony
            //Tutaj wszystko się dzieje w tempo dlatego wszystkie wykonywane funkcje musza być tu wywołane
        }
        void moveline(int speed)
        {
            if (line1.Top > 500){line1.Top = 0;} else { line1.Top += speed; }
            if (line2.Top > 500){line2.Top = 0;} else { line2.Top += speed; }
            if (line3.Top > 500){line3.Top = 0;} else { line3.Top += speed; }
        }
        int points;
        Random random = new Random();
        int x, y;
        void movepolice(int speed)
        {
            if (police1.Top > 500) {
                x = random.Next(0, 400);
                police1.Location = new Point(x, 0);
            } else { police1.Top += speed; }
            if (police2.Top > 500)
            {
                x = random.Next(0, 400);
                police2.Location = new Point(x, 0);
            }
            else { police2.Top += speed; }
            if (police3.Top > 500)
            {
                x = random.Next(0, 400);
                police3.Location = new Point(x, 0);
            }
            else { police3.Top += speed; }
        }
        void movecoin(int speed)
        {
            if (coin1.Top > 500)
            {
                x = random.Next(0, 400);
                coin1.Location = new Point(x, 0);
                coin1.Visible = true;
            }
            else { coin1.Top += speed; }
            if (coin2.Top > 500)
            {
                x = random.Next(0, 400);
                coin2.Location = new Point(x, 0);
                coin2.Visible = true;
            }
            else { coin2.Top += speed; }
            if (coin3.Top > 500)
            {
                x = random.Next(0, 400);
                coin3.Location = new Point(x, 0);
                coin3.Visible = true;
            }
            else { coin3.Top += speed; }
            if (coin4.Top > 500)
            {
                x = random.Next(0, 400);
                coin4.Location = new Point(x, 0);
                coin4.Visible = true;
            }
            else { coin4.Top += speed; }
            if (coin5.Top > 500)
            {
                x = random.Next(0, 400);
                coin5.Location = new Point(x, 0);
                coin5.Visible = true;
            }
            else { coin5.Top += speed; }
        }
        void gameover()
        {
            if (Gamer.Bounds.IntersectsWith(police1.Bounds)) { GameOver.Visible = true; gamespeed = 0; }
            if (Gamer.Bounds.IntersectsWith(police2.Bounds)) { GameOver.Visible = true; gamespeed = 0; }
            if (Gamer.Bounds.IntersectsWith(police3.Bounds)) { GameOver.Visible = true; gamespeed = 0; }
        }
        void earncoin()
        {
            if (Gamer.Bounds.IntersectsWith(coin1.Bounds)) { coin1.Visible = false;  points++; pointsCounter.Text = "Points: " + points; }
            if (Gamer.Bounds.IntersectsWith(coin2.Bounds)) { coin2.Visible = false;  points++; pointsCounter.Text = "Points: " + points; }
            if (Gamer.Bounds.IntersectsWith(coin3.Bounds)) { coin3.Visible = false;  points++; pointsCounter.Text = "Points: " + points; }
            if (Gamer.Bounds.IntersectsWith(coin4.Bounds)) { coin4.Visible = false;  points++; pointsCounter.Text = "Points: " + points; }
            if (Gamer.Bounds.IntersectsWith(coin5.Bounds)) { coin5.Visible = false;  points++; pointsCounter.Text = "Points: " + points; }
        }
        private void line1_Click(object sender, EventArgs e){}
        private void line2_Click(object sender, EventArgs e) {}
        private void line3_Click(object sender, EventArgs e) {}
        private void lineLeft_Click(object sender, EventArgs e) {}
        private void lineRight_Click(object sender, EventArgs e){}
        private void Gamer_Click(object sender, EventArgs e) {}
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Gamer.Left > 0) { Gamer.Left += -10; }
               
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Gamer.Right < 380) { Gamer.Left += 10;}
                
            }
        }
    }
}
