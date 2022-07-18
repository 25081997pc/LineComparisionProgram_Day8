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
            MeasureLineLength line1 = new MeasureLineLength(1);
            MeasureLineLength line2 = new MeasureLineLength(2);
            double lengthofLine1 = Math.Sqrt(Math.Pow((line1.x2 - line1.x1), 2) + Math.Pow((line1.y2 - line1.y1), 2));
            double lengthofLine2 = Math.Sqrt(Math.Pow((line2.x2 - line2.x1), 2) + Math.Pow((line2.y2 - line2.y1), 2));

            if (lengthofLine2 == lengthofLine1)
            {
                Console.WriteLine("Both lines are Equal or Identical");
            }
            else
            {
                Console.WriteLine("Both lines are not Identical");
            }
        }
    }
}
