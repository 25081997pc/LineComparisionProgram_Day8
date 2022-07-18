using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision_Day8
{
    public class MeasureLineLength
    {
        int x1, x2, y1, y2;
        public MeasureLineLength(int num)
        {
            if (num != 0)
            {
                Console.WriteLine("Enter X start coordinate number of line{0} i.e x1 : ", num);
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Y start coordinate number of line{0} i.e y1 : ", num);
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter X end coordinate number of line{0} i.e x2 : ", num);
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Y end coordinate number of line{0} i.e y2 : ", num);
                y2 = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void MeasuretheLength()
        {
            MeasureLineLength line = new MeasureLineLength(1);
            double lengthofLine = Math.Sqrt(Math.Pow((line.x2 - line.x1), 2) + Math.Pow((line.y2 - line.y1), 2));
            Console.WriteLine("Length of Line is : " + lengthofLine);
        }
    }
}
