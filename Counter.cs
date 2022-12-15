using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    public class Counter : IImpactPoint
    {
        int count = 0;

        HashSet<Particle> around = new HashSet<Particle>();

        static Brush CatClose = new TextureBrush(Properties.Resources.CatClosed);
        static Brush CatOpen = new TextureBrush(Properties.Resources.CatOpened);
        Brush Cat = CatClose;
        
        public override void ImpactParticle(Particle particle)
        {
            float tX = X - particle.X;
            float tY = Y - particle.Y;
            double r = Math.Sqrt(tX * tX + tY * tY); // считаем расстояние от центра точки до центра частицы

            if (r + particle.Radius < 100) // если частица около кота
            {
                around.Add(particle);
            }
            else
            {
                if (around.Contains(particle))
                {
                    around.Remove(particle);
                }
            }

            if (around.Count > 0)
            {
                Cat = CatOpen;
            }
            else
            {
                Cat = CatClose;
            }

            if (r + particle.Radius < 50) // если частица оказалось внутри окружности
            {
                count++;
                particle.Life = 0;
                around.Remove(particle);
            }
        }

        public override void Render(Graphics g)
        {
            var matrix = g.Transform;
            matrix.Translate(X-50, Y-50); // смещаем ее в пространстве
            g.Transform = matrix; // устанавливаем новую матрицу

            g.FillEllipse(Cat, 0, 0, 100, 100);

            g.DrawString(
            $"{count}",
            new Font("Verdana", 10), // шрифт и его размер
            new SolidBrush(Color.Black), // цвет шрифта
            100, // расположение в пространстве
            70
            );
            matrix.Translate(-X+50, -Y+50); // смещаем ее обратно в пространстве
            g.Transform = matrix; // устанавливаем прежнуюю матрицу
        }
    }
}
