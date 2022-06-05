using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class TrehMernVec : Vector
    {
        public int x, y, z;
        public double res;
        public TrehMernVec()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите координату x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату z: ");
            z = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void VTrehMernVe()
        {
            res = Math.Sqrt(x * x + y * y + z * z);
        }
        public override void GetInfo()
        {
            VTrehMernVe();
            Console.WriteLine($"Длина трёхмерного вектора: {res}");
        }
    }
}