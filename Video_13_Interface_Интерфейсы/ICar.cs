namespace Video_13_Interface_Интерфейсы
{
    interface ICar
    {
        /// <summary>
        /// Выполнить перемещение
        /// </summary>
        /// <param name="distance">Дистанция</param>
        /// <returns>Возвращаем время движения</returns>
        int Move(int distance);
    }
}
