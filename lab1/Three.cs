using System;

namespace ConsoleApplication1 {
	public static class Three {
		public static void doThree() {
			Console.WriteLine("Введите число: ");
			var range = Convert.ToInt32(Console.ReadLine());
			
			var one = 0;
			var two = 1;
			int tmp; 
			
			while ((tmp = one + two) <= range) {
				Console.WriteLine(tmp);
				one = two;
				two = tmp;
			}
		}
	}
}