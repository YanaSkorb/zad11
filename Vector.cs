using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Vector
    {
        public string name;
        public Vector()
        {
            this.name = null;
        }
        public virtual void Input()
        {
            Console.WriteLine("Введите название вектора");
            name = Console.ReadLine();
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Название {name}");
        }
    }

}