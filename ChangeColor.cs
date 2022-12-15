using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ChangeColor : IImpactPoint
    {
        public float radius = 200;
        public Color color = Color.Green;
        
        public override void ImpactParticle(Particle particle)
        {
            float tX = X - particle.X;
            float tY = Y - particle.Y;
            double r = Math.Sqrt(tX * tX + tY * tY); // считаем расстояние от центра точки до центра частицы

            if (r + particle.Radius < radius / 2) // если частица оказалось внутри окружности
            {
                particle.color = this.color;   
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(color, 2),
                   X - radius / 2,
                   Y - radius / 2,
                   radius,
                   radius
               );
        }
    }
}
