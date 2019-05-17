using System;


namespace Video_12_Generic_Обобщения
{
    class Apple<T> : Product<T>
    {
        public Apple(string name, T volume, T calories) : base(name, volume, calories)
        {

        }
    }
}
