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
    public partial class FormHangar : Form
    {
        /// <summary>
        /// Объект от класса-ангара
        /// </summary>
        private readonly Hangar<ArmoredVehicle> hangar;
        public FormHangar()
        {
            InitializeComponent();
            hangar = new Hangar<ArmoredVehicle>(pictureBoxHangar.Width,
           pictureBoxHangar.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            hangar.Draw(gr);
            pictureBoxHangar.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать бронетранспорт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetArmoredVehicle_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var Aag = new ArmoredVehicle(100, 1000, dialog.Color);
                
                if (hangar + Aag>=0)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать зенитку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetAAG_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var Aag = new AntiAircraftGun(100, 1000, dialog.Color, dialogDop.Color,
                    true, true);
                    
                    if (hangar + Aag>=0)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Взять бронетранспорт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeArmoredVehicle_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var armoredVehicle = hangar - Convert.ToInt32(maskedTextBox.Text);
                if (armoredVehicle != null)
                {
                    FormAAG form = new FormAAG();
                    form.SetArmoredVehicle(armoredVehicle);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
