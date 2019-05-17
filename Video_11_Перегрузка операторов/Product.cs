using System;

namespace Video_11_Перегрузка_операторов
{
    public abstract class Product
    {
        /// <summary>
        /// Наименование продукта
        /// </summary>
        public string Name { get;  }
        
        /// <summary>
        /// Калорийность на 100 грамм продукта
        /// </summary>
        public int Calorie { get;  }
        
        /// <summary>
        /// Объём продукта
        /// </summary>
        public int Volume { get; set; }

        /// <summary>
        /// Энергетическая ценность продукта
        /// </summary>
        public double Energy
        {
            get
            {
                return Volume * Calorie / 100;
            }
        }
       
        public Product(string name, int calorie, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (calorie < 0)
            {
                throw new ArgumentException(nameof(calorie));
            }

            if (volume <= 0)
            {
                throw new ArgumentException(nameof(volume));
            }

           

            Name = name;
            Calorie = calorie;
            Volume = volume;


        }
        /// <summary>
        /// Что-то там
        /// </summary>
        /// <returns> Строкааа</returns>
        public override string ToString()
        {
            return $"Название {Name}. Масса: {Volume} Калорийность в 100гр: {Calorie} Калорийность общая {Energy}";
        }

    }
}
