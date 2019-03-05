using System;

namespace ConsoleApplication1 {
	public static class Two {
		public static void doTwo() {
			for (var year = 1900; year <= 2000; year++) {
				var isLeap = DateTime.IsLeapYear(year);
				Console.WriteLine("{0} - високосный: {1}", year, isLeap);
			}
		}
	}
}