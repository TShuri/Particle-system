namespace ParticleSystem
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        Emitter topEmitter;
        Teleport teleport;
        ChangeColor changeColor;

        //GravityPoint point1; // добавил поле под первую точку
        //GravityPoint point2; // добавил поле под вторую точку

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };
            emitters.Add(this.emitter);

            this.topEmitter = new TopEmitter
            {
                Width = picDisplay.Width,
                GravitationY = 0.05f,
                LifeMin = 100,
                LifeMax = 250,
                SpeedMax = 1,
                ColorFrom = Color.White,
                ColorTo = Color.FromArgb(0, Color.Black),
                ParticlesPerTick = 1,
            };
            emitters.Add(this.topEmitter);

            teleport = new Teleport
            {
                X = picDisplay.Width / 2 - 200,
                Y = picDisplay.Height / 2,
                outX = picDisplay.Width / 2 + 300,
                outY = picDisplay.Height / 2,
                Direction = emitter.Direction,
                Spreading = emitter.Spreading,
                SpeedMin = emitter.SpeedMin,
                SpeedMax = emitter.SpeedMax
            };
            emitter.impactPoints.Add(teleport);

            changeColor = new ChangeColor
            {
                X = picDisplay.Width / 2 - 400,
                Y = picDisplay.Height / 2
            };
            topEmitter.impactPoints.Add(changeColor);
            /*point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };
            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            // привязываем поля к эмиттеру
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // Обновление эмиттера
            topEmitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // рендерим систему
                topEmitter.Render(g);
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (rbEmitter.Checked)
            {
                emitter.X = e.X;
                emitter.Y = e.Y;
            }
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbTeleport_Scroll(object sender, EventArgs e)
        {
            teleport.radius = tbTeleport.Value;
        }

        private void tbDirectionTP_Scroll(object sender, EventArgs e)
        {
            teleport.Direction = tbDirectionTP.Value;
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            //rbEmitter.Checked = !rbEmitter.Checked;
        }

        private void picDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            rbEmitter.Checked = !rbEmitter.Checked;
        }

        private void picDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && rbTeleport.Checked)
            {
                teleport.X = e.X;
                teleport.Y = e.Y;
            }
            
            if (e.Button == MouseButtons.Right && rbTeleport.Checked)
            {
                teleport.outX = e.X;
                teleport.outY = e.Y;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                topEmitter.ParticlesPerTick = 1;
                //timer1.Start();
            }
            else
            {
                topEmitter.ParticlesPerTick = 0;
                //timer1.Stop();
            }
        }
    }
}