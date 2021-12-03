using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormAAG
{
    /// <summary>
    /// Класс-ошибка "Если в ангаре уже заняты все места"
    /// </summary>
    public class HangarOverflowException : Exception
    {
        public HangarOverflowException() : base("В ангаре нет свободных мест")
        { }
    }
}
