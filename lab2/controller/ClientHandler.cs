using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Timers;

namespace lab2.server {
	public class ClientHandler {

		public TcpClient client;
		private ServerInterface sender;
		private StreamWriter writer;
		private System.Timers.Timer heartBeatTimer;
		public string clientIp;

		public ClientHandler(TcpClient client, ServerInterface sender) {
			this.client = client;
			this.sender = sender;
			clientIp = ((IPEndPoint) client.Client.RemoteEndPoint).Address.ToString();
			setTimer();
		}

		private void setTimer() {
			heartBeatTimer = new System.Timers.Timer(5000);
			heartBeatTimer.Elapsed += disconnect;
			heartBeatTimer.Enabled = true;
			heartBeatTimer.Start();
		}

		public void startHandling() {
			var stream = client.GetStream();
			var reader = new StreamReader(stream);
			writer = new StreamWriter(stream);

			var thread = new Thread(readMessages);
			thread.Start(reader);
		}

		public void sendToClient(String msg) {
			writer.WriteLine(msg);
			writer.Flush();
		}

		private void readMessages(object r) {
			var reader = (StreamReader) r;
			while (true) {
				try {
					var msg = reader.ReadLine();
					if (!msg.Equals(Messages.HeartbeatMsg.Alive))
					{
						sender.sendToEveryone(msg);
						Console.WriteLine(msg);
					}
				
					heartBeatTimer.Stop();
					heartBeatTimer.Start();
				}
				catch (Exception e) {
					Console.WriteLine("Client disconnected");
					disconnect(null, null);
					break;
				}
			}
		}

		private void disconnect(Object source, ElapsedEventArgs e) {
//			client.GetStream().Close();
//			client.Close();
			sender.disconnectUser(client);
		}
	}
}