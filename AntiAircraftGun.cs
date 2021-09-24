using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormAAG
{
    class AntiAircraftGun
    {
        /// <summary>
        /// Наличие радиолокации
        /// </summary>
        public bool Radiolocation { private set; get; }
        /// <summary>
        /// Наличие пушки
        /// </summary>
        public bool Gun { private set; get; }
        /// <summary>
        /// Правая кооридната отрисовки
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Левая кооридната отрисовки
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки зенитки
        /// </summary>
        private readonly int AagWidth = 100;
        /// <summary>
        /// Высота отрисовки зенитки
        /// </summary>
        private readonly int AagHeight = 60;
        /// <summary>
        /// Максимальная скорость зенитки
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес зенитки
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool gun, bool radiolocation)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Gun = gun;
            Radiolocation = radiolocation;

        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - AagWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - 50 - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - AagHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawTransport(Graphics g)
        {
             Pen pen = new Pen(MainColor);
            Color BackgroundColor = Color.FromArgb(240, 240, 240);
            pen.Width = 3.0f;

            int shiftX = 45;
            int shiftY = 30;

            //Башня
            RectangleF Tower = new RectangleF(_startPosX - 3 + shiftX, _startPosY - 10 + shiftY, 50, 20);
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, Tower);
            //Корпус
            RectangleF Hull = new RectangleF(_startPosX - 45 + shiftX, _startPosY + 5 + shiftY, 140 , 15);
            g.FillRectangle(br, Hull);
            //Гусеницы
            g.DrawEllipse(pen, _startPosX - 51 + shiftX, _startPosY + 18 + shiftY, 25, 24);
            g.DrawEllipse(pen, _startPosX + 75 + shiftX, _startPosY + 18 + shiftY, 25, 24);
            Rectangle Caterpillars = new Rectangle(Convert.ToInt32(_startPosX - 44 + shiftX), Convert.ToInt32(_startPosY + 20 + shiftY), 137, 23);
            g.FillRectangle(br = new SolidBrush(BackgroundColor), Caterpillars);
            g.DrawLine(pen, _startPosX - 45 + shiftX, _startPosY + 42 + shiftY, _startPosX + 95+shiftX , _startPosY + 42 + shiftY);
            
            g.DrawEllipse(pen, _startPosX - 46 + shiftX, _startPosY + 19 + shiftY, 20, 20);
            int t = 25;
            for (int i = 0; i < 4; i++)
            {
                g.DrawEllipse(pen, _startPosX - 43 + t + shiftX, _startPosY + 29 + shiftY, 10, 10);
                t += 25;
            }
            g.DrawEllipse(pen, _startPosX + 75 + shiftX, _startPosY + 19 + shiftY, 20, 20);
            //Пушка
            if (Gun)
            {
                pen.Width = 8.0f;
                pen.Color = DopColor;

                g.DrawLine(pen, _startPosX + 12 + shiftX, _startPosY - 5 + shiftY, _startPosX + 37 + shiftX, _startPosY -15 + shiftY);
                g.DrawLine(pen, _startPosX + 15 +shiftX, _startPosY + shiftY, _startPosX + 70+shiftX, _startPosY - 25 + shiftY);
            }
            //Радиолокатор
            if (Radiolocation)
            {
                pen.Width = 4.0f;
                g.DrawLine(pen, _startPosX +shiftX, _startPosY + shiftY, _startPosX+shiftX, _startPosY - 20 + shiftY);
                pen.Width = 2.0f;
                g.DrawLine(pen, _startPosX + 10+shiftX, _startPosY + shiftY, _startPosX+shiftX, _startPosY - 20 + shiftY);
                g.FillPolygon(br = new SolidBrush(DopColor), new[]{
                    new Point(Convert.ToInt32(_startPosX + 5 + shiftX), Convert.ToInt32(_startPosY - 15 + shiftY)),
                    new Point(Convert.ToInt32(_startPosX - 5 + shiftX), Convert.ToInt32(_startPosY - 25 + shiftY)),
                    new Point(Convert.ToInt32(_startPosX +shiftX), Convert.ToInt32(_startPosY - 30 + shiftY)),
                    new Point(Convert.ToInt32(_startPosX + 10 +shiftX), Convert.ToInt32(_startPosY - 20 + shiftY))
                });
                g.FillPolygon(br = new SolidBrush(DopColor), new[]{
                    new Point(Convert.ToInt32(_startPosX + 15 +shiftX), Convert.ToInt32(_startPosY - 15 + shiftY)),
                    new Point(Convert.ToInt32(_startPosX + 15+shiftX), Convert.ToInt32(_startPosY - 25 + shiftY)),
                    new Point(Convert.ToInt32(_startPosX + 5+shiftX), Convert.ToInt32(_startPosY - 35 + shiftY)),
                    new Point(Convert.ToInt32(_startPosX - 5+shiftX), Convert.ToInt32(_startPosY - 35 + shiftY))
                });

            }


        }


    }
}
