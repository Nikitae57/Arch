using System;
using System.Threading;

namespace lab2.server {
	public class MainClass {
		public static void Main(String[] args) {
			var server = new Server();
			server.Start();
		}
	}
}