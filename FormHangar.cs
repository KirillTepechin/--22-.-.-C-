using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormAAG
{
    public partial class FormHangar : Form
    {
        /// <summary>
        /// Объект от класса-коллекции ангаров
        /// </summary>
        private readonly HangarCollection hangarCollection;
        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;
        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxHangar.Width,
            pictureBoxHangar.Height);
            logger = LogManager.GetCurrentClassLogger();
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
            logger.Info($"Добавили ангар {textBoxNewLevelName.Text}");
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
                    logger.Info($"Удалили ангар{ listBoxHangars.SelectedItem.ToString()}");
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
                try
                {
                    var armoredVehicle =
                    hangarCollection[listBoxHangars.SelectedItem.ToString()] -
                    Convert.ToInt32(maskedTextBox.Text);
                    if (armoredVehicle != null)
                    {
                        FormAAG form = new FormAAG();
                        form.SetArmoredVehicle(armoredVehicle);
                        form.ShowDialog();
                        logger.Info($"Изъят бронетранспорт {armoredVehicle} с места { maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch (HangarNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    logger.Warn("Не найдено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Возникла ошибка - " + ex.Message);
                }
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxHangars_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли в ангар {listBoxHangars.SelectedItem.ToString()}");
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
        /// <param name="armoredVehicle"></param>
        private void AddArmoredVehicle(Vehicle armoredVehicle)
        {
            if (armoredVehicle != null && listBoxHangars.SelectedIndex > -1)
            {
                try
                {
                    if ((hangarCollection[listBoxHangars.SelectedItem.ToString()]) + armoredVehicle >= 0)
                    {
                        Draw();
                        logger.Info($"Добавлен бронетранспорт {armoredVehicle}");
                    }
                    else
                    {
                        MessageBox.Show("Бронетранспорт не удалось поставить");
                    }
                    Draw();
                }
                catch (HangarOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    logger.Warn("Не удалось поставить бронетранспорт");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Возникла ошибка - " + ex.Message);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            { 
                try
                {
                    hangarCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Возникла ошибка - " + ex.Message);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.LoadData(openFileDialog.FileName);

                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();

                }
                catch (HangarOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Возникла ошибка - "+ex.Message);
                }
            }
        }
	}
}
