using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormAAG
{
	public class ArmoredVehicle : Vehicle
	{
		/// <summary>
		/// Ширина отрисовки автомобиля
		/// </summary>
		protected readonly int armoredVehicleWidth = 90;
		/// <summary>
		/// Высота отрисовки автомобиля
		/// </summary>
		protected readonly int armoredVehicleHeight = 50;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		public ArmoredVehicle(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		/// <summary>
		/// Конструкторс изменением размеров машины
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		/// <param name="carWidth">Ширина отрисовки автомобиля</param>
		/// <param name="carHeight">Высота отрисовки автомобиля</param>
		protected ArmoredVehicle(int maxSpeed, float weight, Color mainColor, int armoredVehicleWidth, int
	   armoredVehicleHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.armoredVehicleHeight = armoredVehicleHeight;
			this.armoredVehicleWidth = armoredVehicleWidth;
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - armoredVehicleWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 0)
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
					if (_startPosY + step < _pictureHeight - armoredVehicleHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTransport(Graphics g)
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
			RectangleF Hull = new RectangleF(_startPosX - 45 + shiftX, _startPosY + 5 + shiftY, 140, 15);
			g.FillRectangle(br, Hull);
			//Гусеницы
			g.DrawEllipse(pen, _startPosX - 51 + shiftX, _startPosY + 18 + shiftY, 25, 24);
			g.DrawEllipse(pen, _startPosX + 75 + shiftX, _startPosY + 18 + shiftY, 25, 24);
			Rectangle Caterpillars = new Rectangle(Convert.ToInt32(_startPosX - 44 + shiftX), Convert.ToInt32(_startPosY + 20 + shiftY), 137, 23);
			g.FillRectangle(br = new SolidBrush(BackgroundColor), Caterpillars);
			g.DrawLine(pen, _startPosX - 45 + shiftX, _startPosY + 42 + shiftY, _startPosX + 95 + shiftX, _startPosY + 42 + shiftY);

			g.DrawEllipse(pen, _startPosX - 46 + shiftX, _startPosY + 19 + shiftY, 20, 20);
			int t = 25;
			for (int i = 0; i < 4; i++)
			{
				g.DrawEllipse(pen, _startPosX - 43 + t + shiftX, _startPosY + 29 + shiftY, 10, 10);
				t += 25;
			}
			g.DrawEllipse(pen, _startPosX + 75 + shiftX, _startPosY + 19 + shiftY, 20, 20);
		}
	}
}
