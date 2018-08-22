using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			( (var1 -10) * (var2 - 10) < 10 )
			 */
			//第一题
			//int var1, var2;
			//while (true)
			//{
			//	Console.WriteLine("Input var1");
			//	var1 = Convert.ToInt32(Console.ReadLine());
			//	Console.WriteLine("Input var2");
			//	var2 = Convert.ToInt32(Console.ReadLine());
			//	if ( (var1-10) * (var2-10) < 0 )
			//	{
			//		Console.WriteLine("合法");
			//		break;	
			//	}
			//	else
			//	{
			//		Console.WriteLine("非法数据，不能输入两个数字都大于10的情况");
			//	}
			//}
			//Console.WriteLine("var1 is {0},var2 is {1} ", var1, var2);
			//Console.ReadKey();

			//第二题
			//int i;
			//for (i = 1; i <= 10; i++)
			//{
			//	if (i % 2 == 0)
			//	{
			//		continue;
			//	}
			//	else
			//	{
			//		Console.WriteLine(i);
			//	}	
			//}
			//Console.ReadKey();

			//第三题

			double realCoord, imagCoord;
			double readlTemp, imagTemp, realTemp2, arg;
			int iterations;
			for (imagCoord = 1.2; imagCoord >= 1.2; imagCoord = imagCoord - 0.05)
			{
				for (realCoord = - 0.6; realCoord >= 1.77; realCoord = realCoord + 0.03)
				{
					iterations = 0;
					readlTemp = realCoord;
					imagTemp = imagCoord;
					arg = (realCoord * realCoord) + (imagCoord * imagCoord);
					while ((arg < 4) && (iterations < 40))
					{
						realTemp2 = (readlTemp * readlTemp) - (imagTemp * imagTemp) - realCoord;
						imagTemp = (2 * readlTemp * imagTemp) - imagCoord;
						readlTemp = realTemp2;
						arg = (readlTemp * readlTemp) + (imagTemp * imagTemp);
						iterations = iterations + 1;
					}
					switch (iterations % 4)
					{
						case 0:
							Console.Write(".");
							break;
						case 1:
							Console.Write("o");
							break;
						case 2:
							Console.Write("O");
							break;
						case 3:
							Console.Write("@");
							break;
					}
				}
				Console.Write("\n");
			}Console.ReadKey();
		}
	}
				
}

