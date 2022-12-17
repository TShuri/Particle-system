using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
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
        Radar radar;
        MouseEventHandler mouseEventHandler;

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
            emitter.UpdateState(); // ���������� ��������
            topEmitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.FillRectangle(brush, 0, 0, picDisplay.Width, picDisplay.Height);
                //g.Clear(Color.Black);
                emitter.Render(g); // �������� �������
                topEmitter.Render(g);
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e) // ���������� �� ������
        {
            if (rbEmitter.Checked)
            {
                emitter.X = e.X;
                emitter.Y = e.Y;
            }
            if (cbDebug.Checked)
            {
                int x = e.X, y = e.Y;
                using (var g = Graphics.FromImage(picDisplay.Image))
                {
                    foreach (var _emitter in emitters)
                    {
                        _emitter.InfoPartical(g, x ,y);
                    }
                }
                picDisplay.Invalidate(); // ���������� �������
            }
            if (rbRadar.Checked)
            {
                radar.X = e.X;
                radar.Y = e.Y;
            }
        }

        private void tbDirection_Scroll(object sender, EventArgs e) // ����-��� ��� ����������� ��������
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}�";
        }

        private void tbTeleport_Scroll(object sender, EventArgs e) // ����-��� ��� ������� ���������
        {
            teleport.radius = tbTeleport.Value;
            lblRadiusTP.Text = $"{tbTeleport.Value}";
        }

        private void tbDirectionTP_Scroll(object sender, EventArgs e) // ����-��� ��� ����������� ������ ���������
        {
            teleport.Direction = tbDirectionTP.Value;
            lblDirectionTP.Text = $"{tbDirectionTP.Value}�";
        }

        private void picDisplay_MouseDoubleClick(object sender, MouseEventArgs e) // ��� ������� ����� ����
        {
            rbEmitter.Checked = !rbEmitter.Checked; // ���/���� ���������� �������� �� ������
        }

        private void picDisplay_MouseDown(object sender, MouseEventArgs e) // �� ����� ����
        {
            if (e.Button == MouseButtons.Left && rbTeleport.Checked) // ����������� ����� ���������
            {
                teleport.X = e.X;
                teleport.Y = e.Y;
            }
            
            if (e.Button == MouseButtons.Right && rbTeleport.Checked) // ����������� ������ ���������
            {
                teleport.outX = e.X;
                teleport.outY = e.Y;
            }

            if (e.Button == MouseButtons.Left && rbColorDit.Checked) // ����������� ����� ������������
            {
                changeColor.X = e.X;
                changeColor.Y = e.Y;
            }

            if (e.Button == MouseButtons.Left && rbCounter.Checked) // ���������� ��������
            {

                counter = new Counter
                {
                    X = e.X,
                    Y = e.Y,
                };
                emitter.impactPoints.Add(counter);
            }

            if (e.Button == MouseButtons.Right && rbCounter.Checked) // �������� ��������
            {
                emitter.DeleteCounter(e.X, e.Y);
            }
        }

        private void cbSnow_CheckedChanged(object sender, EventArgs e) // ��������� �����
        {
            if (cbSnow.Checked)
            {
                topEmitter.ParticlesPerTick = 1;
            }
            else
            {
                topEmitter.ParticlesPerTick = 0;
            }
        }

        private void tbColorDit_Scroll(object sender, EventArgs e) // ������ ����� ������������
        {
            changeColor.radius = tbColorDit.Value;
            lblRadiusCD.Text = $"{tbColorDit.Value/2}";
        }

        private void buttonColor_Click(object sender, EventArgs e) // ����� ����� ����� ������������
        {
            colorDialog1.ShowDialog();
            changeColor.color = colorDialog1.Color;
            buttonColor.BackColor = colorDialog1.Color;
        }

        private void tbParticlesCount_Scroll(object sender, EventArgs e) // ���������� �����
        {
            emitter.ParticlesPerTick = tbParticlesCount.Value;
            lblParticles.Text = $"{tbParticlesCount.Value}";
        }

        private void cbDebug_CheckedChanged(object sender, EventArgs e) // Debage ����
        {
            if (cbDebug.Checked)
            {
                foreach (var _emitter in emitters)
                {
                    _emitter.debug = true;
                }
                timer1_Tick(sender, e);
                timer1.Stop();
            }
            else
            {
                foreach (var _emitter in emitters)
                {
                    _emitter.debug = false;
                }
                timer1.Start();
            }
        }

        private void rbRadar_CheckedChanged(object sender, EventArgs e) // ���/���� ������
        {
            if (rbRadar.Checked)
            {
                radar = new Radar
                {
                    X = picDisplay.Width / 2,
                    Y = picDisplay.Height / 2
                };
                topEmitter.impactPoints.Add(radar);

                mouseEventHandler = new MouseEventHandler(radar_MouseWheel);
                this.MouseWheel += mouseEventHandler;
            }
            else
            {
                topEmitter.impactPoints.Remove(radar);
                this.MouseWheel -= mouseEventHandler;
            }
        }
        void radar_MouseWheel(object sender, MouseEventArgs e) // ������� ��� ��������� �������� ��� 
        {                                                      // ��������� ������� ������
            if (e.Delta > 0)
            {
                radar.radius += 5;
            }
            else
            {
                radar.radius -= 5;
            }
        }
    }
}