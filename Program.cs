namespace CardAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CalArea cal;
            Circle cir;
            Rectangle rec;
            while (true)
            {
                Console.Write("請輸入收集的卡片形狀?(1.圓形 2.矩形 3.離開)");
                int item = int.Parse(Console.ReadLine());
                if (item == 1)
                {
                    Console.Write("請輸入圓形卡片面積:");
                    int r = int.Parse(Console.ReadLine());
                    cir = new Circle(r);
                    cal = new CalArea(cir);
                }

                else if (item == 2)
                {
                    Console.Write("請輸入矩形卡片高度:");
                    int h = int.Parse(Console.ReadLine());
                    Console.Write("請輸入矩形卡片寬度:");
                    int w = int.Parse(Console.ReadLine());
                    rec = new Rectangle(h,w);
                    cal = new CalArea(rec);
                }
                else
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}