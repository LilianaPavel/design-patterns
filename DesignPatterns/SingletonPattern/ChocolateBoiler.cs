using System;

namespace DesignPatterns.SingletonPattern
{
    class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        private static ChocolateBoiler instance;

        private ChocolateBoiler()
        {
            this.empty = true;
            this.boiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChocolateBoiler();
                }
                return instance;
            }
        }

        // With double-check lock
        /*
        static object obj = new object();
        public static ChocolateBoiler Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)

                        if (instance == null)
                        {
                            instance = new ChocolateBoiler();
                        }
                    }
                }
                return instance;
            }
        }
        */

        public void Fill()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fill");
                this.empty = false;
                this.boiled = false;
            }
        }

        public void Drain()
        {
            if(!IsEmpty() && IsBoiled())
            {
                Console.WriteLine("Drain");
                this.empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                Console.WriteLine("Boil");
                boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return this.empty;
        }

        public bool IsBoiled()
        {
            return this.boiled;
        }
    }
}
