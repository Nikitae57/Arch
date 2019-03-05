using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace lab2.server {
	public class Server : ServerInterface {
		
		private const int Port = 80;
		private readonly List<ClientHandler> handlers = new List<ClientHandler>();
		
		public void Start() {
			var ip = IPAddress.Parse("127.0.0.1");
			var listener = new TcpListener(ip, Port);
			listener.Start();
			Console.WriteLine("Started server");

			while (true) {
				var client = listener.AcceptTcpClient();
				var handler = new ClientHandler(client, this);
				handler.startHandling();
				handlers.Add(handler);
			}	
		}

		public void sendToEveryone(string msg) {
			foreach (var handler in handlers) {
				handler.sendToClient(msg);
			}
		}

		public void disconnectUser(string ip) {
			int i = 0;
			
			foreach (var handler in handlers) {
				if (handler.clientIp == ip) {
					break;
				}
				i++;
			}

			handlers.Remove(handlers[i]);
		}
	}
}