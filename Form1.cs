using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name : Liana Lee (Haiinn)
//per:5
namespace Liana_Lee__Haiinn__Airplane
{
    

    public partial class Form1 : Form
    {
        //sets intergers and pictures to make the game work correctl

        private readonly int FORM_WIDTH = 900;
        private readonly int FORM_HEIGHT = 750;

        private int BOMBER_SPEED = -2;
        private bool GOING_RIGHT = true;
        private TimeSpan GAME_SPAN = TimeSpan.FromSeconds(90);
        private List<PictureBox> bulletList = new List<PictureBox>();
        private List<PictureBox> gunList = new List<PictureBox>();

        private Image BULLET;
        private Image GUN;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //shooterHealth.Width -= 10;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            // remove the border
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            InitializePositions();
            
            

            bomberTimer.Interval = 2;
            bomberTimer.Start();
            int a = 5;

            string b = "hello";

            TimeSpan c = TimeSpan.FromSeconds(1);

            // game timer
            timer_timer.Interval = 1000;
            timer_timer.Start();
            lbl_time.Text = string.Format("{0:mm\\:ss}", GAME_SPAN);

            // get bullet image and rotate
            BULLET = bulletTemplate.Image;
            BULLET.RotateFlip(RotateFlipType.Rotate270FlipY);
            bullet_timer.Interval = 2;
            bullet_timer.Start();

            GOING_RIGHT = false;


            gun_timer.Interval = 2;
            gun_timer.Start();
        }

        private void InitializePositions()
        {

            // this sets the widow size
            this.Width = FORM_WIDTH;
            this.Height = FORM_HEIGHT;


            // width of bomber and shooter health: half the size of the window
            bomberHealth.Width = this.Width / 2 - 20;
            shooterHealth.Width = this.Width / 2 - 35;


            //lbl_bomberHealth.Location = new Point((Width / 2) - lbl_bomberHealth.Width - 10, 50);
            // lbl_shooterHealth.Location = new Point((Width / 2) + 10, 50);
            lbl_time.Location = new Point(Width / 2 - lbl_time.Width / 2, 15);

            bomberHealth.Location = new Point((Width / 2) - bomberHealth.Width - 10, 60 + lbl_bomberHealth.Height);
            shooterHealth.Location = new Point((Width / 2) + 10, 60 + lbl_bomberHealth.Height);

            bomber.Location = new Point(Width - bomber.Width - 20, bomberHealth.Location.Y + bomberHealth.Height + 20);

            shooter.Size = new Size(70, 70);
            shooter.Location = new Point(Width / 2 - shooter.Width / 2, Height - shooter.Height - 50);


            lbl_bomberHealth.Location = new Point(bomberHealth.Width / 2- lbl_bomberHealth.Width / 2 - 10, 50);
            lbl_shooterHealth.Location = new Point(shooterHealth.Location.X + (shooterHealth.Width / 2 - lbl_bomberHealth.Width / 2 - 10), 50);
        }   

            

        private void BomberTimerTick(object sender, EventArgs e)
        {
            var location = bomber.Location;
            bomber.Location = new Point(location.X + BOMBER_SPEED, location.Y);
            Console.WriteLine($"Location changed from {location} to {bomber.Location}");
            if(bomber.Location.X < 10)
            {
                // change rotation
                RotateObject(bomber);

                // change flow direction
                BOMBER_SPEED = Math.Abs(BOMBER_SPEED);
            }

            if (bomber.Location.X > (this.Size.Width - bomber.Width))
            {
                // change rotation
                RotateObject(bomber);

                // change flow direction
                BOMBER_SPEED = Math.Abs(BOMBER_SPEED) * -1;
            }

        }

        private void RotateObject(PictureBox box)
        {
            var image = box.Image;

            image.RotateFlip(RotateFlipType.Rotate180FlipY);
            box.Image = image;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if(GAME_SPAN.TotalSeconds < 1)
            {
                // game over
                GameOver();
            }


            GAME_SPAN = GAME_SPAN.Subtract(TimeSpan.FromSeconds(1));
            lbl_time.Text = string.Format("{0:mm\\:ss}", GAME_SPAN);

            // drop bomb
            CreateBomb();

        }

