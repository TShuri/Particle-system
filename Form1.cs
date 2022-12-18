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
        Bounce bounce;
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
            topEmitter.impactPoints.Add(teleport);

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
                //latestImg = new Bitmap(picDisplay.Image);
                using (var g = Graphics.FromImage(picDisplay.Image))
                {
                    foreach (var _emitter in emitters)
                    {
                        _emitter.InfoPartical(g, x, y);    
                    }
                }
                picDisplay.Invalidate(); // ���������� �������
            }
            if (rbRadar.Checked)
            {
                radar.X = e.X;
                radar.Y = e.Y;
            }
            if (rbBounce.Checked)
            {
                bounce.X = e.X;
                bounce.Y = e.Y;
            }
        }

        private void tbSpreading_Scroll(object sender, EventArgs e) // ����-��� ��� �������� ��������
        {
            emitter.Spreading = tbSpreading.Value;
            lblSpreading.Text = $"{tbSpreading.Value}";
        }

        private void tbTeleport_Scroll(object sender, EventArgs e) // ����-��� ��� ������� ���������
        {
            teleport.radius = tbTeleport.Value;
            lblRadiusTP.Text = $"{tbTeleport.Value/2}";
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
                topEmitter.impactPoints.Add(counter);
            }

            if (e.Button == MouseButtons.Right && rbCounter.Checked) // �������� ��������
            {
                emitter.Delete<Counter>(e.X, e.Y);
                topEmitter.Delete<Counter>(e.X, e.Y);
            }

            if (e.Button == MouseButtons.Left && rbBounce.Checked) // ���������� ����� �������
            {

                var _bounce = new Bounce
                {
                    X = e.X,
                    Y = e.Y,
                    radius = bounce.radius
                };
                emitter.impactPoints.Add(_bounce);
                topEmitter.impactPoints.Add(_bounce);
            }

            if (e.Button == MouseButtons.Right && rbBounce.Checked) // �������� ����� �������
            {
                emitter.Delete<Bounce>(e.X, e.Y);
                topEmitter.Delete<Bounce>(e.X, e.Y);
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
                emitter.impactPoints.Add(radar);

                mouseEventHandler = new MouseEventHandler(radar_MouseWheel);
                this.MouseWheel += mouseEventHandler;
            }
            else
            {
                emitter.impactPoints.Remove(radar);
                topEmitter.impactPoints.Remove(radar);
                this.MouseWheel -= mouseEventHandler;
            }
        }
        void radar_MouseWheel(object sender, MouseEventArgs e) // ������� ��� ��������� �������� ��� 
        {                                                      // ��������� �������
            if (e.Delta > 0)
            {
                radar.radius += 5;
            }
            else
            {
                radar.radius -= 5;
            }
        }

        private void rbBounce_CheckedChanged(object sender, EventArgs e) // ���/���� ����� �������
        {
            if (rbBounce.Checked)
            {
                bounce = new Bounce
                {
                    X = picDisplay.Width / 2,
                    Y = picDisplay.Height / 2
                };
                topEmitter.impactPoints.Add(bounce);
                emitter.impactPoints.Add(bounce);

                mouseEventHandler = new MouseEventHandler(bounce_MouseWheel);
                this.MouseWheel += mouseEventHandler;
            }
            else
            {
                emitter.impactPoints.Remove(bounce);
                topEmitter.impactPoints.Remove(bounce);
                this.MouseWheel -= mouseEventHandler;
            }
        }

        void bounce_MouseWheel(object sender, MouseEventArgs e) // ������� ��� ��������� �������� ��� 
        {                                                      // ��������� �������
            if (e.Delta > 0)
            {
                bounce.radius += 5;
            }
            else
            {
                bounce.radius -= 5;
            }
        }

        private void rbEmitter_CheckedChanged(object sender, EventArgs e) // ���������� ���������
        {
            if (rbEmitter.Checked)
            {
                mouseEventHandler = new MouseEventHandler(emitter_MouseWheel);
                this.MouseWheel += mouseEventHandler;
            }
            else
            {
                this.MouseWheel -= emitter_MouseWheel;
            }
        }

        void emitter_MouseWheel(object sender, MouseEventArgs e) // ������� ��� ��������� �������� ��� 
        {                                                      // ��������� ����������� ��������
            if (e.Delta > 0)
            {
                emitter.Direction += 10;
            }
            else
            {
                emitter.Direction -= 10;
            }
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

                buttonStep.Enabled = true;
                buttonStep.Visible = true;

                tbSimulate.Value = 10;
                tbSimulate.Enabled = true;
                tbSimulate.Visible = true;
            }
            else
            {
                foreach (var _emitter in emitters)
                {
                    _emitter.debug = false;
                }
                timer1.Interval = 40;
                timer1.Start();

                buttonStep.Enabled = false;
                buttonStep.Visible = false;

                tbSimulate.Enabled = false;
                tbSimulate.Visible = false;
            }
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void tbSimulate_Scroll(object sender, EventArgs e)
        {
            if (tbSimulate.Value == 10)
            {
                timer1.Stop();
            }

            else
            {
                if (tbSimulate.Value > 0)
                {
                    timer1.Interval = 40 + tbSimulate.Value * 20;
                    timer1.Start();
                }
            }
        }
    }
}