using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
	public partial class Chat : Form
	{
		private bool isExit = false;
		private Client.Client client;
		public Chat(Client.Client client)
		{
			InitializeComponent();
			this.client = client;
			Thread updateTextThread = new Thread(new ThreadStart(UpdateTextBox));
			updateTextThread.Start();
		}

		private void UpdateTextBox()
		{

			while (!isExit)
			{
				try
				{
					var msg = client.ReceivingMessages();
					if (msg != null && !chatBox.IsDisposed)
					{
						this.Invoke((MethodInvoker) delegate { 
							chatBox.AppendText(msg);
							chatBox.AppendText(Environment.NewLine); 
						});
					}
				}
				catch (Exception ex)
				{
//					MessageBox.Show(
//					ex.Message,
//					"Ошибка",
//					MessageBoxButtons.OK,
//					MessageBoxIcon.Error,
//					MessageBoxDefaultButton.Button1,
//					MessageBoxOptions.DefaultDesktopOnly);
					Application.Exit();
				}
				
				if (IsDisposed || chatBox.IsDisposed)
				{
					return;
				}
			}
		}

		private void button_sendMessage_Click(object sender, EventArgs e)
		{
			var msg = textMessage.Text;
			if (msg != null && !msg.Equals(""))
			{
				client.SendMessage(msg);
				textMessage.Text = "";
			}
		}

		private void Chat_FormClosed(object sender, FormClosedEventArgs e)
		{
			client.timer.Stop();
			isExit = true;
			Application.Exit();
		}

	}
}
