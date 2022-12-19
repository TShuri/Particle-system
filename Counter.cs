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

        HashSet<Particle> around = new HashSet<Particle>(); // множество точек, находящихся около кота

        static Brush CatClose = new TextureBrush(Properties.Resources.CatClosed); // кот с открытым ртом
        static Brush CatOpen = new TextureBrush(Properties.Resources.CatOpened); // кот с закрытым ртом
        Brush Cat = CatClose; // текущее картинка кота
        
        public override void ImpactParticle(Particle particle)
        {
            float tX = X - particle.X;
            float tY = Y - particle.Y;
            double r = Math.Sqrt(tX * tX + tY * tY); // считаем расстояние от центра точки до центра частицы

            if (r + particle.Radius < 60) // если частица около кота
            {
                around.Add(particle); // добавляем в множество
            }
            else // если точка не рядом, но есть в множестве, то удаляем
            {
                if (around.Contains(particle))
                {
                    around.Remove(particle);
                }
            }

            if (around.Count > 0) // если рядом есть точки
            {
                Cat = CatOpen; // кот открыл рот
            }
            else
            {
                Cat = CatClose; // кот закрыл рот
            }

            if (r + particle.Radius < 50) // если частица оказалось внутри кота
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

            g.FillEllipse(Cat, 0, 0, 100, 100); // Рисуем кота

            g.DrawString( // Отображаем информацию о количестве
            $"{count}",
            new Font("Verdana", 10), // шрифт и его размер
            new SolidBrush(Color.Black), // цвет шрифта
            100, // расположение в пространстве
            70
            );
            matrix.Translate(-X+50, -Y+50); // смещаем ее обратно в пространстве
            g.Transform = matrix; // устанавливаем прежнуюю матрицу
        }

        public override bool CheckRemove(int mouse_x, int mouse_y) // проверяем кликнули ли по коту
        {
            if (((mouse_x - X) * (mouse_x - X) + (mouse_y - Y) * (mouse_y - Y)) < 50*50) // если кликнули по коту
            {
                return true;
            }
            else return false;
        }
    }
}