        private void CreateBomb()
        {
            var bullet = new PictureBox()
            {
                Width = bulletTemplate.Width,
                Height = bulletTemplate.Height,
                Location = bomber.Location,
                Visible = true,
                Image = BULLET,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            bulletList.Add(bullet);

            this.Controls.Add(bullet);
            // Console.WriteLine(bullet);

        }

        private void BulletTimer_Tick(object sender, EventArgs e)
        {
            if (bulletList.Count < 1)
                return;

            for(var i = 0; i< bulletList.Count; i++)
            {
                var bullet = bulletList[i];
                var location = bullet.Location;

                // check if touching shooter or bottom edge
                if(TouchingShooter(bullet) || location.Y > (this.Width - bullet.Width - 20))
                {
                    this.Controls.Remove(bullet);
                    bulletList.Remove(bullet);
                    continue;
                }

                bullet.Location = new Point(location.X, location.Y + 4);
            }
        }

        private bool TouchingShooter(PictureBox bullet)
        {
            // decrease shooter hearlth if touching gun
            // decrease shooter health progress bar
            if (bullet.Bounds.IntersectsWith(shooter.Bounds))
            {
                bulletList.Remove(bullet);
                shooterHealth.Width -= 4;
                if (shooterHealth.Width < 1)
                    GameOver();

                return true;
            }

            return false;
        }


        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);

            if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if(shooter.Location.X > 10)
                {
                    shooter.Location = new Point(shooter.Location.X - 20, shooter.Location.Y);
                }

                if (GOING_RIGHT)
                {
                    RotateObject(shooter);
                    GOING_RIGHT = false;
                }
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (shooter.Location.X < (Width - shooter.Width) - 10)
                {
                    shooter.Location = new Point(shooter.Location.X + 20, shooter.Location.Y);
                }

                if (!GOING_RIGHT)
                {
                    RotateObject(shooter);
                    GOING_RIGHT = true;
                }
            }

            // Liana's idea
            if(e.KeyCode == Keys.Space)
            {
                CreateGun();
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            CreateGun();
        }

        private void CreateGun()
        {
            var g = new PictureBox()
            {
                Location = shooter.Location,
                Visible = true,
                BackColor = Color.Transparent,
                Image = gun.Image,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = gun.Size
            };


            // added this line cuz i had a strange bug where the gun was under everthing
            g.BringToFront();
            this.Controls.Add(g);
            gunList.Add(g);

        }


        // on every tick, move all the guns in the list
        // if they are over the plane or touching it,
        // destroy the guns
        private void GunTimer_Tick(object sender, EventArgs e)
        {


            if (gunList.Count < 1)
                return;

            for (var i = 0; i < gunList.Count; i++)
            {
                var g = gunList[i];
                var location = g.Location;

                // check if touching shooter or bottom edge
                if (TouchingBomber(g) || location.Y < bomber.Location.Y)
                {
                    this.Controls.Remove(g);
                    gunList.Remove(g);
                    continue;
                }

                g.Location = new Point(location.X, location.Y - 6);
            }
        }

        
        private bool TouchingBomber(PictureBox g)
        {
            // decrease bomber hearlth if touching gun
            // decrease bomber health progress bar
            if (g.Bounds.IntersectsWith(bomber.Bounds))
            {
                gunList.Remove(g);
                bomberHealth.Width -= 4;
                if (bomberHealth.Width < 1)
                    Win();

                return true;
            }

            return false;
        }

        private void GameOver()
        {
            // stop all timers and popup a message

            timer_timer.Stop();
            bullet_timer.Stop();
            gun_timer.Stop();
            GAME_SPAN = TimeSpan.FromSeconds(90);
            MessageBox.Show("Game OVER");
        }

        

        private void Win()
        {
            // stop all timers and popup a message
            timer_timer.Stop();
            bullet_timer.Stop();
            gun_timer.Stop();
            GAME_SPAN = TimeSpan.FromSeconds(60 * 1.5);
            MessageBox.Show("YOU WIN!");
        }


    }

   
}

