using System;


namespace Video_12_Generic_Обобщения
{
    class Babana<T> : Product<T>
    {
        public Babana(string name, T volume, T calories) : base(name, volume, calories)
        {
        }
    }
}
