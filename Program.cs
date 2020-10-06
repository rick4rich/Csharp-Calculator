using System;

namespace All_In_One
{
	class Program
	{
		public static string operation;
		public static double num1;
		public static double num2;
		public static double result;
		public static char need;
		public static int time = 5;


		static void Main()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("+-------------------+");
			Console.WriteLine("+----calculator-----+");
			Console.WriteLine("+-------------------+");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Blue;			
			Console.WriteLine("===================================");
			Console.ResetColor();
			Console.WriteLine("                                           "
				+ "                                        ");
			Console.WriteLine("1 FOR ADDITION");
			Console.WriteLine("2 FOR SUBTRACTION");
			Console.WriteLine("3 FOR MULTIPLICATION");
			Console.WriteLine("4 FOR DIVISION");

			Console.Write("Enter the operation you need: ");
			operation = Console.ReadLine();

			//Condition

			if (operation == "1")
			{
				Addition();

			}else if (operation == "2")
			{
				Subtraction();

			}else if (operation == "3")
			{
				Multiplication();

			}else if (operation == "4")
			{
				Division();
			}else
			{
				Console.WriteLine("Invalid Input");
				Console.Write("Do you Want to Continue y/n: ");
				need = Convert.ToChar(Console.ReadLine());
				if (need == 'y')
				{
					Awesome();
				}else if (need == 'n')
				{
					Console.WriteLine("Okay!");
				}
				else
				{
					for (int i = 0; i < time; i++)
					{
						Console.Beep();
					}
				}
			}
 
			//ending
			Console.ReadKey();
		}

		public static void Addition()
		{
			Console.Write("Enter your first Number: ");
			num1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter your first Number: ");
			num2 = Convert.ToDouble(Console.ReadLine());
			result = num1 + num2;
			Console.WriteLine(result);
			Console.Write("Do you Want to Continue y/n: ");
			need = Convert.ToChar(Console.ReadLine());
			if (need == 'y')
			{
				Awesome();
			}

		}
		public static void Subtraction()
		{
			Console.Write("Enter your first Number: ");
			num1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter your first Number: ");
			num2 = Convert.ToDouble(Console.ReadLine());
			result = num1 - num2;
			Console.WriteLine(result);
			Console.Write("Do you Want to Continue y/n: ");
			need = Convert.ToChar(Console.ReadLine());
			if (need == 'y')
			{
				Awesome();
			}

		}
		public static void Multiplication()
		{
			Console.Write("Enter your first Number: ");
			num1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter your first Number: ");
			num2 = Convert.ToDouble(Console.ReadLine());
			result = num1 * num2;
			Console.Write(result);
			Console.Write("Do you Want to Continue y/n: ");
			need = Convert.ToChar(Console.ReadLine());
			if (need == 'y')
			{
				Awesome();
			}else
			{

			}

		}
		public static void Division()
		{
			Console.Write("Enter your first Number: ");
			num1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter your first Number: ");
			num2 = Convert.ToDouble(Console.ReadLine());
			result = num1 / num2;
			Console.WriteLine(result);
			Console.Write("Do you Want to Continue y/n: ");
			need = Convert.ToChar(Console.ReadLine());
			if (need == 'y')
			{
				Awesome();
			}else
			{
			
			}

		}

		public static void Awesome()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("+-------------------+");
			Console.WriteLine("+----calculator-----+");
			Console.WriteLine("+-------------------+");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("===================================");
			Console.ResetColor();
			Console.WriteLine("                                           "
				+ "                                        ");
			Console.WriteLine("1 FOR ADDITION");
			Console.WriteLine("2 FOR SUBTRACTION");
			Console.WriteLine("3 FOR MULTIPLICATION");
			Console.WriteLine("4 FOR DIVISION");

			Console.Write("Enter the operation you need: ");
			operation = Console.ReadLine();

			//Condition

			if (operation == "1")
			{
				Addition();

			}
			else if (operation == "2")
			{
				Subtraction();

			}
			else if (operation == "3")
			{
				Multiplication();

			}
			else if (operation == "4")
			{
				Division();
			}
			else
			{
				Console.WriteLine("Invalid Input");
				Console.Write("Do you Want to Continue y/n: ");
				need = Convert.ToChar(Console.ReadLine());
				if (need == 'y')
				{
					Main();
				}else if (need == 'n')
				{
					Console.WriteLine("Okay!");
				}
				else
				{
					for (int i = 0; i < time; i++)
					{
						Console.Beep();
					}
				}

			}

			//ending
			Console.ReadKey();
		}



	}
}
