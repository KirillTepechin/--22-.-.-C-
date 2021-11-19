using System;
using System.Collections.Generic;
using System.IO;
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
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';
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
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.Default))
            {
                sw.WriteLine($"HangarCollection");
                foreach (var level in hangarStages)
                {
                    //Начинаем парковку
                    sw.WriteLine($"Hangar{separator}{level.Key}");
                    ITransport ArmoredVehicle = null;
                    for (int i = 0; (ArmoredVehicle = level.Value.GetNext(i)) != null; i++)
                    {
                        if (ArmoredVehicle != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (ArmoredVehicle.GetType().Name == "ArmoredVehicle")
                            {
                                sw.Write($"\tArmoredVehicle{separator}");
                            }
                            if (ArmoredVehicle.GetType().Name == "AntiAircraftGun")
                            {
                                sw.Write($"\tAntiAircraftGun{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(ArmoredVehicle);
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename, Encoding.Default))
            {
                string strs = sr.ReadLine();

                if (strs.Contains("HangarCollection"))
                {
                    //очищаем записи
                    hangarStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                Vehicle ArmoredVehicle = null;
                string key = string.Empty;
                while ((strs=sr.ReadLine())!=null)
                {
                    //идем по считанным записям
                    if (strs.Contains("Hangar"))
                    {//начинаем новую парковку
                        key = strs.Split(separator)[1];
                        hangarStages.Add(key, new Hangar<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(strs))
                    {
                        continue;
                    }
                    if (strs.Split(separator)[0] == "\tArmoredVehicle")
                    {
                        ArmoredVehicle = new ArmoredVehicle(strs.Split(separator)[1]);
                    }
                    else if (strs.Split(separator)[0] == "\tAntiAircraftGun")
                    {
                        ArmoredVehicle = new AntiAircraftGun(strs.Split(separator)[1]);
                    }
                    var result = hangarStages[key] + ArmoredVehicle;
                    if (result < 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
