using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormAAG
{
    public class Hangar<T> where T : class, ITransport
    {
        /// <summary>
        /// Список объектов, которые храним
        /// </summary>
        private readonly List<T> _places;
        /// <summary>
        /// Максимальное количество мест в ангаре
        /// </summary>
        private readonly int _maxCount;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 80;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Размер ангара - ширина</param>
        /// <param name="picHeight">Размер ангара - высота</param>
        public Hangar(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: в ангар добавляется бронетранспорт
        /// </summary>
        /// <param name="h">Ангар</param>
        /// <param name="ArmoredVehicle">Добавляемый бронетранспорт</param>
        /// <returns></returns>
        public static int operator +(Hangar<T> h, T ArmoredVehicle)
        {
            if (h._maxCount == h._places.Count)
            {
                return -1;
            }
            else
            {
                h._places.Add(ArmoredVehicle);
                return h._places.Count-1;
            }
           
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с ангара забираем технику
        /// </summary>
        /// <param name="h">Ангар</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь  объект</param>
        /// <returns></returns>
        public static T operator -(Hangar<T> h, int index)
        {
            if (index>h._maxCount||index<0)
            {
                return null;
            }
            else
            {
                T tmp = h._places[index];
                h._places.Remove(h._places[index]);
                return tmp;
            }
        }
        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(5 + i % 3 * _placeSizeWidth + 5, i / 3 *
                (_placeSizeHeight + 9) + 12, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            int shift = 9;
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * (_placeSizeHeight + shift),
                    i * _placeSizeWidth + _placeSizeWidth / 2 + 50, j * (_placeSizeHeight + shift));
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * (_placeSizeHeight + shift));

            }
        }
    }
}
