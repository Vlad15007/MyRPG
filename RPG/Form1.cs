using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SmenaBloka(object sender, EventArgs e)
        {
            HeroHead.Image = null;
            HeroBody.Image = null;
            HeroLegs.Image = null;

            PictureBox element = (PictureBox)sender;

            element.Image = Properties.Resources.Sheald;
        }

        private void Hod(object sender, EventArgs e)
        {
            Drager(Enemy);
            Thread.Sleep(500);
            EnemyAtack();
        }

        private void EnemyAtack()
        {
            Random random = new Random();
            int randomAtack = random.Next(0, 3);

            PictureBox objectAtack = null;

            if(randomAtack == 0)
            {
                objectAtack = HeroHead;
            }
            else if (randomAtack == 1)
            {
                objectAtack = HeroBody;
            }
            else
            {
                objectAtack = HeroLegs;
            }


            if (objectAtack.Image == null)
            {
                objectAtack.BackColor = Color.Brown;
            }
            else objectAtack.BackColor = Color.Teal;

            objectAtack.Update();

            Drager(Hero);
            objectAtack.BackColor = Color.Transparent;

        }

        private void Drager(TableLayoutPanel person)
        {
            int x = person.Location.X;
            int y = person.Location.Y;
            int zaderjka = 30;
            int sulaX = 5;
            int sulaY = 2;
            for (int i = 0; i < 5; i++)
            {
                person.Location = new Point(x + sulaX, y - sulaY);
                Thread.Sleep(zaderjka);
                person.Location = new Point(x, y);
                Thread.Sleep(zaderjka);
                person.Location = new Point(x - sulaX, y + sulaY);
                Thread.Sleep(zaderjka);
            }
            person.Location = new Point(x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("Music/epic.wav");
            player.Play();

        }
    }
}
