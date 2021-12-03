using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormAAG
{
    /// <summary>
    /// Класс-ошибка "Если не найден бронетранспорт по определенному месту"
    /// </summary>
    public class HangarNotFoundException : Exception
    {
        public HangarNotFoundException(int i) : base("Не найден бронетранспорт по месту "+ i)
        { }
    }
}
