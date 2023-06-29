# csharp-RandomNumberGenerator
C#随机数程序
using System;: 导入System命名空间，其中包含了许多常用的类型和方法。
class Program { ... }: 定义名为Program的类，是程序的入口点。
static void Main() { ... }: 主函数的开始和结束。
int minRange, maxRange, count;: 声明整型变量minRange、maxRange和count，用于存储用户输入的最小范围、最大范围和随机数的数量。
Console.Write("请输入随机数的最小范围: ");: 输出提示信息，要求用户输入随机数的最小范围。
minRange = int.Parse(Console.ReadLine());: 从标准输入中获取用户输入的最小范围，并将其转换为整数类型，存储在变量minRange中。
Console.Write("请输入随机数的最大范围: ");: 输出提示信息，要求用户输入随机数的最大范围。
maxRange = int.Parse(Console.ReadLine());: 从标准输入中获取用户输入的最大范围，并将其转换为整数类型，存储在变量maxRange中。
Console.Write("请输入要生成的随机数的数量: ");: 输出提示信息，要求用户输入要生成的随机数的数量。
count = int.Parse(Console.ReadLine());: 从标准输入中获取用户输入的随机数数量，并将其转换为整数类型，存储在变量count中。
Random random = new Random();: 创建一个Random对象，用于生成随机数。
Console.Write("生成的随机数为: ");: 输出提示信息，表示即将打印生成的随机数。
for (int i = 0; i < count; i++) { ... }: 循环count次，用于生成指定数量的随机数。
int randomNumber = random.Next(minRange, maxRange + 1);: 使用Next方法生成minRange（包括）到maxRange（包括）之间的随机整数，存储在变量randomNumber中。
Console.Write(randomNumber + " ");: 打印当前生成的随机数。
Console.WriteLine();: 在生成随机数的循环结束后，输出一个换行符，将光标移动到下一行。
