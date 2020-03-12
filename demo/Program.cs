using System;

namespace demo
{
    class Program
   static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        int 冷氣卡 = 1000;

        while (true)
        {
            
            if (冷氣卡 <= 0)
            {
                Console.WriteLine("請重新儲值...");
                break;
            }

            //檢查是否有人開冷氣
            int 每次花費 = 0;
            string attackString;
            attackString = Console.ReadLine();
            每次花費 = int.Parse(attackString);
            //Console.WriteLine(attack);

            //扣血
            冷氣卡 = hp - attack;

        }
        Console.ReadLine();
    }
}