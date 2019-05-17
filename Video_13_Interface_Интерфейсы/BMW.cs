using System;


namespace Video_13_Interface_Интерфейсы
{
    class BMW : ICar
    {
        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}
