using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            DvyhMernVec dvyhMernVec = new DvyhMernVec();
            TrehMernVec trehMernVec = new TrehMernVec();
            int name = 0;
            Console.WriteLine("Выберите вектор: \n1-двумерный \n2-трёхмерный");
            name = Convert.ToInt32(Console.ReadLine());
            switch (name)
            {
                case 1:
                    dvyhMernVec.Input(); dvyhMernVec.GetInfo();
                    break;
                case 2:
                    trehMernVec.Input(); trehMernVec.GetInfo();
                    break;
            }

        }
    }
}
