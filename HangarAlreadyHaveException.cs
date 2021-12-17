using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormAAG
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже есть транспорт с такими же характеристиками"
    /// </summary>
    public class HangarAlreadyHaveException : Exception
    {
        public HangarAlreadyHaveException() : base("В ангаре уже есть такой бронетранспорт")
        { }
    }
}
