using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    public class Teleport : IImpactPoint
    {
        public float outX, outY;
        public float radius = 100;
        public override void ImpactParticle(Particle particle)
        {
            float tX = X - particle.X;
            float tY = Y - particle.Y;
            double r = Math.Sqrt(tX * tX + tY * tY); // считаем расстояние от центра точки до центра частицы

            if (r + particle.Radius < radius / 2) // если частица оказалось внутри окружности
            {
                particle.X = outX;
                particle.Y = outY;
            }
        }

        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - radius / 2,
                   Y - radius / 2,
                   radius,
                   radius
               );
            g.DrawEllipse(
                   new Pen(Color.Red),
                   outX - radius / 2,
                   outY - radius / 2,
                   radius,
                   radius
               );
        }
    }
}
