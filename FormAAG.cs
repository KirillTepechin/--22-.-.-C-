using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormAAG
{
	public partial class FormAAG : Form
	{
		private ITransport armoredVehicle;
		public FormAAG()
		{
			InitializeComponent();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxAAG.Width, pictureBoxAAG.Height);
			Graphics gr = Graphics.FromImage(bmp);
			armoredVehicle.DrawTransport(gr);
			pictureBoxAAG.Image = bmp;
		}
		private void buttonCreateArmoredVehicle_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			armoredVehicle = new ArmoredVehicle(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkGreen);
			armoredVehicle.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAAG.Width,
		   pictureBoxAAG.Height);
			Draw();
		}
		private void buttonCreateAag_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			armoredVehicle = new AntiAircraftGun(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkGreen,
		   Color.DarkOliveGreen, true, true);
			armoredVehicle.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAAG.Width,
		   pictureBoxAAG.Height);
			Draw();

		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			
				switch (name)
				{
					case "buttonUp":
						if (armoredVehicle != null)
						{
							armoredVehicle.MoveTransport(Direction.Up);
						}
						else
						{
							MessageBox.Show("Сначала создайте зенитку!!");
							return;
						}
						break;
					case "buttonDown":
					if (armoredVehicle != null)
					{
						armoredVehicle.MoveTransport(Direction.Down);
					}
					else
					{
						MessageBox.Show("Сначала создайте зенитку!!");
						return;
					}
					break;
				case "buttonLeft":
					if (armoredVehicle != null)
					{
						armoredVehicle.MoveTransport(Direction.Left);
					}
					else
					{
						MessageBox.Show("Сначала создайте зенитку!!");
						return;
					}
					break;
				case "buttonRight":
					if (armoredVehicle != null)
					{
						armoredVehicle.MoveTransport(Direction.Right);
					}
					else
					{
						MessageBox.Show("Сначала создайте зенитку!!");
						return;
					}
					break;

			}

			Draw();
		}
	}
}
