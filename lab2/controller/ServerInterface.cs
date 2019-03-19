using System;
using System.Net.Sockets;

namespace lab2.server {
	public interface ServerInterface {
		void sendToEveryone(String msg);
		void disconnectUser(TcpClient client);
	}
}