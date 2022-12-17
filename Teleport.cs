using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ParticleSystem
{
    public class Teleport : IImpactPoint
    {
        public float outX, outY; // Координаты выхода телепорта
        public float radius = 100;

        public int Direction = 0;
        public int Spreading = 360;
        public int SpeedMin = 1;
        public int SpeedMax = 10;

        public override void ImpactParticle(Particle particle)
        {
            float tX = X - particle.X;
            float tY = Y - particle.Y;
            double r = Math.Sqrt(tX * tX + tY * tY); // считаем расстояние от центра точки до центра частицы

            if (r + particle.Radius < radius / 2) // если частица оказалось внутри окружности
            {
                particle.X = outX + tX;
                particle.Y = outY + tY;

                var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

                var speed = Particle.rand.Next(SpeedMin, SpeedMax);

                particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
                particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);
            }
        }

        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Blue, 2),
                   X - radius / 2,
                   Y - radius / 2,
                   radius,
                   radius
               );
            g.DrawEllipse(
                   new Pen(Color.Yellow, 2),
                   outX - radius / 2,
                   outY - radius / 2,
                   radius,
                   radius
               );
        }
    }
}
