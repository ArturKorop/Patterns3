using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Singleton
{
    public class ChocolateBoiler
    {
        private bool isEmpty;
        private bool isBoiled;
        private static ChocolateBoiler instance = new ChocolateBoiler();

        public static ChocolateBoiler Instance
        {
            get
            {
                return instance;
            }
        }

        private ChocolateBoiler()
        {
            this.isBoiled = false;
            this.isEmpty = true;
        }

        public void Fill()
        {
            if (this.isEmpty)
            {
                this.isEmpty = false;
                this.isBoiled = false;
                "Filling".P();
            }
        }

        public void Drain()
        {
            if (!this.isEmpty && !this.isBoiled)
            {
                this.isBoiled = true;
                "Draining".P();
            }
        }
    }
}