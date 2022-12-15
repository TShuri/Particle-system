using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Runtime.Versioning;

namespace ParticleSystem
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        Emitter topEmitter;
        Teleport teleport;
        ChangeColor changeColor;
        Counter counter;

        Brush brush = new TextureBrush(Properties.Resources.Winter);

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            buttonColor.BackColor = Color.Red;

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
                Y = picDisplay.Height / 2,
                color = buttonColor.BackColor
            };
            topEmitter.impactPoints.Add(changeColor);
            emitter.impactPoints.Add(changeColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // Обновление эмиттера
            topEmitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.FillRectangle(brush, 0, 0, picDisplay.Width, picDisplay.Height);
                //g.Clear(Color.Black);
                emitter.Render(g); // рендерим систему
                topEmitter.Render(g);
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e) // Следование эммитера за мышкой
        {
            if (rbEmitter.Checked)
            {
                emitter.X = e.X;
                emitter.Y = e.Y;
            }
        }

        private void tbDirection_Scroll(object sender, EventArgs e) // Трек-бар для направления эммитера
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbTeleport_Scroll(object sender, EventArgs e) // Трек-бар для радиуса телепорта
        {
            teleport.radius = tbTeleport.Value;
        }

        private void tbDirectionTP_Scroll(object sender, EventArgs e) // Трек-бар для направления выхода телепорта
        {
            teleport.Direction = tbDirectionTP.Value;
        }

        private void picDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            rbEmitter.Checked = !rbEmitter.Checked; // Вкл/выкл следования эмиттера за мышкой
        }

        private void picDisplay_MouseDown(object sender, MouseEventArgs e) // По клику мыши
        {
            if (e.Button == MouseButtons.Left && rbTeleport.Checked) // Перемещение входа телепорта
            {
                teleport.X = e.X;
                teleport.Y = e.Y;
            }
            
            if (e.Button == MouseButtons.Right && rbTeleport.Checked) // Перемещение выхода телепорта
            {
                teleport.outX = e.X;
                teleport.outY = e.Y;
            }

            if (e.Button == MouseButtons.Left && rbColorDit.Checked) // Перемещение точки закрашивания
            {
                changeColor.X = e.X;
                changeColor.Y = e.Y;
            }

            if (e.Button == MouseButtons.Left && rbCounter.Checked)
            {
                counter = new Counter
                {
                    X = e.X,
                    Y = e.Y,
                };
                emitter.impactPoints.Add(counter);
            }
        }

        private void cbSnow_CheckedChanged(object sender, EventArgs e) // Включение снега
        {
            if (cbSnow.Checked)
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

        private void tbColorDit_Scroll(object sender, EventArgs e) // Радиус точки закрашивания
        {
            changeColor.radius = tbColorDit.Value;
        }

        private void buttonColor_Click(object sender, EventArgs e) // Выбор цвета точки закрашивания
        {
            colorDialog1.ShowDialog();
            changeColor.color = colorDialog1.Color;
            buttonColor.BackColor = colorDialog1.Color;
        }
    }
}