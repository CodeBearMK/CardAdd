using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAdd
{
    internal class CalArea
    {
        private static double totArea;
        public CalArea(Card c)
        {
            totArea += c.area();
            Console.WriteLine("本卡片面積為{0}，目前累積面積為 {1}", c.area(), totArea);
        }
    }
}
