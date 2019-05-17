using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Video_15_Delegate_Event
{
    public class Class1
    {
        private int field;

        public event EventHandler Event;

        public Class1(int Id, string Name)
        {
            throw new System.NotImplementedException();
        }

        public int Id
        {
            get => default;
            set
            {
            }
        }

        public int Name
        {
            get => default;
            set
            {
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}