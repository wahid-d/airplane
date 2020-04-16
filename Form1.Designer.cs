namespace Liana_Lee__Haiinn__Airplane
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_bomberHealth = new System.Windows.Forms.Label();
            this.lbl_shooterHealth = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.bomberTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer_timer = new System.Windows.Forms.Timer(this.components);
            this.bullet_timer = new System.Windows.Forms.Timer(this.components);
            this.gun = new System.Windows.Forms.PictureBox();
            this.bulletTemplate = new System.Windows.Forms.PictureBox();
            this.bomber = new System.Windows.Forms.PictureBox();
            this.shooterHealth = new System.Windows.Forms.PictureBox();
            this.bomberHealth = new System.Windows.Forms.PictureBox();
            this.shooter = new System.Windows.Forms.PictureBox();
            this.gun_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shooterHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomberHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shooter)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bomberHealth
            // 
            this.lbl_bomberHealth.AutoSize = true;
            this.lbl_bomberHealth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_bomberHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bomberHealth.ForeColor = System.Drawing.Color.White;
            this.lbl_bomberHealth.Location = new System.Drawing.Point(270, 25);
            this.lbl_bomberHealth.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_bomberHealth.Name = "lbl_bomberHealth";
            this.lbl_bomberHealth.Size = new System.Drawing.Size(323, 46);
            this.lbl_bomberHealth.TabIndex = 8;
            this.lbl_bomberHealth.Text = ": Bomber Health";
            // 
            // lbl_shooterHealth
            // 
            this.lbl_shooterHealth.AutoSize = true;
            this.lbl_shooterHealth.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_shooterHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shooterHealth.ForeColor = System.Drawing.Color.White;
            this.lbl_shooterHealth.Location = new System.Drawing.Point(450, 25);
            this.lbl_shooterHealth.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_shooterHealth.Name = "lbl_shooterHealth";
            this.lbl_shooterHealth.Size = new System.Drawing.Size(325, 46);
            this.lbl_shooterHealth.TabIndex = 9;
            this.lbl_shooterHealth.Text = "Shooter Health :";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_time.Location = new System.Drawing.Point(788, 18);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(167, 63);
            this.lbl_time.TabIndex = 18;
            this.lbl_time.Text = "01:30";
            // 
            // bomberTimer
            // 
            this.bomberTimer.Tick += new System.EventHandler(this.BomberTimerTick);
            // 
            // timer_timer
            // 
            this.timer_timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // bullet_timer
            // 
            this.bullet_timer.Tick += new System.EventHandler(this.BulletTimer_Tick);
            // 
            // gun
            // 
            this.gun.Image = global::Liana_Lee__Haiinn__Airplane.Properties.Resources.gun;
            this.gun.Location = new System.Drawing.Point(855, 232);
            this.gun.Margin = new System.Windows.Forms.Padding(0);
            this.gun.Name = "gun";
            this.gun.Size = new System.Drawing.Size(20, 28);
            this.gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gun.TabIndex = 20;
            this.gun.TabStop = false;
            this.gun.Visible = false;
            // 
            // bulletTemplate
            // 
            this.bulletTemplate.Image = global::Liana_Lee__Haiinn__Airplane.Properties.Resources.bullet;
            this.bulletTemplate.Location = new System.Drawing.Point(838, 195);
            this.bulletTemplate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bulletTemplate.Name = "bulletTemplate";
            this.bulletTemplate.Size = new System.Drawing.Size(39, 35);
            this.bulletTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bulletTemplate.TabIndex = 19;
            this.bulletTemplate.TabStop = false;
            this.bulletTemplate.Visible = false;
            // 
            // bomber
            // 
            this.bomber.BackColor = System.Drawing.Color.Transparent;
            this.bomber.Image = global::Liana_Lee__Haiinn__Airplane.Properties.Resources.jet_black;
            this.bomber.Location = new System.Drawing.Point(855, 83);
            this.bomber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bomber.Name = "bomber";
            this.bomber.Size = new System.Drawing.Size(96, 55);
            this.bomber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomber.TabIndex = 17;
            this.bomber.TabStop = false;
            // 
            // shooterHealth
            // 
            this.shooterHealth.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.shooterHealth.Location = new System.Drawing.Point(448, 57);
            this.shooterHealth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shooterHealth.Name = "shooterHealth";
            this.shooterHealth.Size = new System.Drawing.Size(428, 22);
            this.shooterHealth.TabIndex = 16;
            this.shooterHealth.TabStop = false;
            // 
            // bomberHealth
            // 
            this.bomberHealth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bomberHealth.Location = new System.Drawing.Point(9, 57);
            this.bomberHealth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bomberHealth.Name = "bomberHealth";
            this.bomberHealth.Size = new System.Drawing.Size(428, 22);
            this.bomberHealth.TabIndex = 10;
            this.bomberHealth.TabStop = false;
            // 
            // shooter
            // 
            this.shooter.Image = global::Liana_Lee__Haiinn__Airplane.Properties.Resources.shooter;
            this.shooter.Location = new System.Drawing.Point(414, 629);
            this.shooter.Name = "shooter";
            this.shooter.Size = new System.Drawing.Size(68, 69);
            this.shooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shooter.TabIndex = 21;
            this.shooter.TabStop = false;
            // 
            // gun_timer
            // 
            this.gun_timer.Tick += new System.EventHandler(this.GunTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 914);
            this.Controls.Add(this.shooter);
            this.Controls.Add(this.gun);
            this.Controls.Add(this.bulletTemplate);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.bomber);
            this.Controls.Add(this.shooterHealth);
            this.Controls.Add(this.bomberHealth);
            this.Controls.Add(this.lbl_shooterHealth);
            this.Controls.Add(this.lbl_bomberHealth);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.gun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shooterHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomberHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shooter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label lbl_bomberHealth;
        private System.Windows.Forms.Label lbl_shooterHealth;
        private System.Windows.Forms.PictureBox bomberHealth;
        private System.Windows.Forms.PictureBox shooterHealth;
        private System.Windows.Forms.PictureBox bomber;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer bomberTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer_timer;
        private System.Windows.Forms.PictureBox bulletTemplate;
        private System.Windows.Forms.Timer bullet_timer;
        private System.Windows.Forms.PictureBox gun;
        private System.Windows.Forms.PictureBox shooter;
        private System.Windows.Forms.Timer gun_timer;
    }
}

