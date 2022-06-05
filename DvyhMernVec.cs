using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class DvyhMernVec : Vector
    {
        public int x, y;
        public double res;
        public DvyhMernVec()
        {
            this.x = 0;
            this.y = 0;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите координату x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void VDvyhMernVe()
        {
            res = Math.Sqrt(x * x + y * y);
        }
        public override void GetInfo()
        {
            VDvyhMernVe();
            Console.WriteLine($"Длина двумерного вектора: {res}");
        }
    }
}
