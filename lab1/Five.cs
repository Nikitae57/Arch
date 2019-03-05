using System;
using System.Collections.Generic;

namespace ConsoleApplication1 {
	public static class Five {
		public static void doFive() {
			Console.WriteLine("Введите число: ");
			var range = Convert.ToInt32(Console.ReadLine());
			
			var simples = new List<int>();
			for (var i = 2; i <= range; i++) {
				simples.Add(i);
			}
			
			var p = -1;
			while (true) {
				var prevP = p;
				foreach (var simple in simples) {
					if (simple > p) {
						p = simple;
						break;
					}
				}
				
				for (var i = 2  * p; i <= range; i += p) {
					if (simples[i - 2] % p == 0) {
						simples[i - 2] = -1;
					}
				}

				if (prevP == p) { break; }
			}
			
			foreach (var simple in simples) {
				if (simple != -1) {
					Console.WriteLine(simple);
				}
			}
		}
	}
}