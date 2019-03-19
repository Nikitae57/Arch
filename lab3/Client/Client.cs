using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace lab3.Client
{
	public class Client
	{
		private string nickname;
		private TcpClient client;

		private StreamReader reader;
		private StreamWriter writer;
		public System.Timers.Timer timer;

		public Client(string nickname, string ip, string port)
		{
			this.nickname = nickname;
			try
			{
				client = new TcpClient(ip, Convert.ToInt32(port));

				reader = new StreamReader(client.GetStream());
				writer = new StreamWriter(client.GetStream());
				timer = KeepAlive();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private System.Timers.Timer KeepAlive()
		{
			System.Timers.Timer timer = new System.Timers.Timer(1000);
			timer.Elapsed += eventKeepAlive;
			timer.Start();
			return timer;
		}

		public string ReceivingMessages()
		{
			try
			{
				return (reader.ReadLine() + "\n");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void SendMessage(string msg)
		{
			string formedMsg = nickname + ": " + msg;
			try
			{
				writer.WriteLine(formedMsg);
				writer.Flush();
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					ex.Message,
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1,
					MessageBoxOptions.DefaultDesktopOnly);
			}
		}

		public void eventKeepAlive(Object source, ElapsedEventArgs e)
		{
			try
			{
				writer.WriteLine(Messages.HeartbeatMsg.Alive);
				writer.Flush();
			}
			catch (Exception ex)
			{
				timer.Stop();
				MessageBox.Show(
					ex.Message,
					"Ошибка ",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1,
					MessageBoxOptions.DefaultDesktopOnly);
				Application.Exit();
			}
			
		}
	}

	
}
