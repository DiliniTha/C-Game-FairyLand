using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFairy
{
    public partial class Form1 : Form
    {
        int gravity =8;
        int mountSpeed = 5;
        int Score = 0;
        int hearts = 3;
        int lifefree = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void game_timeTick(object sender, EventArgs e)

        {
            fairydissappear();
            lifefree += 20;
            fairy.Top += gravity;
            mountain.Left -= mountSpeed;
            extraheart.Left -= mountSpeed;
            if(mountain.Left < -150)
            {
                mountain.Left = 50;
                Score++;
            }
            if (fairy.Bounds.IntersectsWith(mountain.Bounds) || fairy.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            if (fairy.Bounds.IntersectsWith(extraheart.Bounds))
            {
                extraHearts();
                
            }
            if (extraheart.Left < -10)
            {
                extraheart.Left = 10000;
            }
            if (hearts == 1)
            {
                life3.Visible = true;
            }
            if (hearts == 2)
            {
                life2.Visible = true;
            }
            if (hearts == 3)
            {
                life1.Visible = true;
            }
            score.Text = "Score:" + Score;
        }

        private void keyupevent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                gravity = 8;
                
                    }
           
        }       

        private void keydownevent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;

            }
        }
        private void endGame()
        {
            if(hearts == 0 && lifefree > 3000)
            {
                game_timer.Stop();
                label1.Text = "Game Over! \n Score:" + Score;
                label1.Visible = true;
            }
            else
            {
                switch (hearts)
                {
                    case 3:
                        if (lifefree > 2500)
                        {
                            life1.Visible = false;
                            hearts--;
                            lifefree = 0;
                           
                        }
                        break;
                    case 2:
                        if (lifefree > 2500)
                        {
                            life2.Visible = false;
                            hearts--;
                        }
                        break;
                    case 1:
                        if (lifefree > 2500)
                        {
                            life3.Visible = false;
                            hearts--;
                        }
                        break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void fairydissappear()
        {
            if(fairy.Visible == true && lifefree < 2500)
            {
                fairy.Visible = false;
            }
            else if(fairy.Visible == false && lifefree < 2500)
            {
                fairy.Visible = true;
            }
            else
            {
                fairy.Visible = true;
            }
        }
        private void extraHearts()
        {
            if (hearts < 3)
            {
                hearts++;
                extraheart.Left = 10000;

            }
        }
    }

} 
