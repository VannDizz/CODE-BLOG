using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_11_Перегрузка_операторов
{
    class Meat : Product
    {
        /// <summary>
        /// Данные о продукте
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="calorie">Калорий в 100гр</param>
        /// <param name="volume">Объём продукта в граммах</param>
        public Meat(string name, int calorie, int volume) : base(name, calorie, volume)
        {
        }
    }
}
