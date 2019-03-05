using System;

namespace ConsoleApplication1 {
	public static class One {
		public static void doOne(string[] args) {
			foreach (var arg in args) {
				Console.WriteLine(arg);
			}
		}
	}
}