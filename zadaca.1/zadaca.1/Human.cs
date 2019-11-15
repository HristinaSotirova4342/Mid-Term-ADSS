using System;
using System.Collections.Generic;
using System.Text;

namespace zadaca._1
{
    class Human
    {
        public string Creation { get; set; }

        public virtual void Talk()
        {
            Console.WriteLine("I am a human");
        }
    }
    class Man : Human
    {
        public override void Talk()
        {
            Console.WriteLine("I am a man");
        }
    }

    class Woman : Human
    {
        public override void Talk()
        {
            Console.WriteLine("I am a woman");
        }
    }
}
