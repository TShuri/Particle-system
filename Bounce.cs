using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    public class Bounce : IImpactPoint
    {
        public int radius = 100;
        public float angle = 0;
        private bool touch = false;

        public override void ImpactParticle(Particle particle)
        {
            float tX = X - particle.X;
            float tY = Y - particle.Y;
            double r = Math.Sqrt(tX * tX + tY * tY); // считаем расстояние от центра точки до центра частицы

            float nX = tX / (float)r;
            float nY = tY / (float)r;


            angle = (float)(Math.Cos((tX * nX + tY * nY) / (Math.Sqrt(tX * tX + nX * nX) + Math.Sqrt(tY * tY + nY * nY))));

            if (r + particle.Radius < radius / 2) // если частица оказалось внутри окружности
            {
                float dot = particle.SpeedX * nX + particle.SpeedY * nY;

                particle.SpeedX = particle.SpeedX - 2 * dot * nX;
                particle.SpeedY = particle.SpeedY - 2 * dot * nY;

                particle.X += particle.SpeedX;
                particle.Y += particle.SpeedY;

                touch = true;
            }
        }

        public override bool CheckRemove(int mouse_x, int mouse_y) // Проверяем удаляем точку по которому кликнули
        {
            if (((mouse_x - X) * (mouse_x - X) + (mouse_y - Y) * (mouse_y - Y)) <  radius*radius) // Если кликнули по точке
            {
                return true;
            }
            else return false;
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(
                Brushes.SandyBrown,
                X - radius / 2,
                Y - radius / 2,
                radius,
                radius
                );

            int size = 2;
            if (touch)
            {
                size = 7;
            }
            g.DrawEllipse(
                       new Pen(Color.DeepSkyBlue, size),
                       X - radius / 2,
                       Y - radius / 2,
                       radius,
                       radius
                       );
            touch = false;
        }
    }
}
