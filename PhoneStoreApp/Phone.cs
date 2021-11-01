using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStoreApp
{
    class Phone:Product
    {
        public string System;
        public int RAM;

        public Phone(string System , int ram , int id , string name , string brand , int quantity , double price):base(id , name , brand , quantity , price)
        {
            this.System = System;
            this.RAM = ram;
        }

        public override string ToString()
        {
            return base.ToString() + $"System: {this.System} - RAM: {this.RAM}";
        }

    }
}
