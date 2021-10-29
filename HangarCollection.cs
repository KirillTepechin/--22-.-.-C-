using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormAAG
{   /// <summary>
    /// Класс-коллекция ангаров
    /// </summary>
    public class HangarCollection
    {
        /// <summary>
        /// Словарь (хранилище) с ангарами
        /// </summary>
        readonly Dictionary<string, Hangar<Vehicle>> hangarStages;
        /// <summary>
        /// Возвращение списка названий ангаров
        /// </summary>
        public List<string> Keys => hangarStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public HangarCollection(int pictureWidth, int pictureHeight)
        {
            hangarStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление ангара
        /// </summary>
        /// <param name="name">Название ангара</param>
        public void AddHangar(string name)
        {
            if (!hangarStages.ContainsKey(name))
            {
                hangarStages.Add(name, new Hangar<Vehicle>(pictureWidth, pictureHeight));
            }
        }
        /// <summary>
        /// Удаление ангара
        /// </summary>
        /// <param name="name">Название ангара</param>
        public void DelParking(string name)
        {
            if (hangarStages.ContainsKey(name))
            {
                hangarStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к ангару
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Hangar<Vehicle> this[string ind]
        {
            get
            {
                if (hangarStages.ContainsKey(ind))
                {
                    return hangarStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
