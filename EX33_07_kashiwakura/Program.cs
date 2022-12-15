using System;

namespace EX33
{
    class program
    {
        static void Main()
        {
            RectAngle rectAngle1 = new RectAngle(5, 1);
            RectAngle rectAngle2 = new RectAngle(3, 2);
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }
            RectAngle rectAngle3 = rectAngle1 + rectAngle2;
            Console.WriteLine($"2つの長方形が入る最小の長方形は ({rectAngle3.width},{rectAngle3.height})");
        }
    }
}
