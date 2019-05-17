using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_13_Interface_Интерфейсы
{
    class Lada : ICar
    {
        public int Move(int distance)
        {
            return distance / 40;
        }
    }
}
