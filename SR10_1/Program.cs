using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("Введите данные");
                int grad_ = Convert.ToInt32(Console.ReadLine());
                int min_ = Convert.ToInt32(Console.ReadLine());
                int sec_ = Convert.ToInt32(Console.ReadLine());

                angle = new Angle(grad_, min_, sec_);
            }
            while (angle.isCorrect == false);

            double countAngle = angle.ToRadians();
            Console.WriteLine(countAngle);

            Console.ReadKey();
        }
    }
}
