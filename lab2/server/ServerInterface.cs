using System;

namespace lab2.server {
	public interface ServerInterface {
		void sendToEveryone(String msg);
		void disconnectUser(String  ip);
	}
}