using System;

class Program
{
    static void Main()
    {
        int minRange, maxRange, count;

        // 获取用户输入的范围和数量
        Console.Write("请输入随机数的最小范围: ");
        minRange = int.Parse(Console.ReadLine());

        Console.Write("请输入随机数的最大范围: ");
        maxRange = int.Parse(Console.ReadLine());

        Console.Write("请输入要生成的随机数的数量: ");
        count = int.Parse(Console.ReadLine());

        // 创建随机数生成器
        Random random = new Random();

        // 生成随机数并打印
        Console.Write("生成的随机数为: ");
        for (int i = 0; i < count; i++)
        {
            int randomNumber = random.Next(minRange, maxRange + 1);
            Console.Write(randomNumber + " ");
        }
        Console.WriteLine();
    }
}
