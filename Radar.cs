using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    public class Radar : IImpactPoint
    {
        public int radius = 100;
        //public int MinRadius = 50;
        //public int MaxRadius = 200;
        double angle = 0;


        HashSet<Particle> snowballs = new HashSet<Particle>();
        HashSet<Particle> lights = new HashSet<Particle>();

        public override void ImpactParticle(Particle particle)
        {
            float tX = X - particle.X;
            float tY = Y - particle.Y;
            double r = Math.Sqrt(tX * tX + tY * tY); // считаем расстояние от центра точки до центра частицы

            if (r + particle.Radius < radius / 2) // если частица попала в радар
            {

                if (particle.snowball == true)
                {
                    snowballs.Add(particle);
                }
                else
                {
                    lights.Add(particle);
                }
                particle.color = Color.Green;
                particle.inRadar = true;
            }
            else // если частица вышла из радиуса видимости радара
            {
                if (snowballs.Contains(particle) && particle.snowball == true)
                {
                    snowballs.Remove(particle);
                    particle.color = Color.White;
                    particle.inRadar = false;
                }
                if (lights.Contains(particle) && particle.snowball == false)
                {
                    lights.Remove(particle);
                    particle.color = Color.White;
                    particle.inRadar = false;
                }
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse( // Большой круг
                   new Pen(Color.Green, 2),
                   X - radius / 2,
                   Y - radius / 2,
                   radius,
                   radius
               );

            g.DrawEllipse( // Средний круг
                   new Pen(Color.Green, 2),
                   X - radius / 3,
                   Y - radius / 3,
                   radius - radius / 3,
                   radius - radius / 3
               );

            g.DrawEllipse( // Малый круг
                   new Pen(Color.Green, 2),
                   X - radius / 4,
                   Y - radius / 4,
                   radius - radius / 2,
                   radius - radius / 2
               );

            g.DrawLine( // Горизонталь
                new Pen(Color.Green, 2),
                (int)X - radius / 2,
                (int)Y,
                (int)(X + (radius / 2) * Math.Cos(0)),
                (int)(Y + (radius / 2) * Math.Sin(0))
                );

            g.DrawLine( // Вертикаль
                new Pen(Color.Green, 2),
                (int)X,
                (int)Y - radius / 2,
                (int)X,
                (int)Y + radius / 2
                );

            g.DrawLine( // Стрелка
                new Pen(Color.Red, 2),
                (int)X,
                (int)Y,
                (int)(X + (radius / 2) * Math.Cos(angle)),
                (int)(Y + (radius / 2) * Math.Sin(angle))
                );

            g.DrawString(
            $"Снежков: {snowballs.Count}\n" +
            $"Огоньков: {lights.Count}",
            new Font("Verdana", 10), // шрифт и его размер
            new SolidBrush(Color.Black), // цвет шрифта
            X-50, // расположение в пространстве
            Y+radius/2
            );

            if (angle == 360)
            {
                angle = 0;
            }
            angle += 0.05;

        }
    }
}
