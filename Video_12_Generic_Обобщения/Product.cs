using System;

namespace Video_12_Generic_Обобщения
{
    class Product<T>
    {
        public string Name { get; set; }
        public T Volume { get; set; }
        public T Calories { get; set; }
        public T Energy { get; set; }

        public Product (string name, T volume, T calories)
        {
            //TODO: Запилить провеку

            Name = name;
            Volume = volume;
            Calories = calories;
        }

    }
}
