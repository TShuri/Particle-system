using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    public class Particle
    {
        public int Radius; // радуис частицы
        public float X; // X координата положения частицы в пространстве
        public float Y; // Y координата положения частицы в пространстве

        public float SpeedX; // скорость перемещения по оси X
        public float SpeedY; // скорость перемещения по оси Y

        public float Life; // запас здоровья частицы
        public Color color; // цвет

        // добавили генератор случайных чисел
        public static Random rand = new Random();

        public bool debug = false; // если включен дебаг режим
        public bool inRadar = false; // если точка в радаре

        public bool snowball = false; // если точка является снежком

        // конструктор по умолчанию будет создавать кастомную частицу
        public Particle()
        {
            var direction = (double)rand.Next(360);
            var speed = 1 + rand.Next(10);

            // рассчитываем вектор скорости
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 2 + rand.Next(10);
            Life = 20 + rand.Next(100); // Добавили исходный запас здоровья от 20 до 120
        }

        public virtual void Draw(Graphics g)
        {
            // рассчитываем коэффициент прозрачности по шкале от 0 до 1.0
            float k = Math.Min(1f, Life / 100);
            // рассчитываем значение альфа канала в шкале от 0 до 255
            // по аналогии с RGB, он используется для задания прозрачности
            int alpha = (int)(k * 255);

            // создаем цвет из уже существующего, но привязываем к нему еще и значение альфа канала
            var color = Color.FromArgb(alpha, Color.Black);
            var b = new SolidBrush(color);

            // остальное все так же
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }

        public void DrawSpeedVector(Graphics g) // отображение вектора направления
        {
            g.DrawLine(new Pen(Color.OrangeRed, 1), X, Y, (int)(X + SpeedX * 4), (int)(Y + SpeedY * 4));
        }

        public void DrawInfo(Graphics g, int _x, int _y) // отображение информации о точке
        {
            var x = Math.Abs(X - _x);
            var y = Math.Abs(Y - _y);
            var lenght = Math.Sqrt(x * x + y * y);

            if (lenght < Radius)
            {
                var b = new SolidBrush(Color.SkyBlue);
                g.FillRectangle(b, X, Y, 50, 50);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.DrawString("X: " + (int)X, new Font("Arial", 10), Brushes.Black, X + 25, Y + 10, stringFormat);
                g.DrawString("Y: " + (int)Y, new Font("Arial", 10), Brushes.Black, X + 25, Y + 25, stringFormat);
                g.DrawString("Life: " + (int)Life, new Font("Arial", 10), Brushes.Black, X + 25, Y + 40, stringFormat);
            }
        }
    }

    public class ParticleColorful : Particle
    {
        // два новых поля под цвет начальный и конечный
        public Color FromColor;
        public Color ToColor;

        // для смеси цветов
        public static Color MixColor(Color color1, Color color2, float k)
        {
            return Color.FromArgb(
                (int)(color2.A * k + color1.A * (1 - k)),
                (int)(color2.R * k + color1.R * (1 - k)),
                (int)(color2.G * k + color1.G * (1 - k)),
                (int)(color2.B * k + color1.B * (1 - k))
            );
        }

        // ну и отрисовку перепишем
        public override void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);

            var updateColor = MixColor(ToColor, FromColor, k); // базовый цвет точки совпадает с fromColor
            
            // так как k уменьшается от 1 до 0, то порядок цветов обратный
            if (color != FromColor) // точка закрашивания меняет цвет частиы
            {
                updateColor = MixColor(ToColor, color, k);
            }
            
            if (inRadar) // радар закрашивает точку
            {
                updateColor = MixColor(color, color, k);
            }

            var b = new SolidBrush(updateColor);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            if (debug) // дебаг режим - рисуем векторы направления частиц
            {
                DrawSpeedVector(g);
            }
            
            b.Dispose();
        }
    }
}
