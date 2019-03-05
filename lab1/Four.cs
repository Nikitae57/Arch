using System;

namespace ConsoleApplication1 {
	public static class Four {
		public static void doFour() {
			Console.WriteLine("Введите число: ");
			var range = Convert.ToInt32(Console.ReadLine());

			var tmp = 1;
			for (var i = 1; i <= range; i++) {
				tmp *= i;
			}
			
			Console.WriteLine(tmp);
		}
	}
}