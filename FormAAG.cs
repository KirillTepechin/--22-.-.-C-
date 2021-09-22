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
	public partial class Form1 : Form
	{
		private AntiAircraftGun Aag;
		public Form1()
		{
			InitializeComponent();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxAAG.Width, pictureBoxAAG.Height);
			Graphics gr = Graphics.FromImage(bmp);
			Aag.DrawTransport(gr);
			pictureBoxAAG.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			Aag = new AntiAircraftGun();
			Aag.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkGreen,
				Color.DarkOliveGreen, true, true);
			Aag.SetPosition(rnd.Next(10, 100),
				rnd.Next(10, 100), pictureBoxAAG.Width, pictureBoxAAG.Height);
			
			Draw();
		}
		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			
				switch (name)
				{
					
					case "buttonUp":
						if (Aag != null)
						{
							Aag.MoveTransport(Direction.Up);
						}
						else
						{
							MessageBox.Show("Сначала создайте зенитку!!");
							return;
						}
						break;
					case "buttonDown":
					if (Aag != null)
					{
						Aag.MoveTransport(Direction.Down);
					}
					else
					{
						MessageBox.Show("Сначала создайте зенитку!!");
						return;
					}
					break;
				case "buttonLeft":
					if (Aag != null)
					{
						Aag.MoveTransport(Direction.Left);
					}
					else
					{
						MessageBox.Show("Сначала создайте зенитку!!");
						return;
					}
					break;
				case "buttonRight":
					if (Aag != null)
					{
						Aag.MoveTransport(Direction.Right);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
