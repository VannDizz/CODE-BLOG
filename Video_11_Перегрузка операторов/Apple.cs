using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_11_Перегрузка_операторов
{
    class Apple : Product
    {
        /// <summary>
        /// Данные о продукте
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="calorie">Калорий в 100гр</param>
        /// <param name="volume">Объём продукта в граммах</param>
        public Apple(string name, int calorie, int volume) : base(name, calorie, volume)
        {
        }


        /// <summary>
        /// Сложение двух яблок
        /// </summary>
        /// <param name="apple1">Первое яблоко</param>
        /// <param name="apple2">Второе яблоко</param>
        /// <returns></returns>
        public static Apple Add (Apple apple1, Apple apple2)
        {
            var calories = (apple1.Calorie + apple2.Calorie)/2;
            var volume = apple1.Volume + apple2.Volume;
            var newApple = new Apple("Новое", calories,volume);

            return newApple;
        }


        /// <summary>
        /// Перегрузка оператора 
        /// </summary>
        /// <param name="apple1">1</param>
        /// <param name="apple2">2</param>
        /// <returns></returns>
        public static Apple operator+ (Apple apple1, Apple apple2)
        {
            var calories = (apple1.Calorie + apple2.Calorie) / 2;
            var volume = apple1.Volume + apple2.Volume;
            var newApple = new Apple("Новое", calories, volume);

            return newApple;
        }

        public static Apple operator + (Apple apple, int volume)
        {
            var newVolume = new Apple("Новый объём", apple.Calorie, apple.Volume + volume);
            return newVolume;
        }
    }
}
