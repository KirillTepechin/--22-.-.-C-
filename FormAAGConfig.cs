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
    public partial class FormAAGConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        Vehicle armoredVehicle = null;
        /// <summary>
        /// Событие
        /// </summary>
        private Action<Vehicle> ArmoredVehicleEvent;
        public FormAAGConfig()
        {
            InitializeComponent();
            
            foreach(Control control in groupBoxColors.Controls)
            {
                control.MouseDown += new MouseEventHandler(panelColor_MouseDown);
            }
            labelDopColor.DragEnter += labelBaseColor_DragEnter;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawArmoredVehicle()
        {
            if (armoredVehicle != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxArmoredVehicle.Width, pictureBoxArmoredVehicle.Height);
                Graphics gr = Graphics.FromImage(bmp);
                armoredVehicle.SetPosition(5, 5, pictureBoxArmoredVehicle.Width, pictureBoxArmoredVehicle.Height);
                armoredVehicle.DrawTransport(gr);
                pictureBoxArmoredVehicle.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (ev == null)
            {
                ArmoredVehicleEvent = ev;
            }
            else
            {
                ArmoredVehicleEvent += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelArmoredVehicle_MouseDown(object sender, MouseEventArgs e)
        {
            labelArmoredVehicle.DoDragDrop(labelArmoredVehicle.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelAAG_MouseDown(object sender, MouseEventArgs e)
        {
            labelAAG.DoDragDrop(labelAAG.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelArmoredVehicle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelArmoredVehicle_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Бронетранспорт":
                    armoredVehicle = new ArmoredVehicle((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Зенитка":
                    armoredVehicle = new AntiAircraftGun((int)numericUpDownMaxSpeed.Value,
                    (int)numericUpDownWeight.Value, Color.White, Color.Black,
                   checkBoxGun.Checked, checkBoxRadiolocation.Checked);
                    break;
            }
            DrawArmoredVehicle();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Control panel = (Control)sender;
            panel.DoDragDrop(panel.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (armoredVehicle != null)
            {
                armoredVehicle.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawArmoredVehicle();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if(armoredVehicle is AntiAircraftGun && armoredVehicle!=null)
            {
                (armoredVehicle as AntiAircraftGun).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawArmoredVehicle();
            }
        }
        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            ArmoredVehicleEvent?.Invoke(armoredVehicle);
            Close();
        }
    }
}
