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
        /// Объект от класса-коллекции ангаров
        /// </summary>
        private readonly HangarCollection hangarCollection;
        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxHangar.Width,
            pictureBoxHangar.Height);
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxHangars.SelectedIndex;
            listBoxHangars.Items.Clear();
            
            for (int i = 0; i < hangarCollection.Keys.Count; i++)
            {
                listBoxHangars.Items.Add(hangarCollection.Keys[i]);
            }
            if (listBoxHangars.Items.Count > 0 && (index == -1 || index >=
            listBoxHangars.Items.Count))
            {
                listBoxHangars.SelectedIndex = 0;
            }
            else if (listBoxHangars.Items.Count > 0 && index > -1 && index <
            listBoxHangars.Items.Count)
            {
                listBoxHangars.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        private void Draw()
        {
            if (listBoxHangars.SelectedIndex > -1)
            {   //если выбран один из пуктов в listBox (при старте программы ни один пункт
                //не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width,
                pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangarCollection[listBoxHangars.SelectedItem.ToString()].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить ангар"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddHangar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название Ангара", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hangarCollection.AddHangar(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Удалить ангар"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelHangar_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить Ангар { listBoxHangars.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hangarCollection.DelParking(listBoxHangars.SelectedItem.ToString());
                    ReloadLevels();
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
            if (listBoxHangars.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var armoredVehicle = hangarCollection[listBoxHangars.SelectedItem.ToString()] -
               Convert.ToInt32(maskedTextBox.Text);
                if (armoredVehicle != null)
                {
                    FormAAG form = new FormAAG();
                    form.SetArmoredVehicle(armoredVehicle);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxHangars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить бронетранспорт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetArmoredVehicle_Click(object sender, EventArgs e)
        {
            var formAAGConfig = new FormAAGConfig();
            formAAGConfig.AddEvent(AddArmoredVehicle);
            formAAGConfig.Show();
        }
        /// <summary>
        /// Метод добавления транспорта
        /// </summary>
        /// <param name="car"></param>
        private void AddArmoredVehicle(Vehicle armoredVehicle)
        {
            if (armoredVehicle != null && listBoxHangars.SelectedIndex > -1)
            {
                if ((hangarCollection[listBoxHangars.SelectedItem.ToString()]) + armoredVehicle >= 0)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Бронетранспорт не удалось поставить");
                }
            }
        }
    }
}
