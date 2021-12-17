using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormAAG
{
    public class AntiAircraftGun : ArmoredVehicle, IEquatable<AntiAircraftGun>

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
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        public AntiAircraftGun(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool gun, bool radiolocation) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            Gun = gun;
            Radiolocation = radiolocation;
        }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public AntiAircraftGun(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Gun = Convert.ToBoolean(strs[4]);
                Radiolocation = Convert.ToBoolean(strs[5]);
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(MainColor);
            Brush br = new SolidBrush(MainColor);
            int shiftX = 45;
            int shiftY = 30;
            //Пушка
            if (Gun)
            {
                pen.Width = 8.0f;
                pen.Color = DopColor;

                g.DrawLine(pen, _startPosX + 12 + shiftX, _startPosY - 5 + shiftY, _startPosX + 37 + shiftX, _startPosY - 15 + shiftY);
                g.DrawLine(pen, _startPosX + 15 + shiftX, _startPosY + shiftY, _startPosX + 70 + shiftX, _startPosY - 25 + shiftY);
            }
            //Радиолокатор
            if (Radiolocation)
            {
                pen.Width = 4.0f;
                g.DrawLine(pen, _startPosX + shiftX, _startPosY + shiftY, _startPosX + shiftX, _startPosY - 20 + shiftY);
                pen.Width = 2.0f;
                g.DrawLine(pen, _startPosX + 10 + shiftX, _startPosY + shiftY, _startPosX + shiftX, _startPosY - 20 + shiftY);
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

            base.DrawTransport(g);
        }
        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Gun}{separator}{Radiolocation}";
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса AntiAircraftGun
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(AntiAircraftGun other)
        {
            if (!Equals((ArmoredVehicle)other))
            {
                return false;
            }
            if (Gun != other.Gun)
            {
                return false;
            }
            if (Radiolocation != other.Radiolocation)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is AntiAircraftGun AAGObj))
            {
                return false;
            }
            else
            {
                return Equals(AAGObj);
            }
        }
    }
}
